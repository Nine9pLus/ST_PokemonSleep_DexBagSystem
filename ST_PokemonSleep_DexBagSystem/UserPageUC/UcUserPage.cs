using PokemonSleep.Models;
using PokemonSleep.Service;
using PokemonSleep.Utility;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ST_PokemonSleep_DexBagSystem.UserPageUC
{
	public partial class UcUserPage : UserControl
	{
		// 頭像區相關欄位
		private PictureBox[] avatarBoxes;
		private string[] avatarFileNames = { "image1.png", "image2.png", "image3.png", "image4.png", "image5.png" };
		private int selectedAvatarIndex = 0;
		private string selectedAvatarFile = null;

		// 使用者資訊
		private UserModel _currentUser;
		private readonly UserRepository _userRepository = new UserRepository();

		// 對外事件
		public event EventHandler<UserModel> UserUpdated;

		public UcUserPage()
		{
			InitializeComponent();
			InitAvatarPanel();
			this.Load += UcUserPage_Load;
		}

		private void UcUserPage_Load(object sender, EventArgs e)
		{
			InitAvatarPanel();
		}

		#region 功能：初始化頭像區

		private void InitAvatarPanel()
		{
			avatarBoxes = new PictureBox[] { picImage1, picImage2, picImage3, picImage4, picImage5 };

			for (int i = 0; i < avatarBoxes.Length; i++)
			{
				var pb = avatarBoxes[i];

				// 1~4 為預設頭像
				if (i < 4)
				{
					string avatarFile = avatarFileNames[i];
					string path = AssetHelper.GetAvatarPath(avatarFile);
					pb.Image = Image.FromFile(path);
					pb.Tag = avatarFile; // ex: "image1.png"
				}
				else
				{
					// 第五張是自訂上傳專用
					string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "image", "avatar", "upload_icon.png");

					// 如果還沒自訂，先用提示圖示
					if (File.Exists(path))
						pb.Image = Image.FromFile(path);
					else
						pb.BackColor = Color.LightGray; // fallback 顯示

					pb.Tag = "custom_upload";
					ToolTip tip = new ToolTip();
					tip.SetToolTip(pb, "點我上傳自訂頭像"); 
					pb.Margin = new Padding(5);
				}

				pb.SizeMode = PictureBoxSizeMode.Zoom;
				pb.BorderStyle = BorderStyle.FixedSingle;
				pb.Cursor = Cursors.Hand;

				// 避免重複註冊
				pb.Click -= Avatar_Click;
				pb.Click += Avatar_Click;
			}
		}


		private void SelectAvatar(string avatarFile)
		{
			for (int i = 0; i < avatarBoxes.Length; i++)
			{
				if ((string)avatarBoxes[i].Tag == avatarFile)
				{
					selectedAvatarIndex = i;
					selectedAvatarFile = avatarFile;
					avatarBoxes[i].BorderStyle = BorderStyle.Fixed3D;
				}
				else
				{
					avatarBoxes[i].BorderStyle = BorderStyle.FixedSingle;
				}
			}
		}

		private void Avatar_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < avatarBoxes.Length; i++)
			{
				if (sender == avatarBoxes[i])
				{
					#region 如果是第5個頭像（上傳功能）
					if (i == 4)
					{
						HandleCustomAvatarUpload();
						return; // 上傳完成 or 取消，不進入下方選取流程
					}
					#endregion

					// 1-4 正常選取
					avatarBoxes[i].BorderStyle = BorderStyle.Fixed3D;
					avatarBoxes[i].BackColor = Color.SkyBlue;
					// 更新選中狀態
					selectedAvatarIndex = i;
					selectedAvatarFile = avatarFileNames[i];
				}
				else
				{
					avatarBoxes[i].BorderStyle = BorderStyle.FixedSingle;
					avatarBoxes[i].BackColor = SystemColors.Control;
				}
			}
		}
		#endregion

		# region 自訂頭像
		private void HandleCustomAvatarUpload()
		{
			using (OpenFileDialog ofd = new OpenFileDialog())
			{
				ofd.Title = "選擇你的自訂頭像";
				ofd.Filter = "圖片檔 (*.jpg;*.png)|*.jpg;*.png";

				if (ofd.ShowDialog() == DialogResult.OK)
				{
					// ✅ 使用時間戳自訂檔名，避免撞檔
					string ext = Path.GetExtension(ofd.FileName);
					string customFileName = $"custom_{DateTime.Now:yyyyMMdd_HHmmss}{ext}";
					string destFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "image", "avatar");
					string destPath = Path.Combine(destFolder, customFileName);

					try
					{
						// ✅ 複製檔案
						File.Copy(ofd.FileName, destPath, true);

						// 顯示在 picImage5
						picImage5.Image = Image.FromFile(destPath);
						picImage5.BorderStyle = BorderStyle.Fixed3D;
						picImage5.BackColor = Color.SkyBlue;

						// 取消其他框選
						for (int i = 0; i < avatarBoxes.Length - 1; i++)
						{
							avatarBoxes[i].BorderStyle = BorderStyle.FixedSingle;
							avatarBoxes[i].BackColor = SystemColors.Control;
						}

						// ✅ 更新選取狀態
						selectedAvatarIndex = 4;
						selectedAvatarFile = customFileName;

						MessageBox.Show("頭像已上傳並選取完成！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					catch (Exception ex)
					{
						MessageBox.Show("上傳頭像失敗：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		#endregion

		#region 功能：登入後設定使用者

		public void SetLoginUser(UserModel user)
		{
			if (user == null)
			{
				ShowUnloginPanel();
				return;
			}

			ShowLoginPanel();

			_currentUser = user;

			// 更新上方「現在頭像與名稱」
			SetUserInfo(user.Username, user.AvatarFile);

			// 初始輸入欄清空
			txtNewAccount.Text = "";
			txtNewPassword.Text = "";
			txtNewUsername.Text = user.Username;
		}


		private void SetUserInfo(string username, string avatarFile)
		{
			lblUsername.Text = $"用戶名稱：{(string.IsNullOrWhiteSpace(username) ? "未登入" : username)}";


			string avatarPath = AssetHelper.GetAvatarPath(avatarFile);
			if (!string.IsNullOrEmpty(avatarPath) && File.Exists(avatarPath))
			{
				picAvatar.Image = Image.FromFile(avatarPath);
			}
			selectedAvatarFile = avatarFile;
			SelectAvatar(avatarFile);
		}

		#endregion

		#region 功能：更新資料庫（點按確認）

		private void btnConfirm_Click(object sender, EventArgs e)
		{
			string newAcc = txtNewAccount.Text.Trim();
			string newPwd = txtNewPassword.Text;
			string newName = txtNewUsername.Text.Trim();
			string avatarFile = selectedAvatarFile ?? avatarFileNames[0];

			//if (string.IsNullOrWhiteSpace(newName))
			//{
			//	MessageBox.Show("名稱不得為空", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			//	return;
			//}

			if (!string.IsNullOrWhiteSpace(newAcc) &&
				_userRepository.IsAccountDuplicate(newAcc, _currentUser.UserId))
			{
				MessageBox.Show("帳號已存在", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try
			{
				_userRepository.UpdateUser(_currentUser.UserId, newAcc, newPwd, newName, avatarFile);

				// 更新記憶與顯示
				_currentUser.Username = newName;
				_currentUser.AvatarFile = avatarFile;

				SetUserInfo(_currentUser.Username, _currentUser.AvatarFile);

				// 對外通知更新
				UserUpdated?.Invoke(this, _currentUser);

				MessageBox.Show("更新成功！", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show("資料更新失敗：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		#endregion

		#region 功能：清除輸入 / Panel 顯示切換

		private void btnClear_Click(object sender, EventArgs e) => ClearAllInputs();

		private void ClearAllInputs()
		{
			txtNewAccount.Text = "";
			txtNewPassword.Text = "";
			txtNewUsername.Text = "";

			ClearAvatarSelection();
		}

		private void ClearAvatarSelection() //重設
		{
			foreach (var pb in avatarBoxes)
			{
				pb.BorderStyle = BorderStyle.FixedSingle;
				pb.BackColor = SystemColors.Control;
			}

			selectedAvatarIndex = -1;
			selectedAvatarFile = null;
		}

		private void ShowUnloginPanel()
		{
			tableLayoutPanelUserHint.Visible = true;

		}

		private void ShowLoginPanel()
		{
			tableLayoutPanelUserHint.Visible = false;
		}

		#endregion
	}
}
