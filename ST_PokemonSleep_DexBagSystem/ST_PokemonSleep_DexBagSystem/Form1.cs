using PokemonSleep.Models;
using PokemonSleep.SecurtyInterface;
using PokemonSleep.Service;
using ST_PokemonSleep_DexBagSystem.BagPageUC;
using ST_PokemonSleep_DexBagSystem.DexPageUC;
using ST_PokemonSleep_DexBagSystem.MainPageUserControl;
using ST_PokemonSleep_DexBagSystem.UserPageUC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ST_PokemonSleep_DexBagSystem
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			// 註冊 Resize 事件，把事件處理方法 Form1_Resize 掛到 Form1 的 Resize 事件上
			this.Resize += Form1_Resize;
		}

		private void Form1_Resize(object sender, EventArgs e)
		{
			CenterUcPageNavigator();
		}

		private UcPageNavigator ucPageNavigator;
		private void Form1_Load(object sender, EventArgs e)
		{
			#region 主畫面
			#endregion

			#region 跳轉(ucPageNavigator) v
			// 1. 建立 UcPageNavigator 實例
			ucPageNavigator = new UcPageNavigator();
			//ucPageNavigator.Dock = DockStyle.None;

			// 2. 加入到 panelNavigatorBar
			panelNavigatorBar.Controls.Add(ucPageNavigator);

			// 3. 註冊PageSwitched事件
			ucPageNavigator.PageSwitched += ucPageNavigator_PageSwitched;

			// 預設顯示主頁內容
			ShowPageContent("Main");

			// 4. 置中 UcPageNavigator
			CenterUcPageNavigator();
			#endregion

			#region 登入狀態(StripStatus) v
			// 1. 顯示主頁
			var mainPage = new UcMainPage();
			mainPage.Dock = DockStyle.Fill;

			// 2. 註冊從主頁傳出的登入事件
			mainPage.LoginCompleted += ucPageNavigator_LoginCompleted;

			panelMainContent.Controls.Clear();
			panelMainContent.Controls.Add(mainPage);

			// 3. 初始狀態
			toolStripStatusLabelUser.Text = "尚未登入";
			#endregion
		}

		private void ucPageNavigator_PageSwitched(object sender, PageSwitchEventArgs e)  // 當按下分頁按鈕時，顯示對應的內容
		{			
			// 根據 e.PageName 來決定顯示哪個 UserControl
			ShowPageContent(e.PageName);
			// 更新 ucPageNavigator 的當前頁面狀態
			ucPageNavigator.HighlightCurrentPage(e.PageName);
		}

		private void ucPageNavigator_LoginCompleted(object sender, UserModel user)
		{
			toolStripStatusLabelUser.Text = $"已登入，用戶：{user.Username}";
		}

		private void ShowPageContent(string pageName)   //根據 pageName 來決定顯示哪個 UserControl
		{
			// 清空 panelMainContent，然後載入對應的 UserControl
			panelMainContent.Controls.Clear();

			UserControl pageControl = null;
			switch (pageName)
			{
				case "Main":
					pageControl = new UcMainPage(); break;
				case "Dex":
					pageControl = new UcDexPage(); break;
				case "Bag":
					pageControl = new UcBagPage(); break;
				case "Browser":
					pageControl = new UcBrowserPage(); break;
				case "User":
					pageControl = new UcUserPage(); break;
			}

			if (pageControl != null)
			{
				pageControl.Dock = DockStyle.Fill;
				panelMainContent.Controls.Add(pageControl);
			}
		}

		private void CenterUcPageNavigator()
		{
			if (ucPageNavigator != null && panelNavigatorBar != null)
			{
				ucPageNavigator.Left = (panelNavigatorBar.Width - ucPageNavigator.Width) / 2;
				ucPageNavigator.Top = (panelNavigatorBar.Height - ucPageNavigator.Height) / 2;
			}
		}
	}
}

