namespace ST_PokemonSleep_DexBagSystem
{
	partial class RegisterForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtRegisterPassword = new System.Windows.Forms.TextBox();
			this.labUsername = new System.Windows.Forms.Label();
			this.btnCancelRegister = new System.Windows.Forms.Button();
			this.lblPassword = new System.Windows.Forms.Label();
			this.btnSubmitRegister = new System.Windows.Forms.Button();
			this.txtRegisterAccount = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtConfirmPassword = new System.Windows.Forms.TextBox();
			this.lblRegister = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtRegisterPassword
			// 
			this.txtRegisterPassword.Location = new System.Drawing.Point(191, 89);
			this.txtRegisterPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtRegisterPassword.MaxLength = 8;
			this.txtRegisterPassword.Name = "txtRegisterPassword";
			this.txtRegisterPassword.PasswordChar = '*';
			this.txtRegisterPassword.Size = new System.Drawing.Size(132, 25);
			this.txtRegisterPassword.TabIndex = 7;
			// 
			// labUsername
			// 
			this.labUsername.AutoSize = true;
			this.labUsername.Location = new System.Drawing.Point(22, 61);
			this.labUsername.Name = "labUsername";
			this.labUsername.Size = new System.Drawing.Size(156, 15);
			this.labUsername.TabIndex = 5;
			this.labUsername.Text = "帳號 (最多 8 個字元)：";
			// 
			// btnCancelRegister
			// 
			this.btnCancelRegister.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnCancelRegister.Location = new System.Drawing.Point(190, 168);
			this.btnCancelRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCancelRegister.Name = "btnCancelRegister";
			this.btnCancelRegister.Size = new System.Drawing.Size(100, 31);
			this.btnCancelRegister.TabIndex = 3;
			this.btnCancelRegister.Text = "取消註冊";
			this.btnCancelRegister.UseVisualStyleBackColor = true;
			this.btnCancelRegister.Click += new System.EventHandler(this.btnCancelRegister_Click);
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Location = new System.Drawing.Point(22, 95);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(156, 15);
			this.lblPassword.TabIndex = 6;
			this.lblPassword.Text = "密碼 (最多 8 個字元)：";
			// 
			// btnSubmitRegister
			// 
			this.btnSubmitRegister.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnSubmitRegister.Location = new System.Drawing.Point(65, 168);
			this.btnSubmitRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSubmitRegister.Name = "btnSubmitRegister";
			this.btnSubmitRegister.Size = new System.Drawing.Size(100, 31);
			this.btnSubmitRegister.TabIndex = 4;
			this.btnSubmitRegister.Text = "確認註冊";
			this.btnSubmitRegister.UseVisualStyleBackColor = true;
			this.btnSubmitRegister.Click += new System.EventHandler(this.btnRegister_Click);
			// 
			// txtRegisterAccount
			// 
			this.txtRegisterAccount.Location = new System.Drawing.Point(191, 56);
			this.txtRegisterAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtRegisterAccount.MaxLength = 8;
			this.txtRegisterAccount.Name = "txtRegisterAccount";
			this.txtRegisterAccount.Size = new System.Drawing.Size(132, 25);
			this.txtRegisterAccount.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(57, 129);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 15);
			this.label1.TabIndex = 6;
			this.label1.Text = "確認密碼：";
			// 
			// txtConfirmPassword
			// 
			this.txtConfirmPassword.Location = new System.Drawing.Point(191, 121);
			this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtConfirmPassword.MaxLength = 8;
			this.txtConfirmPassword.Name = "txtConfirmPassword";
			this.txtConfirmPassword.PasswordChar = '*';
			this.txtConfirmPassword.Size = new System.Drawing.Size(132, 25);
			this.txtConfirmPassword.TabIndex = 7;
			// 
			// lblRegister
			// 
			this.lblRegister.AutoSize = true;
			this.lblRegister.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblRegister.Location = new System.Drawing.Point(121, 18);
			this.lblRegister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblRegister.Name = "lblRegister";
			this.lblRegister.Size = new System.Drawing.Size(109, 19);
			this.lblRegister.TabIndex = 9;
			this.lblRegister.Text = "註冊新帳戶";
			// 
			// RegisterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(357, 229);
			this.Controls.Add(this.lblRegister);
			this.Controls.Add(this.txtConfirmPassword);
			this.Controls.Add(this.txtRegisterPassword);
			this.Controls.Add(this.labUsername);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCancelRegister);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.btnSubmitRegister);
			this.Controls.Add(this.txtRegisterAccount);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "RegisterForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "註冊ing";
			this.Load += new System.EventHandler(this.RegisterForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtRegisterPassword;
		private System.Windows.Forms.Label labUsername;
		private System.Windows.Forms.Button btnCancelRegister;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.Button btnSubmitRegister;
		private System.Windows.Forms.TextBox txtRegisterAccount;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtConfirmPassword;
		private System.Windows.Forms.Label lblRegister;
	}
}