namespace ST_PokemonSleep_DexBagSystem
{
	partial class UcBrowserPage
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btnShowCurrySoup = new System.Windows.Forms.Button();
			this.btnShowSalad = new System.Windows.Forms.Button();
			this.btnShowDessertDrink = new System.Windows.Forms.Button();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.dgvBrowseResult = new System.Windows.Forms.DataGridView();
			this.recipeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.pokemonSleepSSMSDataSet = new ST_PokemonSleep_DexBagSystem.PokemonSleepSSMSDataSet();
			this.recipeTableAdapter = new ST_PokemonSleep_DexBagSystem.PokemonSleepSSMSDataSetTableAdapters.RecipeTableAdapter();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.imageurlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.recipeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tableLayoutPanelCategoryBar = new System.Windows.Forms.TableLayoutPanel();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvBrowseResult)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.recipeBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pokemonSleepSSMSDataSet)).BeginInit();
			this.tableLayoutPanelCategoryBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnShowCurrySoup
			// 
			this.btnShowCurrySoup.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnShowCurrySoup.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnShowCurrySoup.Location = new System.Drawing.Point(51, 8);
			this.btnShowCurrySoup.Margin = new System.Windows.Forms.Padding(2);
			this.btnShowCurrySoup.Name = "btnShowCurrySoup";
			this.btnShowCurrySoup.Size = new System.Drawing.Size(86, 30);
			this.btnShowCurrySoup.TabIndex = 5;
			this.btnShowCurrySoup.Tag = "";
			this.btnShowCurrySoup.Text = "咖哩、濃湯";
			this.btnShowCurrySoup.UseVisualStyleBackColor = true;
			// 
			// btnShowSalad
			// 
			this.btnShowSalad.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnShowSalad.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnShowSalad.Location = new System.Drawing.Point(202, 8);
			this.btnShowSalad.Margin = new System.Windows.Forms.Padding(2);
			this.btnShowSalad.Name = "btnShowSalad";
			this.btnShowSalad.Size = new System.Drawing.Size(67, 30);
			this.btnShowSalad.TabIndex = 5;
			this.btnShowSalad.Tag = "";
			this.btnShowSalad.Text = "沙拉";
			this.btnShowSalad.UseVisualStyleBackColor = true;
			// 
			// btnShowDessertDrink
			// 
			this.btnShowDessertDrink.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnShowDessertDrink.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnShowDessertDrink.Location = new System.Drawing.Point(335, 8);
			this.btnShowDessertDrink.Margin = new System.Windows.Forms.Padding(2);
			this.btnShowDessertDrink.Name = "btnShowDessertDrink";
			this.btnShowDessertDrink.Size = new System.Drawing.Size(86, 30);
			this.btnShowDessertDrink.TabIndex = 5;
			this.btnShowDessertDrink.Tag = "";
			this.btnShowDessertDrink.Text = "甜點、飲料";
			this.btnShowDessertDrink.UseVisualStyleBackColor = true;
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
			this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanelCategoryBar);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.dgvBrowseResult);
			this.splitContainer1.Size = new System.Drawing.Size(476, 432);
			this.splitContainer1.SplitterDistance = 47;
			this.splitContainer1.SplitterWidth = 3;
			this.splitContainer1.TabIndex = 1;
			// 
			// dgvBrowseResult
			// 
			this.dgvBrowseResult.AllowUserToAddRows = false;
			this.dgvBrowseResult.AllowUserToDeleteRows = false;
			this.dgvBrowseResult.AllowUserToOrderColumns = true;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.dgvBrowseResult.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvBrowseResult.AutoGenerateColumns = false;
			this.dgvBrowseResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBrowseResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.imageurlDataGridViewTextBoxColumn,
            this.recipeidDataGridViewTextBoxColumn});
			this.dgvBrowseResult.DataSource = this.recipeBindingSource;
			this.dgvBrowseResult.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvBrowseResult.Location = new System.Drawing.Point(0, 0);
			this.dgvBrowseResult.Margin = new System.Windows.Forms.Padding(2);
			this.dgvBrowseResult.Name = "dgvBrowseResult";
			this.dgvBrowseResult.ReadOnly = true;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			this.dgvBrowseResult.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvBrowseResult.RowTemplate.Height = 27;
			this.dgvBrowseResult.Size = new System.Drawing.Size(476, 382);
			this.dgvBrowseResult.TabIndex = 0;
			this.dgvBrowseResult.Resize += new System.EventHandler(this.dgvBrowseResult_Resize);
			// 
			// recipeBindingSource
			// 
			this.recipeBindingSource.DataMember = "Recipe";
			this.recipeBindingSource.DataSource = this.pokemonSleepSSMSDataSet;
			// 
			// pokemonSleepSSMSDataSet
			// 
			this.pokemonSleepSSMSDataSet.DataSetName = "PokemonSleepSSMSDataSet";
			this.pokemonSleepSSMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// recipeTableAdapter
			// 
			this.recipeTableAdapter.ClearBeforeFill = true;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// descriptionDataGridViewTextBoxColumn
			// 
			this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
			this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
			this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
			this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// categoryDataGridViewTextBoxColumn
			// 
			this.categoryDataGridViewTextBoxColumn.DataPropertyName = "category";
			this.categoryDataGridViewTextBoxColumn.HeaderText = "category";
			this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
			this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// imageurlDataGridViewTextBoxColumn
			// 
			this.imageurlDataGridViewTextBoxColumn.DataPropertyName = "image_url";
			this.imageurlDataGridViewTextBoxColumn.HeaderText = "image_url";
			this.imageurlDataGridViewTextBoxColumn.Name = "imageurlDataGridViewTextBoxColumn";
			this.imageurlDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// recipeidDataGridViewTextBoxColumn
			// 
			this.recipeidDataGridViewTextBoxColumn.DataPropertyName = "recipe_id";
			this.recipeidDataGridViewTextBoxColumn.HeaderText = "recipe_id";
			this.recipeidDataGridViewTextBoxColumn.Name = "recipeidDataGridViewTextBoxColumn";
			this.recipeidDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// tableLayoutPanelCategoryBar
			// 
			this.tableLayoutPanelCategoryBar.ColumnCount = 5;
			this.tableLayoutPanelCategoryBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.tableLayoutPanelCategoryBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanelCategoryBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanelCategoryBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanelCategoryBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.tableLayoutPanelCategoryBar.Controls.Add(this.btnShowCurrySoup, 1, 0);
			this.tableLayoutPanelCategoryBar.Controls.Add(this.btnShowSalad, 2, 0);
			this.tableLayoutPanelCategoryBar.Controls.Add(this.btnShowDessertDrink, 3, 0);
			this.tableLayoutPanelCategoryBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelCategoryBar.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanelCategoryBar.Name = "tableLayoutPanelCategoryBar";
			this.tableLayoutPanelCategoryBar.RowCount = 1;
			this.tableLayoutPanelCategoryBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelCategoryBar.Size = new System.Drawing.Size(476, 47);
			this.tableLayoutPanelCategoryBar.TabIndex = 6;
			// 
			// UcBrowserPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "UcBrowserPage";
			this.Size = new System.Drawing.Size(476, 432);
			this.Load += new System.EventHandler(this.UcBrowserPage_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvBrowseResult)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.recipeBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pokemonSleepSSMSDataSet)).EndInit();
			this.tableLayoutPanelCategoryBar.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnShowCurrySoup;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.DataGridView dgvBrowseResult;
		private System.Windows.Forms.Button btnShowSalad;
		private System.Windows.Forms.Button btnShowDessertDrink;
		private System.Windows.Forms.BindingSource recipeBindingSource;
		private PokemonSleepSSMSDataSet pokemonSleepSSMSDataSet;
		private PokemonSleepSSMSDataSetTableAdapters.RecipeTableAdapter recipeTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn imageurlDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn recipeidDataGridViewTextBoxColumn;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCategoryBar;
	}
}
