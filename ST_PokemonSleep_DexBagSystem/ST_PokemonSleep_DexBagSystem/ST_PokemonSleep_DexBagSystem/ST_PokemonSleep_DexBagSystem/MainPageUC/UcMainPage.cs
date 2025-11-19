using PokemonSleep.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ST_PokemonSleep_DexBagSystem.UcLoginSection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ST_PokemonSleep_DexBagSystem.MainPageUserControl
{
	public partial class UcMainPage : UserControl
	{
		public event EventHandler<UserModel> LoginCompleted;

		private UcLoginSection _loginSection;
		private UcWelcomePanel _welcomePanel;

		public UcMainPage()
		{
			InitializeComponent();
			LoadLoginSection();
		}

		private void LoadLoginSection()
		{
			// 清空 groupBoxContent 中的內容
			groupBoxContent.Controls.Clear();

			// 建立並加入 Login 控制項
			_loginSection = new UcLoginSection();
			_loginSection.Dock = DockStyle.Fill;
			_loginSection.LoginSuccess += OnLoginSuccess;

			// 加入 Login 控制項到 groupBoxContent
			groupBoxContent.Controls.Add(_loginSection);
		}

		private void OnLoginSuccess(object sender, LoginEventArgs e)
		{
			// 取得登入資訊
			UserModel user = e.User;
			string avatarFile = e.AvatarFile;

			// 清掉登入控制項
			groupBoxContent.Controls.Clear();

			// 建立 Welcome 控制項
			_welcomePanel = new UcWelcomePanel();
			_welcomePanel.Dock = DockStyle.Fill;
			_welcomePanel.SetUserInfo(user.Username, avatarFile);

			// 加入 Welcome 控制項到 groupBoxContent
			groupBoxContent.Controls.Add(_welcomePanel);

			// 通知 Form1 做狀態欄更新
			// 登入成功，UcMainPage 呼叫 UcPageNavigator_LoginCompleted 事件
			LoginCompleted?.Invoke(this, user);
		}

		private void LoadWelcomePanel()
		{
			var welcomePanel = new UcWelcomePanel();
			welcomePanel.Logout += WelcomePanel_Logout;
			// todo: ... 其他 UI 設定
			groupBoxContent.Controls.Add(welcomePanel);
		}

		private void WelcomePanel_Logout(object sender, EventArgs e)
		{
			// 回到登入區塊
			LoadLoginSection();
			// 清狀態列
			if (FindForm() is Form1 f)
				f.toolStripStatusLabelUser.Text = "尚未登入";
		}

	}
}
