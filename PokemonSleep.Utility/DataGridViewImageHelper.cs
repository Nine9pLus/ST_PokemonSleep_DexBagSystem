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
	public static class DataGridViewImageHelper
	{
		/// <summary>
		/// 在 DataGridView 中新增圖片欄，並依據指定欄位的檔名自動載入圖片。
		/// </summary>
		public static void AutoSizeColumnsByContent(DataGridView dgv, int reservedFixedFirstColWidth = 80, int padding = 60)
		{
			if (dgv == null || dgv.ColumnCount == 0) return;

			dgv.SuspendLayout();
			for (int i = 0; i < dgv.Columns.Count; i++)
			{
				if (i == 0)
				{
					dgv.Columns[i].Width = reservedFixedFirstColWidth;
					dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
				}
				else
				{
					dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
				}
			}

			int totalWidth = reservedFixedFirstColWidth;
			for (int i = 1; i < dgv.Columns.Count; i++)
				totalWidth += dgv.Columns[i].Width;

			int availableWidth = dgv.ClientSize.Width - padding;
			if (totalWidth < availableWidth)
			{
				int extra = (availableWidth - totalWidth) / (dgv.Columns.Count - 1);
				for (int i = 1; i < dgv.Columns.Count; i++)
					dgv.Columns[i].Width += extra;
			}

			foreach (var col in dgv.Columns.Cast<DataGridViewColumn>())
				col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

			dgv.ResumeLayout();
		}
	}
}
