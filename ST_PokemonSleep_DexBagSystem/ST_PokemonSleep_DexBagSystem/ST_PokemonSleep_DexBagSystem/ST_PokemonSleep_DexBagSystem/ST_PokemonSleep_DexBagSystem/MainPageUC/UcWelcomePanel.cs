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

		public void SetUserInfo(string username, string avatarFile)
		{
			lblUsername.Text = $"歡迎登入，{username}";

			if (File.Exists(avatarFile))
			{
				picAvatar.Image = Image.FromFile(avatarFile);
			}
			else
			{
				picAvatar.Image = Image.FromFile(@"\image\Avatar\Image1.png");
				//picAvatar.Image = null;
			}
		}

	}
}
