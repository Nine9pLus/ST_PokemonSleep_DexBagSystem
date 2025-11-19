namespace ST_PokemonSleep_DexBagSystem
{
	partial class UcLoginSection
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
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.labUsername = new System.Windows.Forms.Label();
			this.btnLogin = new System.Windows.Forms.Button();
			this.lblPassword = new System.Windows.Forms.Label();
			this.btnRegister = new System.Windows.Forms.Button();
			this.txtAccount = new System.Windows.Forms.TextBox();
			this.lblLogin = new System.Windows.Forms.Label();
			this.panelCenterContent = new System.Windows.Forms.Panel();
			this.tableLayoutPanelBottom = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanelTop = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanelCenter = new System.Windows.Forms.TableLayoutPanel();
			this.panelCenterContent.SuspendLayout();
			this.tableLayoutPanelBottom.SuspendLayout();
			this.tableLayoutPanelTop.SuspendLayout();
			this.tableLayoutPanelCenter.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtPassword
			// 
			this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtPassword.Location = new System.Drawing.Point(375, 16);
			this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(123, 25);
			this.txtPassword.TabIndex = 2;
			// 
			// labUsername
			// 
			this.labUsername.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.labUsername.AutoSize = true;
			this.labUsername.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labUsername.Location = new System.Drawing.Point(83, 19);
			this.labUsername.Name = "labUsername";
			this.labUsername.Size = new System.Drawing.Size(57, 20);
			this.labUsername.TabIndex = 1;
			this.labUsername.Text = "帳號：";
			this.labUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnLogin
			// 
			this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnLogin.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnLogin.Location = new System.Drawing.Point(167, 12);
			this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(100, 31);
			this.btnLogin.TabIndex = 0;
			this.btnLogin.Text = "登入";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// lblPassword
			// 
			this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.lblPassword.AutoSize = true;
			this.lblPassword.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblPassword.Location = new System.Drawing.Point(312, 19);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(57, 20);
			this.lblPassword.TabIndex = 1;
			this.lblPassword.Text = "密碼：";
			this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnRegister
			// 
			this.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnRegister.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnRegister.Location = new System.Drawing.Point(312, 12);
			this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.Size = new System.Drawing.Size(100, 31);
			this.btnRegister.TabIndex = 0;
			this.btnRegister.Text = "註冊";
			this.btnRegister.UseVisualStyleBackColor = true;
			this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
			// 
			// txtAccount
			// 
			this.txtAccount.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtAccount.Location = new System.Drawing.Point(146, 16);
			this.txtAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtAccount.Name = "txtAccount";
			this.txtAccount.Size = new System.Drawing.Size(123, 25);
			this.txtAccount.TabIndex = 2;
			// 
			// lblLogin
			// 
			this.lblLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblLogin.AutoSize = true;
			this.lblLogin.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblLogin.Location = new System.Drawing.Point(247, 30);
			this.lblLogin.Name = "lblLogin";
			this.lblLogin.Size = new System.Drawing.Size(86, 24);
			this.lblLogin.TabIndex = 3;
			this.lblLogin.Text = "會員登入";
			// 
			// panelCenterContent
			// 
			this.panelCenterContent.Controls.Add(this.tableLayoutPanelTop);
			this.panelCenterContent.Controls.Add(this.tableLayoutPanelCenter);
			this.panelCenterContent.Controls.Add(this.tableLayoutPanelBottom);
			this.panelCenterContent.Location = new System.Drawing.Point(0, 0);
			this.panelCenterContent.Name = "panelCenterContent";
			this.panelCenterContent.Size = new System.Drawing.Size(580, 211);
			this.panelCenterContent.TabIndex = 4;
			// 
			// tableLayoutPanelBottom
			// 
			this.tableLayoutPanelBottom.ColumnCount = 4;
			this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanelBottom.Controls.Add(this.btnRegister, 2, 0);
			this.tableLayoutPanelBottom.Controls.Add(this.btnLogin, 1, 0);
			this.tableLayoutPanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tableLayoutPanelBottom.Location = new System.Drawing.Point(0, 155);
			this.tableLayoutPanelBottom.Name = "tableLayoutPanelBottom";
			this.tableLayoutPanelBottom.RowCount = 1;
			this.tableLayoutPanelBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelBottom.Size = new System.Drawing.Size(580, 56);
			this.tableLayoutPanelBottom.TabIndex = 2;
			// 
			// tableLayoutPanelTop
			// 
			this.tableLayoutPanelTop.ColumnCount = 1;
			this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelTop.Controls.Add(this.lblLogin, 0, 0);
			this.tableLayoutPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanelTop.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanelTop.Name = "tableLayoutPanelTop";
			this.tableLayoutPanelTop.RowCount = 1;
			this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelTop.Size = new System.Drawing.Size(580, 85);
			this.tableLayoutPanelTop.TabIndex = 1;
			// 
			// tableLayoutPanelCenter
			// 
			this.tableLayoutPanelCenter.AutoSize = true;
			this.tableLayoutPanelCenter.ColumnCount = 6;
			this.tableLayoutPanelCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanelCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.tableLayoutPanelCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanelCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.tableLayoutPanelCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanelCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanelCenter.Controls.Add(this.txtPassword, 4, 0);
			this.tableLayoutPanelCenter.Controls.Add(this.lblPassword, 3, 0);
			this.tableLayoutPanelCenter.Controls.Add(this.txtAccount, 2, 0);
			this.tableLayoutPanelCenter.Controls.Add(this.labUsername, 1, 0);
			this.tableLayoutPanelCenter.Location = new System.Drawing.Point(3, 91);
			this.tableLayoutPanelCenter.Name = "tableLayoutPanelCenter";
			this.tableLayoutPanelCenter.RowCount = 1;
			this.tableLayoutPanelCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelCenter.Size = new System.Drawing.Size(574, 58);
			this.tableLayoutPanelCenter.TabIndex = 0;
			// 
			// UcLoginSection
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panelCenterContent);
			this.Name = "UcLoginSection";
			this.Size = new System.Drawing.Size(580, 245);
			this.Load += new System.EventHandler(this.UcLoginSection_Load);
			this.panelCenterContent.ResumeLayout(false);
			this.panelCenterContent.PerformLayout();
			this.tableLayoutPanelBottom.ResumeLayout(false);
			this.tableLayoutPanelTop.ResumeLayout(false);
			this.tableLayoutPanelTop.PerformLayout();
			this.tableLayoutPanelCenter.ResumeLayout(false);
			this.tableLayoutPanelCenter.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label labUsername;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.Button btnRegister;
		private System.Windows.Forms.TextBox txtAccount;
		private System.Windows.Forms.Label lblLogin;
		private System.Windows.Forms.Panel panelCenterContent;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTop;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCenter;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBottom;
	}
}
