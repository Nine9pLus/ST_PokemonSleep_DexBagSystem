using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonSleep.Utility
{
	public static class DataGridViewHelper
	{
		/// <summary>
		/// 根據內容自動調整欄位寬度，若資料總寬度小於 DataGridView 寬度，額外平均分配剩餘寬度給文字欄位。
		/// </summary>
		public static void AutoSizeColumnsByContent(DataGridView dgv, int extraPadding = 0)
		{
			if (dgv == null || dgv.ColumnCount == 0) return;

			// Step 1. 用 AutoSize 先調整各欄位寬度
			foreach (DataGridViewColumn col in dgv.Columns)
			{
				col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
			}

			// Step 2. 計算目前內容總寬（全部欄位）
			int totalWidth = dgv.Columns.Cast<DataGridViewColumn>().Sum(c => c.Width);
			int clientWidth = dgv.ClientSize.Width - extraPadding;

			// Step 3. 多餘寬度分配給文字欄位
			if (totalWidth < clientWidth)
			{
				// 抓所有 TextBox 欄位（不包含按鈕/圖片/編號）
				var textColumns = dgv.Columns
					.Cast<DataGridViewColumn>()
					.Where(c => c is DataGridViewTextBoxColumn && c.Visible)
					.ToList();

				if (textColumns.Count > 0)
				{
					int extra = (clientWidth - totalWidth) / textColumns.Count;

					foreach (var col in textColumns)
					{
						col.Width += extra;
					}
				}
			}

			// Step 4. 最終固定欄位寬度，避免使用者拖曳或再次重計
			foreach (DataGridViewColumn col in dgv.Columns)
			{
				col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			}
		}

		//public static void BoxAutoSizeColumnsByContent(DataGridView dgv, int extraPadding = 0)
		//{
		//	if (dgv == null || dgv.ColumnCount == 0) return;

		//	string[] fixedCols = { "colNo", "colEdit", "colDelete" };

		//	// 文字欄位中可調整者
		//	var flexibleColumns = dgv.Columns.Cast<DataGridViewColumn>()
		//		.Where(c => !fixedCols.Contains(c.Name)
		//				 && c is DataGridViewTextBoxColumn
		//				 && c.Visible)
		//		.ToList();

		//	// 固定欄不動
		//	foreach (DataGridViewColumn col in dgv.Columns)
		//	{
		//		if (fixedCols.Contains(col.Name) || !(col is DataGridViewTextBoxColumn))
		//		{
		//			col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
		//		}
		//	}

		//	// 設為 AutoSize 看內容
		//	foreach (var col in flexibleColumns)
		//	{
		//		col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
		//	}

		//	// 💡 關鍵：先讓 UI 套用寬度變動
		//	dgv.Refresh();
		//	Application.DoEvents(); // 解決過早統計寬度問題

		//	// 總寬計算
		//	int fixedWidth = dgv.Columns.Cast<DataGridViewColumn>()
		//		.Where(c => fixedCols.Contains(c.Name) || !(c is DataGridViewTextBoxColumn))
		//		.Sum(c => c.Width);

		//	int flexWidth = flexibleColumns.Sum(c => c.Width);

		//	int clientWidth = dgv.ClientSize.Width - extraPadding;
		//	int totalNow = fixedWidth + flexWidth;

		//	// 加寬 or 壓縮
		//	if (totalNow < clientWidth && flexibleColumns.Count > 0)
		//	{
		//		int extra = (clientWidth - totalNow) / flexibleColumns.Count;
		//		foreach (var col in flexibleColumns)
		//		{
		//			col.Width += extra;
		//		}
		//	}
		//	else if (totalNow > clientWidth && flexibleColumns.Count > 0)
		//	{
		//		double ratio = (double)(clientWidth - fixedWidth) / flexWidth;
		//		foreach (var col in flexibleColumns)
		//		{
		//			col.Width = Math.Max(40, (int)(col.Width * ratio));
		//		}
		//	}

		//	// 鎖定為 None
		//	foreach (var col in flexibleColumns)
		//	{
		//		col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
		//	}
		//}
		//public static void BoxAutoSizeColumnsByContent(DataGridView dgv, int extraPadding = 0)
		//{
		//	if (dgv == null || dgv.Columns.Count == 0) return;

		//	// 固定欄欄名，這些不參與自動調整
		//	string[] fixedCols = { "colNo", "colEdit", "colDelete" };

		//	var flexibleColumns = dgv.Columns.Cast<DataGridViewColumn>()
		//		.Where(c => !fixedCols.Contains(c.Name)
		//			&& c is DataGridViewTextBoxColumn
		//			&& c.Visible)
		//		.ToList();

		//	// 固定欄不要調整
		//	foreach (DataGridViewColumn col in dgv.Columns)
		//	{
		//		if (fixedCols.Contains(col.Name) || !(col is DataGridViewTextBoxColumn))
		//		{
		//			col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
		//		}
		//	}

		//	// 彈性欄先用 AutoSizeMode 估計寬度
		//	foreach (var col in flexibleColumns)
		//	{
		//		col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
		//	}

		//	// 強制刷新，讓剛設定的內容生效
		//	dgv.Refresh();
		//	Application.DoEvents();

		//	// 再鎖回 None，固定現在的寬度以利後續調整
		//	foreach (var col in flexibleColumns)
		//	{
		//		col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
		//	}

		//	// 計算寬度（記得保留垂直捲軸空間）
		//	int scrollbarBuffer = SystemInformation.VerticalScrollBarWidth;
		//	int clientWidth = dgv.ClientSize.Width - extraPadding - scrollbarBuffer;

		//	int fixedWidth = dgv.Columns.Cast<DataGridViewColumn>()
		//		.Where(c => fixedCols.Contains(c.Name) || !(c is DataGridViewTextBoxColumn))
		//		.Sum(c => c.Width);

		//	int flexWidth = flexibleColumns.Sum(c => c.Width);
		//	int totalNow = fixedWidth + flexWidth;

		//	if (flexibleColumns.Count == 0) return;

		//	if (totalNow < clientWidth)
		//	{
		//		// 情況：內容總寬 < 顯示區寬 → 平均補寬
		//		int extra = (clientWidth - totalNow) / flexibleColumns.Count;
		//		foreach (var col in flexibleColumns)
		//		{
		//			col.Width += extra;
		//		}
		//	}
		//	else
		//	{
		//		// 情況：內容總寬 > 顯示區寬 → 壓縮彈性欄
		//		double ratio = (double)(clientWidth - fixedWidth) / flexWidth;
		//		foreach (var col in flexibleColumns)
		//		{
		//			col.Width = Math.Max(50, (int)(col.Width * ratio));
		//		}
		//	}
		//}


		//public static void BoxUniformColumns(DataGridView dgv, int extraPadding = 0)
		//{
		//	if (dgv == null || dgv.ColumnCount == 0) return;

		//	// 可見欄位數（不要平均到隱藏欄）
		//	var visibleCols = dgv.Columns.Cast<DataGridViewColumn>()
		//		.Where(c => c.Visible)
		//		.ToList();

		//	if (visibleCols.Count == 0) return;

		//	int clientWidth = dgv.ClientSize.Width - extraPadding;
		//	int avgWidth = clientWidth / visibleCols.Count;

		//	// 設定每欄等寬、不自動展開
		//	foreach (var col in visibleCols)
		//	{
		//		col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
		//		col.Width = avgWidth;
		//	}
		//}

		public static void BoxAutoSizeColumnsByContent(DataGridView dgvBag)
		{
			if (dgvBag.ColumnCount == 0) return;

			// === Step 1：固定寬欄（不分配） ===
			string[] fixedCols = { "colNo", "colEdit", "colDelete" };

			// 總固定欄寬度
			int fixedWidth = dgvBag.Columns
				.Cast<DataGridViewColumn>()
				.Where(c => fixedCols.Contains(c.Name))
				.Sum(c => c.Width);

			// 設定這些欄位為固定，不動寬
			foreach (DataGridViewColumn col in dgvBag.Columns)
			{
				if (fixedCols.Contains(col.Name))
				{
					col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
					// 寬度在 Load 時就設定過了 → 這裡不重設寬度
				}
			}

			// === Step 2：可變欄位：取得剩餘空間 & 平均分配 ===
			var flexibleCols = dgvBag.Columns
				.Cast<DataGridViewColumn>()
				.Where(c => !fixedCols.Contains(c.Name) && c.Visible)
				.ToList();

			if (flexibleCols.Count == 0) return;

			int availableWidth = dgvBag.ClientSize.Width - fixedWidth - 50; // 減去邊界/捲軸預留空間

			int widthPerColumn = availableWidth / flexibleCols.Count;

			foreach (var col in flexibleCols)
			{
				col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
				col.Width = widthPerColumn;
				col.DefaultCellStyle.WrapMode = DataGridViewTriState.True; // 內容太長時可換行
			}

			dgvBag.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dgvBag.ClearSelection();
		}

	}

}
