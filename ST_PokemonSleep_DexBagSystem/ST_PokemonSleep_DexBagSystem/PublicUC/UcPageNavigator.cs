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

			#region

			#endregion

		}

		public event EventHandler<PageSwitchEventArgs> PageSwitched;
		private string _currentPage = "";   // 當前頁面名稱	
				
		private void NavButton_Click(object sender, EventArgs e)	// btn共用事件
		{
			if (sender is Button btn && btn.Tag is string pageName)
			{
				// 觸發自訂事件，通知外部選擇了哪一頁
				PageSwitched?.Invoke(this, new PageSwitchEventArgs(pageName));
			}
		}

		public void HighlightCurrentPage(string pageName)
		{
			_currentPage = pageName;

			// 遍歷這個 UserControl 內所有 Button
			foreach (Button btn in GetAllButtons(this))
			{
				if (btn.Tag is string tag)
				{
					btn.BackColor = (tag == pageName) ? Color.LightBlue : SystemColors.Control;
					btn.Enabled = (tag != pageName); // 禁用當前頁面按鈕
				}
			}
		}
		
		private IEnumerable<Button> GetAllButtons(Control parent)	// 工具方法：遞迴搜尋所有 Button（支援巢狀 TableLayoutPanel）
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

	public class PageSwitchEventArgs : EventArgs
	{
		public string PageName { get; set; }
		public PageSwitchEventArgs(string pageName) => PageName = pageName;
	}




}
