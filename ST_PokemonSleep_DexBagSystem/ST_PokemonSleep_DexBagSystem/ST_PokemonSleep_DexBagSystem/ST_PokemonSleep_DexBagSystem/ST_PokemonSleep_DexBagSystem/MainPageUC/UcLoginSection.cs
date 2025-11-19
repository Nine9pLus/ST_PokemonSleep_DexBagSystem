using PokemonSleep.Models;
using PokemonSleep.SecurtyInterface;
using PokemonSleep.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST_PokemonSleep_DexBagSystem
{
	public partial class UcLoginSection : UserControl
	{
		public event EventHandler<LoginEventArgs> LoginSuccess;			//定義一個事件（LoginSuccess），它會傳遞一個LoginEventArgs型別的資料。
		private readonly AuthService _authService = new AuthService();  //建立 AuthService 實例，用來進行登入驗證邏輯。

		public UcLoginSection()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string account = txtAccount.Text;
			string password = txtPassword.Text;

			bool success = _authService.Login(account, password, out UserModel user, out string avatarFile);
			//用 AuthService 判斷帳密是否正確，並取得登入的 UserModel 物件。

			if (success)
			{
				LoginSuccess?.Invoke(this, new LoginEventArgs(user, avatarFile));
				//如果登入成功，觸發 LoginSuccess 事件，並傳遞user和頭像路徑。UcMainPage（主頁監聽這事）
			}
			else
			{
				MessageBox.Show("登入失敗，請確認帳號密碼", "登入失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public class LoginEventArgs : EventArgs     // 自訂的事件參數類型，繼承自EventArgs，用來傳遞登入成功的使用者資訊和頭像路徑。
		{
			public UserModel User { get; }
			public string AvatarFile { get; }

			public LoginEventArgs(UserModel user, string avatarFile)
			{
				User = user;
				AvatarFile = avatarFile;
			}
		}

		private void btnRegister_Click(object sender, EventArgs e)
		{
			var registerForm = new RegisterForm();  // 註冊表單
			registerForm.ShowDialog();              // 視窗顯示
		}

		private void UcLoginSection_Load(object sender, EventArgs e)
		{
			// 每次 load 或 resize 都置中 panel
			CenterPanel();
		}
		private void CenterPanel()
		{
			var parentWidth = this.Width;
			var parentHeight = this.Height;

			// 自定放置 Panel 置中
			panelCenterContent.Left = (parentWidth - panelCenterContent.Width) / 2;
			panelCenterContent.Top = (parentHeight - panelCenterContent.Height) / 2;
		}

	}
}
