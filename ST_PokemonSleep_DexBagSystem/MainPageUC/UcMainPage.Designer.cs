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
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.tableLayoutPanelLogin = new System.Windows.Forms.TableLayoutPanel();
			this.groupBoxContent = new System.Windows.Forms.GroupBox();
			this.lblTitle = new System.Windows.Forms.Label();
			this.panelTitle.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tableLayoutPanelLogin.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelTitle
			// 
			this.panelTitle.AutoSize = true;
			this.panelTitle.Controls.Add(this.lblTitle);
			this.panelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelTitle.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.panelTitle.Location = new System.Drawing.Point(0, 0);
			this.panelTitle.Margin = new System.Windows.Forms.Padding(4);
			this.panelTitle.Name = "panelTitle";
			this.panelTitle.Size = new System.Drawing.Size(476, 128);
			this.panelTitle.TabIndex = 8;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.panelTitle);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanelLogin);
			this.splitContainer1.Size = new System.Drawing.Size(476, 432);
			this.splitContainer1.SplitterDistance = 128;
			this.splitContainer1.SplitterWidth = 3;
			this.splitContainer1.TabIndex = 11;
			// 
			// tableLayoutPanelLogin
			// 
			this.tableLayoutPanelLogin.ColumnCount = 3;
			this.tableLayoutPanelLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.tableLayoutPanelLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
			this.tableLayoutPanelLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.tableLayoutPanelLogin.Controls.Add(this.groupBoxContent, 1, 1);
			this.tableLayoutPanelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelLogin.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
			this.tableLayoutPanelLogin.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanelLogin.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
			this.tableLayoutPanelLogin.Name = "tableLayoutPanelLogin";
			this.tableLayoutPanelLogin.RowCount = 3;
			this.tableLayoutPanelLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.tableLayoutPanelLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
			this.tableLayoutPanelLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanelLogin.Size = new System.Drawing.Size(476, 301);
			this.tableLayoutPanelLogin.TabIndex = 0;
			// 
			// groupBoxContent
			// 
			this.groupBoxContent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxContent.Location = new System.Drawing.Point(26, 18);
			this.groupBoxContent.Name = "groupBoxContent";
			this.groupBoxContent.Size = new System.Drawing.Size(422, 249);
			this.groupBoxContent.TabIndex = 0;
			this.groupBoxContent.TabStop = false;
			// 
			// lblTitle
			// 
			this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblTitle.Location = new System.Drawing.Point(0, 0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(476, 128);
			this.lblTitle.TabIndex = 7;
			this.lblTitle.Text = "Pokémon Sleep 背包";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// UcMainPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.Controls.Add(this.splitContainer1);
			this.Name = "UcMainPage";
			this.Size = new System.Drawing.Size(476, 432);
			this.panelTitle.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.tableLayoutPanelLogin.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panelTitle;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLogin;
		private System.Windows.Forms.GroupBox groupBoxContent;
	}
}
