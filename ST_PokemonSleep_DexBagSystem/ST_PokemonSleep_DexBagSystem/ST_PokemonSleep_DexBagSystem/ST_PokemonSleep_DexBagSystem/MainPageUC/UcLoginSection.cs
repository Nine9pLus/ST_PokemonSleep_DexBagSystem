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
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST_PokemonSleep_DexBagSystem
{
	public partial class UcLoginSection : UserControl
	{
		//定義一個事件（LoginSuccess），它會傳遞一個LoginEventArgs型別的資料。
		public event EventHandler<LoginEventArgs> LoginSuccess;

		//建立 AuthService 實例，用來進行登入驗證邏輯。
		private readonly AuthService _authService = new AuthService();

		public UcLoginSection()
		{
			InitializeComponent();
			this.Load += UcLoginSection_Load;
			this.Resize += UcLoginSection_Resize;

		}

		private void UcLoginSection_Load(object sender, EventArgs e)
		{
			// 初次置中位置
			CenterPanel();

			// 這裡可以清除游標為等待狀態的情況
			//ClearWaitCursorRecursively(this);
		}
		private void UcLoginSection_Resize(object sender, EventArgs e)
		{
			// 當視窗大小變時置中
			CenterPanel();
		}
		private bool _isCentering = false;

		/// <summary>
		/// 避免重入（用 _isCentering 旗標）並將 panelCenterContent 置中在表單中
		/// </summary>
		private void CenterPanel()
		{
			// 如果正在置中，則不再執行
			if (_isCentering) return;

			_isCentering = true;
			try
			{
				if (panelCenterContent.Width > 0 && panelCenterContent.Height > 0 &&
					Width > 0 && Height > 0)
				{
					panelCenterContent.Left = Math.Max(0, (Width - panelCenterContent.Width) / 2);
					panelCenterContent.Top = Math.Max(0, (Height - panelCenterContent.Height) / 2);
				}
			}
			finally { _isCentering = false; }
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string account = txtAccount.Text;
			string password = txtPassword.Text;

			#region 測試登入，跳過輸入，直接指定帳號與密碼
			//string account = "aaa";
			//string password = "aaa";
			#endregion
			#region 測試用 顯示輸入密碼的 SHA256 雜湊值
			//using (SHA256 sha256 = SHA256.Create())
			//{
			//	byte[] hashedPassword = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(password));
			//	string hashHex = BitConverter.ToString(hashedPassword).Replace("-", "");
			//	MessageBox.Show("SHA256 of password:\n" + hashHex);
			//}
			#endregion

			//用 AuthService 判斷帳密是否正確，並取得登入的 UserModel 物件。
			bool success = _authService.Login(account, password, out UserModel user, out string avatarFile);

			if (success) { LoginSuccess?.Invoke(this, new LoginEventArgs(user, avatarFile)); }
			else { MessageBox.Show("登入失敗，請確認帳號密碼", "登入失敗", MessageBoxButtons.OK, MessageBoxIcon.Error); }
		}


		// 自訂的事件參數類型，繼承自EventArgs，用來傳遞登入成功的使用者資訊和頭像路徑。
		public class LoginEventArgs : EventArgs     
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

		#region 測試用 停止登入頁元件一直出現轉圈圈游標
		//private void ClearWaitCursorRecursively(Control control)  
		//{
		//	control.UseWaitCursor = false;
		//	foreach (Control child in control.Controls)
		//	{
		//		ClearWaitCursorRecursively(child);
		//	}
		//}
		#endregion
	}
}
