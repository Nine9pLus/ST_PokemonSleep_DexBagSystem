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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcWelcomePanel));
			this.lblUsername = new System.Windows.Forms.Label();
			this.picAvatar = new System.Windows.Forms.PictureBox();
			this.lblWelcome = new System.Windows.Forms.Label();
			this.tableLayoutPanelInfoZone = new System.Windows.Forms.TableLayoutPanel();
			this.btnLogout = new System.Windows.Forms.Button();
			this.tableLayoutPanelWelcomeMain = new System.Windows.Forms.TableLayoutPanel();
			((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
			this.tableLayoutPanelInfoZone.SuspendLayout();
			this.tableLayoutPanelWelcomeMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblUsername
			// 
			this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblUsername.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblUsername.Location = new System.Drawing.Point(28, 111);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Padding = new System.Windows.Forms.Padding(10);
			this.lblUsername.Size = new System.Drawing.Size(130, 35);
			this.lblUsername.TabIndex = 4;
			this.lblUsername.Text = "預設:訓練家";
			this.lblUsername.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// picAvatar
			// 
			this.picAvatar.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.picAvatar.Image = ((System.Drawing.Image)(resources.GetObject("picAvatar.Image")));
			this.picAvatar.Location = new System.Drawing.Point(64, 79);
			this.picAvatar.Name = "picAvatar";
			this.picAvatar.Size = new System.Drawing.Size(105, 91);
			this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picAvatar.TabIndex = 1;
			this.picAvatar.TabStop = false;
			// 
			// lblWelcome
			// 
			this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.lblWelcome.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblWelcome.Location = new System.Drawing.Point(3, 66);
			this.lblWelcome.Name = "lblWelcome";
			this.lblWelcome.Padding = new System.Windows.Forms.Padding(2);
			this.lblWelcome.Size = new System.Drawing.Size(180, 42);
			this.lblWelcome.TabIndex = 0;
			this.lblWelcome.Text = "成功登入，歡迎！";
			this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// tableLayoutPanelInfoZone
			// 
			this.tableLayoutPanelInfoZone.ColumnCount = 2;
			this.tableLayoutPanelInfoZone.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
			this.tableLayoutPanelInfoZone.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanelInfoZone.Controls.Add(this.lblWelcome, 0, 0);
			this.tableLayoutPanelInfoZone.Controls.Add(this.btnLogout, 0, 2);
			this.tableLayoutPanelInfoZone.Controls.Add(this.lblUsername, 0, 1);
			this.tableLayoutPanelInfoZone.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelInfoZone.Location = new System.Drawing.Point(175, 13);
			this.tableLayoutPanelInfoZone.Name = "tableLayoutPanelInfoZone";
			this.tableLayoutPanelInfoZone.RowCount = 3;
			this.tableLayoutPanelInfoZone.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.58335F));
			this.tableLayoutPanelInfoZone.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.83408F));
			this.tableLayoutPanelInfoZone.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.73543F));
			this.tableLayoutPanelInfoZone.Size = new System.Drawing.Size(234, 223);
			this.tableLayoutPanelInfoZone.TabIndex = 5;
			// 
			// btnLogout
			// 
			this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnLogout.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnLogout.Location = new System.Drawing.Point(58, 152);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(70, 31);
			this.btnLogout.TabIndex = 4;
			this.btnLogout.Text = "登出";
			this.btnLogout.UseVisualStyleBackColor = true;
			this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
			// 
			// tableLayoutPanelWelcomeMain
			// 
			this.tableLayoutPanelWelcomeMain.ColumnCount = 2;
			this.tableLayoutPanelWelcomeMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.29851F));
			this.tableLayoutPanelWelcomeMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.70149F));
			this.tableLayoutPanelWelcomeMain.Controls.Add(this.picAvatar, 0, 0);
			this.tableLayoutPanelWelcomeMain.Controls.Add(this.tableLayoutPanelInfoZone, 1, 0);
			this.tableLayoutPanelWelcomeMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelWelcomeMain.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
			this.tableLayoutPanelWelcomeMain.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanelWelcomeMain.Name = "tableLayoutPanelWelcomeMain";
			this.tableLayoutPanelWelcomeMain.Padding = new System.Windows.Forms.Padding(10);
			this.tableLayoutPanelWelcomeMain.RowCount = 1;
			this.tableLayoutPanelWelcomeMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelWelcomeMain.Size = new System.Drawing.Size(422, 249);
			this.tableLayoutPanelWelcomeMain.TabIndex = 6;
			// 
			// UcWelcomePanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanelWelcomeMain);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "UcWelcomePanel";
			this.Size = new System.Drawing.Size(422, 249);
			((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
			this.tableLayoutPanelInfoZone.ResumeLayout(false);
			this.tableLayoutPanelWelcomeMain.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.PictureBox picAvatar;
		private System.Windows.Forms.Label lblWelcome;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInfoZone;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelWelcomeMain;
		private System.Windows.Forms.Button btnLogout;
	}
}
