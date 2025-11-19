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
			this.panelCenterContent = new System.Windows.Forms.Panel();
			this.tableLayoutPanelTop = new System.Windows.Forms.TableLayoutPanel();
			this.label2 = new System.Windows.Forms.Label();
			this.tableLayoutPanelBottom = new System.Windows.Forms.TableLayoutPanel();
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnRegister = new System.Windows.Forms.Button();
			this.tableLayoutPanelCenter = new System.Windows.Forms.TableLayoutPanel();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.lblPassword = new System.Windows.Forms.Label();
			this.lblAccount = new System.Windows.Forms.Label();
			this.txtAccount = new System.Windows.Forms.TextBox();
			this.panelCenterContent.SuspendLayout();
			this.tableLayoutPanelTop.SuspendLayout();
			this.tableLayoutPanelBottom.SuspendLayout();
			this.tableLayoutPanelCenter.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelCenterContent
			// 
			this.panelCenterContent.Controls.Add(this.tableLayoutPanelTop);
			this.panelCenterContent.Controls.Add(this.tableLayoutPanelBottom);
			this.panelCenterContent.Controls.Add(this.tableLayoutPanelCenter);
			this.panelCenterContent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelCenterContent.Location = new System.Drawing.Point(0, 0);
			this.panelCenterContent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panelCenterContent.Name = "panelCenterContent";
			this.panelCenterContent.Size = new System.Drawing.Size(422, 249);
			this.panelCenterContent.TabIndex = 4;
			// 
			// tableLayoutPanelTop
			// 
			this.tableLayoutPanelTop.ColumnCount = 1;
			this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelTop.Controls.Add(this.label2, 0, 0);
			this.tableLayoutPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanelTop.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanelTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tableLayoutPanelTop.Name = "tableLayoutPanelTop";
			this.tableLayoutPanelTop.RowCount = 1;
			this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelTop.Size = new System.Drawing.Size(422, 53);
			this.tableLayoutPanelTop.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(168, 14);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 24);
			this.label2.TabIndex = 3;
			this.label2.Text = "會員登入";
			// 
			// tableLayoutPanelBottom
			// 
			this.tableLayoutPanelBottom.ColumnCount = 4;
			this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanelBottom.Controls.Add(this.btnLogin, 1, 0);
			this.tableLayoutPanelBottom.Controls.Add(this.btnRegister, 2, 0);
			this.tableLayoutPanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tableLayoutPanelBottom.Location = new System.Drawing.Point(0, 198);
			this.tableLayoutPanelBottom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tableLayoutPanelBottom.Name = "tableLayoutPanelBottom";
			this.tableLayoutPanelBottom.RowCount = 1;
			this.tableLayoutPanelBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelBottom.Size = new System.Drawing.Size(422, 51);
			this.tableLayoutPanelBottom.TabIndex = 5;
			// 
			// btnLogin
			// 
			this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLogin.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnLogin.Location = new System.Drawing.Point(153, 4);
			this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(53, 25);
			this.btnLogin.TabIndex = 0;
			this.btnLogin.Text = "登入";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// btnRegister
			// 
			this.btnRegister.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnRegister.Location = new System.Drawing.Point(214, 4);
			this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.Size = new System.Drawing.Size(53, 25);
			this.btnRegister.TabIndex = 0;
			this.btnRegister.Text = "註冊";
			this.btnRegister.UseVisualStyleBackColor = true;
			this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
			// 
			// tableLayoutPanelCenter
			// 
			this.tableLayoutPanelCenter.ColumnCount = 6;
			this.tableLayoutPanelCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanelCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
			this.tableLayoutPanelCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
			this.tableLayoutPanelCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
			this.tableLayoutPanelCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
			this.tableLayoutPanelCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanelCenter.Controls.Add(this.txtPassword, 4, 0);
			this.tableLayoutPanelCenter.Controls.Add(this.lblPassword, 3, 0);
			this.tableLayoutPanelCenter.Controls.Add(this.lblAccount, 1, 0);
			this.tableLayoutPanelCenter.Controls.Add(this.txtAccount, 2, 0);
			this.tableLayoutPanelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelCenter.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanelCenter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tableLayoutPanelCenter.Name = "tableLayoutPanelCenter";
			this.tableLayoutPanelCenter.RowCount = 1;
			this.tableLayoutPanelCenter.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelCenter.Size = new System.Drawing.Size(422, 249);
			this.tableLayoutPanelCenter.TabIndex = 3;
			// 
			// txtPassword
			// 
			this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtPassword.Location = new System.Drawing.Point(279, 113);
			this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtPassword.MaxLength = 8;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(79, 22);
			this.txtPassword.TabIndex = 2;
			this.txtPassword.UseSystemPasswordChar = true;
			// 
			// lblPassword
			// 
			this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.lblPassword.AutoSize = true;
			this.lblPassword.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblPassword.Location = new System.Drawing.Point(221, 115);
			this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(54, 19);
			this.lblPassword.TabIndex = 1;
			this.lblPassword.Text = "密碼：";
			this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblAccount
			// 
			this.lblAccount.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.lblAccount.AutoSize = true;
			this.lblAccount.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblAccount.Location = new System.Drawing.Point(53, 115);
			this.lblAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblAccount.Name = "lblAccount";
			this.lblAccount.Size = new System.Drawing.Size(54, 19);
			this.lblAccount.TabIndex = 1;
			this.lblAccount.Text = "帳號：";
			this.lblAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtAccount
			// 
			this.txtAccount.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtAccount.Location = new System.Drawing.Point(111, 113);
			this.txtAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtAccount.MaxLength = 8;
			this.txtAccount.Name = "txtAccount";
			this.txtAccount.Size = new System.Drawing.Size(79, 22);
			this.txtAccount.TabIndex = 2;
			// 
			// UcLoginSection
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panelCenterContent);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "UcLoginSection";
			this.Size = new System.Drawing.Size(422, 249);
			this.Load += new System.EventHandler(this.UcLoginSection_Load);
			this.panelCenterContent.ResumeLayout(false);
			this.tableLayoutPanelTop.ResumeLayout(false);
			this.tableLayoutPanelTop.PerformLayout();
			this.tableLayoutPanelBottom.ResumeLayout(false);
			this.tableLayoutPanelCenter.ResumeLayout(false);
			this.tableLayoutPanelCenter.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelCenterContent;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTop;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCenter;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.Label lblAccount;
		private System.Windows.Forms.TextBox txtAccount;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBottom;
		private System.Windows.Forms.Button btnRegister;
		private System.Windows.Forms.Button btnLogin;
	}
}
