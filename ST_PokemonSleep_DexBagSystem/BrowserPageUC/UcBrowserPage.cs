using PokemonSleep.Models;
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

			dgvBrowseResult.AutoGenerateColumns = false;
		}

		private void UcBrowserPage_Load(object sender, EventArgs e)
		{
			// Delay 調整，讓 Control 完整呈現後再計算欄寬
			this.BeginInvoke(new Action(() =>
			{
				LoadCategory("咖哩、濃湯"); 
			}));
		}

		private void CategoryButton_Click(object sender, EventArgs e)
		{
			if (sender is Button btn && btn.Tag is string group)
				LoadCategory(group);
		}

		private void LoadCategory(string category)
		{
			List<RecipeModel> recipes = _browseService.GetRecipesByCategory(category);

			// UI // 將資料與欄位設好
			DgvRecipeHelper.BindRecipeGrid(
				dgvBrowseResult,
				recipes,
				r => r.category,
				r => r.image_url
			);		

			// 按鈕狀態控制：目前分類的按鈕設定為 disabled
			foreach (Control ctrl in tableLayoutPanelCategoryBar.Controls)
			{
				if (ctrl is Button btn && btn.Tag is string tag)
				{
					btn.Enabled = tag != category;
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
				LoadImages();             // 載入圖片到 img 欄

				DataGridViewHelper.AutoSizeColumnsByContent(dgvBrowseResult);

				dgvBrowseResult.ClearSelection(); // 移除預設選取藍底
			}));
		}
		
		private void LoadImages() //依據查詢結果動態載入圖檔
		{
			foreach (DataGridViewRow row in dgvBrowseResult.Rows)
			{
				if (row.IsNewRow) continue;

				string category = null;
				string imageFile = null;
				if (row.DataBoundItem is RecipeModel recipe)
				{
					category = recipe.category?.Trim();
					imageFile = recipe.image_url?.Trim();
				}

				string path = AssetHelper.GetRecipeImagePath(category, imageFile);

				#region 測試用 圖片輸出檢查
				//MessageBox.Show(path ?? "path=null", "Debug 2");

				// 印出全部關鍵資訊，方便比對
				//MessageBox.Show(
				//	$"category: [{category ?? "null"}]\n" +
				//	$"imageFile: [{imageFile ?? "null"}]\n" +
				//	$"path: [{path ?? "null"}]\n" +
				//	$"File.Exists(path): [{(path != null && File.Exists(path) ? "true" : "false")}]",
				//	"Debug");

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
						using (var img = Image.FromFile(path))
						{
							row.Cells["img"].Value = new Bitmap(img);
						}
					}
					catch (Exception ex)
					{
						row.Cells["img"].Value = null;
						Console.WriteLine($"[圖片錯誤] {category}/{imageFile}：{ex.Message}");
					}
				}
				else
				{
					row.Cells["img"].Value = null;
					Console.WriteLine($"[圖片缺失] {category}/{imageFile}");
				}
			}
		}

	}
}
