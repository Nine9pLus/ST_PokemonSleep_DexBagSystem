using PokemonSleep.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ST_PokemonSleep_DexBagSystem.MainPageUserControl
{
	public partial class UcWelcomePanel : UserControl
	{
		public UcWelcomePanel()
		{
			InitializeComponent();
		}

		/// <summary>
		/// 取得或設定使用者資訊，包括會員名稱與頭像。
		/// </summary>
		/// <param name="username"></param>
		/// <param name="avatarFile"></param>
		public void SetUserInfo(string username, string avatarFile)
		{
			lblUsername.Text = username;

			string avatarPath = AssetHelper.GetAvatarPath(avatarFile);

			// 如果找不到傳入圖、也找不到預設圖，就設 null
			if (!string.IsNullOrEmpty(avatarPath) && File.Exists(avatarPath))
			{
				using (var img = Image.FromFile(avatarPath))
				{
					picAvatar.Image = new Bitmap(img);	// 避免鎖檔
				}
			}
			else { picAvatar.Image = null; }
		}

		public event EventHandler Logout;

		private bool isLoggingOut = false;

		private void btnLogout_Click(object sender, EventArgs e)
		{
			if (isLoggingOut) return;

			var result = MessageBox.Show("確定要登出？", "登出", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result != DialogResult.Yes) return;

			isLoggingOut = true;
			Logout?.Invoke(this, EventArgs.Empty);
		}
	}
}
