namespace ST_PokemonSleep_DexBagSystem.MainPageUserControl
{
	partial class UcWelcomePanel
	{
		/// <summary> 
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region 元件設計工具產生的程式碼

		/// <summary> 
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.btnLogout = new System.Windows.Forms.Button();
			this.lblUsername = new System.Windows.Forms.Label();
			this.picAvatar = new System.Windows.Forms.PictureBox();
			this.lblWelcome = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
			this.SuspendLayout();
			// 
			// btnLogout
			// 
			this.btnLogout.Location = new System.Drawing.Point(244, 84);
			this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(109, 29);
			this.btnLogout.TabIndex = 3;
			this.btnLogout.Text = "登出";
			this.btnLogout.UseVisualStyleBackColor = true;
			// 
			// lblUsername
			// 
			this.lblUsername.Location = new System.Drawing.Point(207, 52);
			this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(185, 29);
			this.lblUsername.TabIndex = 4;
			this.lblUsername.Text = "預設:訓練家";
			this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// picAvatar
			// 
			this.picAvatar.Image = global::ST_PokemonSleep_DexBagSystem.Properties.Resources.Image1;
			this.picAvatar.Location = new System.Drawing.Point(132, 32);
			this.picAvatar.Margin = new System.Windows.Forms.Padding(4);
			this.picAvatar.Name = "picAvatar";
			this.picAvatar.Size = new System.Drawing.Size(67, 62);
			this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picAvatar.TabIndex = 1;
			this.picAvatar.TabStop = false;
			// 
			// lblWelcome
			// 
			this.lblWelcome.Location = new System.Drawing.Point(207, 17);
			this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblWelcome.Name = "lblWelcome";
			this.lblWelcome.Size = new System.Drawing.Size(185, 35);
			this.lblWelcome.TabIndex = 0;
			this.lblWelcome.Text = "成功登入，歡迎！";
			this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// UcWelcomePanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnLogout);
			this.Controls.Add(this.lblUsername);
			this.Controls.Add(this.picAvatar);
			this.Controls.Add(this.lblWelcome);
			this.Name = "UcWelcomePanel";
			this.Size = new System.Drawing.Size(556, 156);
			((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnLogout;
		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.PictureBox picAvatar;
		private System.Windows.Forms.Label lblWelcome;
	}
}
