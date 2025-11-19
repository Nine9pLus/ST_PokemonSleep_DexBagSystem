using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonSleep.Utility
{
	public static class DgvRecipeHelper
	{ /// <summary>
	  /// 統一處理：圖片欄載入、欄寬調整、去藍底選取
	  /// </summary>
	  /// <typeparam name="T">強型別：如 RecipeModel 類別</typeparam>
	  /// <param name="dgv">目標 DataGridView</param>
	  /// <param name="data">查詢結果(List<T>)</param>
	  /// <param name="getCategory">取分類的方法 (如 x => x.category)</param>
	  /// <param name="getImageFile">取圖檔名的方法 (如 x => x.image_url)</param>
		public static void BindRecipeGrid<T>(
			DataGridView dgv,
			List<T> data,
			Func<T, string> getCategory,
			Func<T, string> getImageFile)
		{
			dgv.Columns.Clear();
			dgv.DataSource = null;
			dgv.AutoGenerateColumns = false;

			// 加圖片欄
			dgv.Columns.Add(new DataGridViewImageColumn
			{
				Name = "img",
				HeaderText = "圖",
				Width = 80,
				ImageLayout = DataGridViewImageCellLayout.Zoom
			});

			// 文字欄
			dgv.Columns.Add(new DataGridViewTextBoxColumn
			{
				DataPropertyName = "name",
				Name = "name",
				Width = 150,
				HeaderText = "料理名稱",
				AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
			});
			dgv.Columns.Add(new DataGridViewTextBoxColumn
			{
				DataPropertyName = "description",
				Name = "description",
				HeaderText = "料理敘述",
				AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
			});

			dgv.DataSource = data;
			dgv.RowTemplate.Height = 80;

			// 載入圖片
			foreach (DataGridViewRow row in dgv.Rows)
			{
				if (row.IsNewRow) continue;
				if (row.DataBoundItem is T recipe)
				{
					string category = getCategory(recipe)?.Trim();
					string imageFile = getImageFile(recipe)?.Trim();
					string path = AssetHelper.GetRecipeImagePath(category, imageFile);

					if (!string.IsNullOrEmpty(path) && File.Exists(path))
					{
						using (var img = Image.FromFile(path))
						{
							row.Cells["img"].Value = new Bitmap(img);
						}
					}
					else
					{
						row.Cells["img"].Value = null;
					}
				}
			}

			// 欄寬美化
			AutoSizeColumnsAndClearSelect(dgv, 80);
		}

		/// <summary>
		/// 欄寬填滿與清除選取藍色背景
		/// </summary>
		/// <param name="dgv">目標 DataGridView</param>
		/// <param name="imageColWidth">圖片欄固定寬</param>
		public static void AutoSizeColumnsAndClearSelect(DataGridView dgv, int imageColWidth)
		{
			int totalWidth = dgv.ClientSize.Width;
			int colCount = dgv.Columns.Count;
			int fillCount = colCount - 1;
			int widthPerCol = fillCount > 0 ? (totalWidth - imageColWidth) / fillCount : 0;

			for (int i = 0; i < colCount; i++)
			{
				if (dgv.Columns[i].Name == "img")
					dgv.Columns[i].Width = imageColWidth;
				else
					dgv.Columns[i].Width = widthPerCol;
			}

			dgv.ClearSelection();
			dgv.Invalidate();
		}
	}
}
