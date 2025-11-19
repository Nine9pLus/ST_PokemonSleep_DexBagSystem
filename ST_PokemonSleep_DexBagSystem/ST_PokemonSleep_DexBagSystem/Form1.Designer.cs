namespace ST_PokemonSleep_DexBagSystem
{
	partial class Form1
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

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.pokemonSleepSSMSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.pokemonSleepSSMSDataSet = new ST_PokemonSleep_DexBagSystem.PokemonSleepSSMSDataSet();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabelUser = new System.Windows.Forms.ToolStripStatusLabel();
			this.panelNavigatorBar = new System.Windows.Forms.Panel();
			this.panelMainContent = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.pokemonSleepSSMSDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pokemonSleepSSMSDataSet)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pokemonSleepSSMSDataSetBindingSource
			// 
			this.pokemonSleepSSMSDataSetBindingSource.DataSource = this.pokemonSleepSSMSDataSet;
			this.pokemonSleepSSMSDataSetBindingSource.Position = 0;
			// 
			// pokemonSleepSSMSDataSet
			// 
			this.pokemonSleepSSMSDataSet.DataSetName = "PokemonSleepSSMSDataSet";
			this.pokemonSleepSSMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelUser});
			this.statusStrip1.Location = new System.Drawing.Point(0, 693);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
			this.statusStrip1.Size = new System.Drawing.Size(584, 23);
			this.statusStrip1.TabIndex = 4;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabelUser
			// 
			this.toolStripStatusLabelUser.Name = "toolStripStatusLabelUser";
			this.toolStripStatusLabelUser.Size = new System.Drawing.Size(564, 18);
			this.toolStripStatusLabelUser.Spring = true;
			this.toolStripStatusLabelUser.Text = "登入狀態";
			this.toolStripStatusLabelUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// panelNavigatorBar
			// 
			this.panelNavigatorBar.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelNavigatorBar.Location = new System.Drawing.Point(0, 498);
			this.panelNavigatorBar.Margin = new System.Windows.Forms.Padding(4);
			this.panelNavigatorBar.Name = "panelNavigatorBar";
			this.panelNavigatorBar.Size = new System.Drawing.Size(584, 195);
			this.panelNavigatorBar.TabIndex = 5;
			// 
			// panelMainContent
			// 
			this.panelMainContent.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelMainContent.Location = new System.Drawing.Point(0, 0);
			this.panelMainContent.Margin = new System.Windows.Forms.Padding(4);
			this.panelMainContent.Name = "panelMainContent";
			this.panelMainContent.Size = new System.Drawing.Size(584, 356);
			this.panelMainContent.TabIndex = 7;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 716);
			this.Controls.Add(this.panelMainContent);
			this.Controls.Add(this.panelNavigatorBar);
			this.Controls.Add(this.statusStrip1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MinimumSize = new System.Drawing.Size(450, 250);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Pokemon Sleep 圖鑑與背包";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pokemonSleepSSMSDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pokemonSleepSSMSDataSet)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.BindingSource pokemonSleepSSMSDataSetBindingSource;
		private PokemonSleepSSMSDataSet pokemonSleepSSMSDataSet;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelUser;
		private System.Windows.Forms.Panel panelNavigatorBar;
		private System.Windows.Forms.Panel panelMainContent;
	}
}

