using PokemonSleep.Service;
using PokemonSleep.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST_PokemonSleep_DexBagSystem
{
	public partial class UcBrowserPage : UserControl
	{
		private readonly BrowseService _browseService = new BrowseService();

		public UcBrowserPage()
		{
			InitializeComponent();
			this.Load += UcBrowserPage_Load;

			#region 設定 btnShowXCategory.Tag & Click事件
			btnShowCurrySoup.Tag = "咖哩、濃湯";
			btnShowSalad.Tag = "沙拉";
			btnShowDessertDrink.Tag = "甜點、飲料";

			btnShowCurrySoup.Click += CategoryButton_Click;
			btnShowSalad.Click += CategoryButton_Click;
			btnShowDessertDrink.Click += CategoryButton_Click;
			#endregion

			dgvBrowseResult.DataBindingComplete += dgvBrowseResult_DataBindingComplete;

		}

		private void UcBrowserPage_Load(object sender, EventArgs e)
		{
			// 執行時預載分類「咖哩、濃湯」
			LoadCategory("咖哩、濃湯");
		}

		private void CategoryButton_Click(object sender, EventArgs e)
		{
			if (sender is Button btn && btn.Tag is string group)
				LoadCategory(group);
		}

		private void LoadCategory(string group) //分類按鈕點擊事件
		{
			MessageBox.Show($"目前查詢分類: [{group}]");

			SetupImageColumn(); // // 先建好圖示欄（只建一次）

			dgvBrowseResult.DataSource = _browseService.GetRecipesByCategory(group);

			//LoadImages(); // 根據 image_url 實際載圖
			//AdjustColumnWidths(); // 圖片欄固定寬，其它欄填滿

			ResetCategoryButtons(group);

			// 欄寬調整
			//DataGridViewHelper.AutoSizeColumnsByContent(dgvBrowseResult, reservedFixedFirstColWidth: 80, padding: 40);
			//DataGridViewHelper.AutoSizeColumnsByContent(dgvBrowseResult, extraPadding: 60);

			// 按鈕狀態控制：目前分類的按鈕設定為 disabled
			foreach (Control ctrl in flpCategoryBar.Controls)
			{
				if (ctrl is Button btn && btn.Tag is string tag)
				{
					btn.Enabled = tag != group;
				}
			}
		}

		// Resize 事件會自動重新調整欄寬（有資料才會動作）
		private void dgvBrowseResult_Resize(object sender, EventArgs e)
		{
			if (dgvBrowseResult.Columns.Count == 0) return;

			#region 測試用 顯示欄數
			//MessageBox.Show($"欄位數：{dgvBrowseResult.Columns.Count}");
			#endregion

			DataGridViewHelper.AutoSizeColumnsByContent(dgvBrowseResult);
		}

		private void dgvBrowseResult_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			this.BeginInvoke(new Action(() =>
			{
				LoadImages();
				AdjustColumnWidths();

				DataGridViewHelper.AutoSizeColumnsByContent(dgvBrowseResult, 80);
				dgvBrowseResult.Invalidate(); // 強制重繪資料列與欄寬
			}));
		}


		private void SetupImageColumn() //建立「圖片欄」 DataGridViewImageColumn
		{
			if (!dgvBrowseResult.Columns.Contains("img"))
			{
				var imgCol = new DataGridViewImageColumn
				{
					Name = "img",
					HeaderText = "圖",
					Width = 80,
					ImageLayout = DataGridViewImageCellLayout.Zoom
				};
				dgvBrowseResult.Columns.Insert(0, imgCol); // 插在最前面
			}

			// 圖欄以外欄位自動調整內容寬
			dgvBrowseResult.RowTemplate.Height = 80;

			if (dgvBrowseResult.Columns.Contains("image_url"))
				dgvBrowseResult.Columns["image_url"].Visible = false;
		}

		private void LoadImages() //依據查詢結果動態載入圖檔
		{
			foreach (DataGridViewRow row in dgvBrowseResult.Rows)
			{
				if (row.IsNewRow) continue;

				string category = null;
				string imageFile = null;

				if (row.DataBoundItem is DataRowView rowView)
				{
					category = rowView["category"]?.ToString();
					imageFile = rowView["image_url"]?.ToString();
				}

				string path = AssetHelper.GetRecipeImagePath(category, imageFile);

				#region 測試用 圖片輸出檢查
				//MessageBox.Show($"category = {category ?? "null"}\nimageFile = {imageFile ?? "null"}");
				//if (path == null)
				//{
				//	MessageBox.Show($"找不到圖片路徑：\n分類={category}\n檔案={imageFile}");
				//	// 或 Console.WriteLine($"[找不到圖] {category}/{imageFile}");
				//}

				#endregion

				if (!string.IsNullOrEmpty(path) && File.Exists(path))
				{
					try
					{
						if (!string.IsNullOrEmpty(path) && File.Exists(path))
						{
							using (var img = Image.FromFile(path))
							{
								row.Cells["img"].Value = new Bitmap(img); // 避免鎖檔
							}
						}
						else
						{
							row.Cells["img"].Value = null;
							Console.WriteLine($"[圖片缺失] {category}/{imageFile}");
						}
					}
					catch (Exception ex)
					{
						Console.WriteLine($"[圖片載入錯誤] {category}/{imageFile}：{ex.Message}");
						row.Cells["img"].Value = null;
					}

				}
				else
				{
					row.Cells["img"].Value = null;
				}
			}
		}

		private void ResetCategoryButtons(string selected)
		{
			foreach (Control ctrl in flpCategoryBar.Controls)
			{
				if (ctrl is Button btn && btn.Tag is string tag)
				{
					btn.Enabled = tag != selected;
				}
			}
		}

		private void AdjustColumnWidths()
		{
			int totalWidth = dgvBrowseResult.ClientSize.Width;
			int imageWidth = 80;
			int columnCount = dgvBrowseResult.Columns.Count;

			// 平分除了圖片欄以外的寬度
			int otherColCount = columnCount - 1;
			if (otherColCount <= 0) return;

			int widthPerColumn = (totalWidth - imageWidth) / otherColCount;

			for (int i = 0; i < columnCount; i++)
			{
				if (dgvBrowseResult.Columns[i].Name == "img")
				{
					dgvBrowseResult.Columns[i].Width = imageWidth;
				}
				else
				{
					dgvBrowseResult.Columns[i].Width = widthPerColumn;
				}
			}
		}

	}

}
