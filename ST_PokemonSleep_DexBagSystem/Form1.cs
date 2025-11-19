using PokemonSleep.Models;
using PokemonSleep.Utility;
using ST_PokemonSleep_DexBagSystem.BagPageUC;
using ST_PokemonSleep_DexBagSystem.DexPageUC;
using ST_PokemonSleep_DexBagSystem.MainPageUserControl;
using ST_PokemonSleep_DexBagSystem.UserPageUC;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ST_PokemonSleep_DexBagSystem
{
	public partial class Form1 : Form
	{
		private UcPageNavigator ucPageNavigator;
		private UserModel _currentUser = null; // 記錄目前登入的使用者，預設未登入
		private UcUserPage _ucUserPage = null;



		public Form1()
		{
			InitializeComponent();
			this.Resize += Form1_Resize;
			this.Load += Form1_Load;

		}

		private void Form1_Resize(object sender, EventArgs e)
		{
			CenterUcPageNavigator();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			#region 清空導覽列數量
			// 清掉 panelNavigatorBar 上所有已有的 UcPageNavigator（保險起見）
			foreach (var ctrl in panelNavigatorBar.Controls.OfType<UcPageNavigator>().ToList())
			{
				panelNavigatorBar.Controls.Remove(ctrl);
				ctrl.Dispose();
			}
			#endregion

			#region 導覽條初始化
			ShowPageContent("Main");

			ucPageNavigator = new UcPageNavigator();

			ucPageNavigator.PageSwitched += UcPageNavigator_PageSwitched;
			ucPageNavigator.Dock = DockStyle.None;

			panelNavigatorBar.Controls.Add(ucPageNavigator);
			CenterUcPageNavigator();

			ucPageNavigator.HighlightCurrentPage("Main");
			#endregion

			#region 顯示主頁
			ShowPageContent("Main");
			toolStripStatusLabelUser.Text = "尚未登入";
			#endregion

			#region 測試用 導覽列數量
			//int count = 0;
			//string info = "";

			//foreach (Control ctrl in panelNavigatorBar.Controls)
			//{
			//	count++;
			//	info += $"{count}. {ctrl.GetType().Name} / Name: {ctrl.Name}\n";
			//}

			//MessageBox.Show($"panalNavigatorBar 控制項數量：{count}\n\n{info}", "導覽列 Debug");
			#endregion
		}

		#region 測試用 導覽列數
		//private void Debug_NavigatorBar()
		//{
		//	int count = 0;
		//	string info = "";

		//	foreach (Control ctrl in panelNavigatorBar.Controls)
		//	{
		//		count++;
		//		info += $"{count}. {ctrl.GetType().Name} / Name: {ctrl.Name}\n";
		//	}

		//	MessageBox.Show($"panelNavigatorBar 控制項數量：{count}\n\n{info}", "導覽列 Debug");
		//}
		#endregion

		/// <summary>
		/// 處理頁面導覽列發出的頁面切換事件，根據事件引數中的頁面名稱切換主畫面內容，
		/// 並更新導覽列中當前頁面的高亮狀態。
		/// </summary>
		/// <param name="sender">事件的觸發來源，通常為 UcPageNavigator。</param>
		/// <param name="e">包含頁面名稱的 PageSwitchEventArgs 事件資料。</param>
		private void UcPageNavigator_PageSwitched(object sender, PageSwitchEventArgs e)
		{
			#region 測試用 顯示傳回的是頁面
			//MessageBox.Show($"傳回的頁面是 {e.PageName}");
			#endregion

			ShowPageContent(e.PageName);
			ucPageNavigator.HighlightCurrentPage(e.PageName);
		}

		/// <summary>
		/// 置中 UcPageNavigator 控制項於 panelNavigatorBar 中。
		/// </summary>
		private void CenterUcPageNavigator()
		{
			if (ucPageNavigator != null && panelNavigatorBar != null)
			{
				ucPageNavigator.Left = (panelNavigatorBar.Width - ucPageNavigator.Width) / 2;
				ucPageNavigator.Top = (panelNavigatorBar.Height - ucPageNavigator.Height) / 2;
			}
		}

		/// <summary>
		/// 根據pageName，顯示對應的頁面內容。
		/// </summary>
		/// <param name="pageName"></param>
		private void ShowPageContent(string pageName)
		{
			// 清空主內容區域的(舊的)所有控制項
			panelMainContent.Controls.Clear();

			Control pageControl = null;

			switch (pageName)
			{
				case "Main":
					if (_currentUser == null)   //未登入
					{
						var mainPage = new UcMainPage();
						mainPage.LoginCompleted += UcPageNavigator_LoginCompleted;
						//建立UcMainPage的同時，就要先註冊LoginCompleted事件，之後登入成功時，mainPage才能呼叫這個方法，這裡才能接收到通知並處理

						pageControl = mainPage;
					}
					else
					{
						var welcome = new UcWelcomePanel();
						welcome.SetUserInfo(_currentUser.Username, _currentUser.AvatarFile);

						// 防止重複事件註冊
						welcome.Logout -= WelcomePanel_Logout;
						welcome.Logout += WelcomePanel_Logout;

						pageControl = welcome; 
					}
					break;
				case "Dex":
					pageControl = new UcDexPage(); break;
				case "Bag":
					var bagPage = new UcBagPage();
					bagPage.SetLoginUser(_currentUser);		// 傳入登入時資訊
					pageControl = bagPage;                  // 加到容器中 
					break;
				case "Browser":
					pageControl = new UcBrowserPage(); break;
				case "User":
					if (_ucUserPage == null)
					{
						_ucUserPage = new UcUserPage();
						_ucUserPage.UserUpdated += UcUserPage_UserUpdated;
					}

					_ucUserPage.SetLoginUser(_currentUser);
					pageControl = _ucUserPage;
					break;
			}

			if (pageControl != null)
			{
				pageControl.Dock = DockStyle.Fill;
				panelMainContent.Controls.Add(pageControl);
				//依據使用者選擇的頁面，建立對應的控制項（UserControl）加入主容器 panelMainContent 中
			}
		}

		/// <summary>
		/// 登入成功後，更新狀態列並顯示主頁內容
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="user"></param>
		private void UcPageNavigator_LoginCompleted(object sender, UserModel user)
		{
			_currentUser = user;

			toolStripStatusLabelUser.Text = $"已登入，用戶：{user.Username}";

			ShowPageContent("Main");
		}

		/// <summary>
		/// 登出後，更新狀態列並返回登入畫面
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void WelcomePanel_Logout(object sender, EventArgs e)
		{
			_currentUser = null; // 清除已登入使用者

			toolStripStatusLabelUser.Text = "尚未登入";

			ShowPageContent("Main");
		}

		private void UcUserPage_UserUpdated(object sender, UserModel updatedUser)
		{
			// 更新當前使用者記錄與工具列顯示
			_currentUser = updatedUser;

			// 更新最底部狀態列的文字
			toolStripStatusLabelUser.Text = $"已登入，用戶：{updatedUser.Username}";
		}


	}
}
