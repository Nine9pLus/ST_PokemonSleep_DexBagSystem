using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST_PokemonSleep_DexBagSystem
{
	public partial class UcPageNavigator : UserControl
	{
		public UcPageNavigator()
		{
			InitializeComponent();

			#region 設定 btnGoToXPage.Tag & Click事件
			btnGoToMainPage.Tag = "Main";
			btnGoToDexPage.Tag = "Dex";
			btnGoToBagPage.Tag = "Bag";
			btnGoToBrowserPage.Tag = "Browser";
			btnGoToUserPage.Tag = "User";

			btnGoToMainPage.Click += NavButton_Click;
			btnGoToDexPage.Click += NavButton_Click;
			btnGoToBagPage.Click += NavButton_Click;
			btnGoToBrowserPage.Click += NavButton_Click;
			btnGoToUserPage.Click += NavButton_Click;
			#endregion
		}

		public event EventHandler<PageSwitchEventArgs> PageSwitched;
		private string _currentPage = "";   // 當前頁面名稱	

		/// <summary>
		///	按鈕共用事件處理方法，當任一導航按鈕被點擊時觸發。
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void NavButton_Click(object sender, EventArgs e)
		{
			//MessageBox.Show("Click 事件觸發");

			if (sender is Button btn && btn.Tag is string pageName)
			{
				//MessageBox.Show($"準備觸發 PageSwitched，Tag: {pageName}");

				// 觸發自訂事件，通知外部選擇了哪一頁
				PageSwitched?.Invoke(this, new PageSwitchEventArgs(pageName));
			}
		}

		/// <summary>
		/// 將目前選取的頁面名稱儲存為當前頁面，並更新此 UserControl 中所有按鈕的顯示狀態：
		/// 高亮顯示當前頁面對應的按鈕，並停用該按鈕；其他按鈕恢復預設背景色且啟用。
		/// </summary>
		/// <param name="pageName">指定要高亮顯示的頁面名稱，應與按鈕的 Tag 對應。</param>
		public void HighlightCurrentPage(string pageName)
		{
			_currentPage = pageName;

			// 遍歷這個 UserControl 內所有 Button
			foreach (Button btn in GetAllButtons(this))
			{
				if (btn.Tag is string tag)
				{
					// 根據 Tag 設定背景色和啟用狀態
					btn.BackColor = (tag == pageName) ? Color.LightBlue : SystemColors.Control;
					btn.Enabled = (tag != pageName); 
				}
			}
		}

		/// <summary>
		/// 遞迴搜尋指定容器控制項中所有的遞迴取得所有 Button 控制項。
		/// 包括巢狀結構中的按鈕（例如位於 TableLayoutPanel 或其他容器內）。 
		/// </summary>
		/// <param name="parent">作為搜尋起點的父控制項。</param>
		/// <returns>傳回一個列舉包含所有發現的 Button 控制項。</returns>
		private IEnumerable<Button> GetAllButtons(Control parent)	// 工具方法
		{
			foreach (Control ctrl in parent.Controls)
			{
				if (ctrl is Button btn)
					yield return btn;
				else if (ctrl.HasChildren)
				{
					foreach (var child in GetAllButtons(ctrl))
						yield return child;
				}
			}
		}
	}

	/// <summary>
	/// 提供分頁切換事件的資料，包含所要切換的頁面名稱。
	/// </summary>
	public class PageSwitchEventArgs : EventArgs
	{
		public string PageName { get; set; }
		public PageSwitchEventArgs(string pageName) => PageName = pageName;
	}
}
