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
		/// 根據內容自動調整欄位寬度，
		/// 若資料總寬度小於DataGridView寬度，額外平均分配剩餘寬度給每欄。
		/// </summary>
		public static void AutoSizeColumnsByContent(DataGridView dgv, int extraPadding = 0)
		{
			if (dgv == null || dgv.ColumnCount == 0) return;

			// 先用 AutoSize 調整
			foreach (DataGridViewColumn col in dgv.Columns)
			{
				col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells; // 更快準
			}

			// 總寬計算
			int totalWidth = 0;
			foreach (DataGridViewColumn col in dgv.Columns)
			{
				totalWidth += col.Width;
			}

			int clientWidth = dgv.ClientSize.Width - extraPadding;

			if (totalWidth < clientWidth)
			{
				int extra = (clientWidth - totalWidth) / dgv.Columns.Count;

				foreach (DataGridViewColumn col in dgv.Columns)
				{
					col.Width += extra;
				}
			}

			// 最終固定寬度，避免再次 resize
			foreach (DataGridViewColumn col in dgv.Columns)
			{
				col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			}
		}

	}

}
