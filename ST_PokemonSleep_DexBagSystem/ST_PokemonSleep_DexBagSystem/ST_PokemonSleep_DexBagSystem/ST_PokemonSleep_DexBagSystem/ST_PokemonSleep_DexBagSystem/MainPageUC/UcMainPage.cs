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

			// 初始只顯示登入畫面
			panelLogin.Visible = true;
			panelWelcome.Visible = false;
		}

		private void LoadLoginSection()
		{
			_loginSection = new UcLoginSection();
			_loginSection.Dock = DockStyle.Fill;
			_loginSection.LoginSuccess += OnLoginSuccess;

			panelLogin.Controls.Clear();
			panelLogin.Controls.Add(_loginSection);
		}

		private void OnLoginSuccess(object sender, LoginEventArgs e)
		{
			// 取得登入資訊
			UserModel user = e.User;
			string avatarFile = e.AvatarFile;

			// 切換畫面
			panelLogin.Visible = false;
			panelWelcome.Visible = true;

			// 載入歡迎畫面
			_welcomePanel = new UcWelcomePanel();
			_welcomePanel.Dock = DockStyle.Fill;
			_welcomePanel.SetUserInfo(user.Username, avatarFile);

			panelWelcome.Controls.Clear();
			panelWelcome.Controls.Add(_welcomePanel);

			// 通知主表單更新狀態欄
			LoginCompleted?.Invoke(this, user);
		}
	}
}
