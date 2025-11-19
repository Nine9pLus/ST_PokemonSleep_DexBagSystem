using PokemonSleep.Models;
using PokemonSleep.SecurtyInterface;
using PokemonSleep.Service;
using PokemonSleep.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST_PokemonSleep_DexBagSystem
{
	public partial class RegisterForm : Form
	{
		public RegisterForm()
		{
			InitializeComponent();
		}

		private void btnRegister_Click(object sender, EventArgs e)
		{
			string account = txtRegisterAccount.Text.Trim();
			string password = txtRegisterPassword.Text.Trim();
			string username = txtRegisterUsername.Text.Trim();

			//string avatarFile = @"\image\Avatar\Image1.png";
			string avatarFile = AssetHelper.GetDefaultAvatarFileName();

			if (string.IsNullOrEmpty(account) || string.IsNullOrEmpty(password))
			{ MessageBox.Show("請輸入帳號、密碼與暱稱"); return; }


			IUserRepository repo = new UserRepository();

			// 檢查帳號是否重複
			var existingUser = repo.GetUserByCredentials(account);
			if (existingUser != null)
			{ MessageBox.Show("此用戶已存在，請更換帳號或進行登入"); return; }

			if (string.IsNullOrEmpty(username)) username = "訓練家";

			// 建立新使用者資料
			UserModel user = new UserModel
			{
				Account = account,
				PasswordHash = HashPassword(password),
				AvatarFile = avatarFile,
				Username = username
			};

			// 執行註冊（資料庫新增）
			repo.AddUser(user);

			MessageBox.Show(@"註冊成功，請重新登入系統。", "註冊完成", MessageBoxButtons.OK, MessageBoxIcon.Information);

			// 註冊完自動關閉視窗		
			this.Close();
		}

		private void btnCancelRegister_Click(object sender, EventArgs e)
		{
			this.Close(); // 關閉註冊視窗
		}

		private byte[] HashPassword(string password)
		{
			using (var sha256 = SHA256.Create())
			{
				return sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
			}
		}

	}
}
