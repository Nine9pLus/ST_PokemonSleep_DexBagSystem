namespace ST_PokemonSleep_DexBagSystem.MainPageUserControl
{
	partial class UcMainPage
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
			this.panelTitle = new System.Windows.Forms.Panel();
			this.lblTitle = new System.Windows.Forms.Label();
			this.panelLogin = new System.Windows.Forms.Panel();
			this.panelWelcome = new System.Windows.Forms.Panel();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.panelTitle.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelTitle
			// 
			this.panelTitle.AutoSize = true;
			this.panelTitle.Controls.Add(this.lblTitle);
			this.panelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelTitle.Location = new System.Drawing.Point(0, 0);
			this.panelTitle.Margin = new System.Windows.Forms.Padding(4);
			this.panelTitle.Name = "panelTitle";
			this.panelTitle.Size = new System.Drawing.Size(600, 140);
			this.panelTitle.TabIndex = 8;
			// 
			// lblTitle
			// 
			this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblTitle.Location = new System.Drawing.Point(199, 54);
			this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(208, 30);
			this.lblTitle.TabIndex = 7;
			this.lblTitle.Text = "寶可夢圖鑑&&背包 ";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panelLogin
			// 
			this.panelLogin.AutoSize = true;
			this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelLogin.Location = new System.Drawing.Point(0, 0);
			this.panelLogin.Margin = new System.Windows.Forms.Padding(4);
			this.panelLogin.Name = "panelLogin";
			this.panelLogin.Size = new System.Drawing.Size(600, 213);
			this.panelLogin.TabIndex = 9;
			this.panelLogin.Visible = false;
			// 
			// panelWelcome
			// 
			this.panelWelcome.AutoSize = true;
			this.panelWelcome.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelWelcome.Location = new System.Drawing.Point(0, 0);
			this.panelWelcome.Margin = new System.Windows.Forms.Padding(4);
			this.panelWelcome.Name = "panelWelcome";
			this.panelWelcome.Size = new System.Drawing.Size(600, 213);
			this.panelWelcome.TabIndex = 10;
			this.panelWelcome.Visible = false;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.panelTitle);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.panelWelcome);
			this.splitContainer1.Panel2.Controls.Add(this.panelLogin);
			this.splitContainer1.Size = new System.Drawing.Size(600, 357);
			this.splitContainer1.SplitterDistance = 140;
			this.splitContainer1.TabIndex = 11;
			// 
			// UcMainPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "UcMainPage";
			this.Size = new System.Drawing.Size(600, 357);
			this.panelTitle.ResumeLayout(false);
			this.panelTitle.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panelTitle;
		private System.Windows.Forms.Panel panelLogin;
		private System.Windows.Forms.Panel panelWelcome;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.SplitContainer splitContainer1;
	}
}
