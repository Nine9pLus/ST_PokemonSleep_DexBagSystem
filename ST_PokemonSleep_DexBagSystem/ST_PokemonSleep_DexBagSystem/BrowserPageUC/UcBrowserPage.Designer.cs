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
			this.flpCategoryBar = new System.Windows.Forms.FlowLayoutPanel();
			this.btnShowCurrySoup = new System.Windows.Forms.Button();
			this.btnShowSalad = new System.Windows.Forms.Button();
			this.btnShowDessertDrink = new System.Windows.Forms.Button();
			this.btnShowIngredient = new System.Windows.Forms.Button();
			this.btnShowBerry = new System.Windows.Forms.Button();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.dgvBrowseResult = new System.Windows.Forms.DataGridView();
			this.recipeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.pokemonSleepSSMSDataSet = new ST_PokemonSleep_DexBagSystem.PokemonSleepSSMSDataSet();
			this.recipeTableAdapter = new ST_PokemonSleep_DexBagSystem.PokemonSleepSSMSDataSetTableAdapters.RecipeTableAdapter();
			this.recipeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.imageurlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.flpCategoryBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvBrowseResult)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.recipeBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pokemonSleepSSMSDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// flpCategoryBar
			// 
			this.flpCategoryBar.Controls.Add(this.btnShowCurrySoup);
			this.flpCategoryBar.Controls.Add(this.btnShowSalad);
			this.flpCategoryBar.Controls.Add(this.btnShowDessertDrink);
			this.flpCategoryBar.Controls.Add(this.btnShowIngredient);
			this.flpCategoryBar.Controls.Add(this.btnShowBerry);
			this.flpCategoryBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.flpCategoryBar.Location = new System.Drawing.Point(0, 0);
			this.flpCategoryBar.Margin = new System.Windows.Forms.Padding(2);
			this.flpCategoryBar.Name = "flpCategoryBar";
			this.flpCategoryBar.Size = new System.Drawing.Size(451, 63);
			this.flpCategoryBar.TabIndex = 0;
			// 
			// btnShowCurrySoup
			// 
			this.btnShowCurrySoup.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnShowCurrySoup.Location = new System.Drawing.Point(2, 2);
			this.btnShowCurrySoup.Margin = new System.Windows.Forms.Padding(2);
			this.btnShowCurrySoup.Name = "btnShowCurrySoup";
			this.btnShowCurrySoup.Size = new System.Drawing.Size(86, 30);
			this.btnShowCurrySoup.TabIndex = 5;
			this.btnShowCurrySoup.Tag = "咖哩、濃湯";
			this.btnShowCurrySoup.Text = "咖哩、濃湯";
			this.btnShowCurrySoup.UseVisualStyleBackColor = true;
			// 
			// btnShowSalad
			// 
			this.btnShowSalad.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnShowSalad.Location = new System.Drawing.Point(92, 2);
			this.btnShowSalad.Margin = new System.Windows.Forms.Padding(2);
			this.btnShowSalad.Name = "btnShowSalad";
			this.btnShowSalad.Size = new System.Drawing.Size(67, 30);
			this.btnShowSalad.TabIndex = 5;
			this.btnShowSalad.Tag = "沙拉";
			this.btnShowSalad.Text = "沙拉";
			this.btnShowSalad.UseVisualStyleBackColor = true;
			// 
			// btnShowDessertDrink
			// 
			this.btnShowDessertDrink.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnShowDessertDrink.Location = new System.Drawing.Point(163, 2);
			this.btnShowDessertDrink.Margin = new System.Windows.Forms.Padding(2);
			this.btnShowDessertDrink.Name = "btnShowDessertDrink";
			this.btnShowDessertDrink.Size = new System.Drawing.Size(86, 30);
			this.btnShowDessertDrink.TabIndex = 5;
			this.btnShowDessertDrink.Tag = "甜點、飲料";
			this.btnShowDessertDrink.Text = "甜點、飲料";
			this.btnShowDessertDrink.UseVisualStyleBackColor = true;
			// 
			// btnShowIngredient
			// 
			this.btnShowIngredient.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnShowIngredient.Location = new System.Drawing.Point(253, 2);
			this.btnShowIngredient.Margin = new System.Windows.Forms.Padding(2);
			this.btnShowIngredient.Name = "btnShowIngredient";
			this.btnShowIngredient.Size = new System.Drawing.Size(67, 30);
			this.btnShowIngredient.TabIndex = 4;
			this.btnShowIngredient.Tag = "Ingredient";
			this.btnShowIngredient.Text = "食材";
			this.btnShowIngredient.UseVisualStyleBackColor = true;
			// 
			// btnShowBerry
			// 
			this.btnShowBerry.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnShowBerry.Location = new System.Drawing.Point(324, 2);
			this.btnShowBerry.Margin = new System.Windows.Forms.Padding(2);
			this.btnShowBerry.Name = "btnShowBerry";
			this.btnShowBerry.Size = new System.Drawing.Size(67, 30);
			this.btnShowBerry.TabIndex = 3;
			this.btnShowBerry.Tag = "Berry";
			this.btnShowBerry.Text = "樹果";
			this.btnShowBerry.UseVisualStyleBackColor = true;
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
			this.splitContainer1.Panel1.Controls.Add(this.flpCategoryBar);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.dgvBrowseResult);
			this.splitContainer1.Size = new System.Drawing.Size(451, 438);
			this.splitContainer1.SplitterDistance = 63;
			this.splitContainer1.SplitterWidth = 3;
			this.splitContainer1.TabIndex = 1;
			// 
			// dgvBrowseResult
			// 
			this.dgvBrowseResult.AllowUserToAddRows = false;
			this.dgvBrowseResult.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.dgvBrowseResult.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvBrowseResult.AutoGenerateColumns = false;
			this.dgvBrowseResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBrowseResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recipeidDataGridViewTextBoxColumn,
            this.imageurlDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
			this.dgvBrowseResult.DataSource = this.recipeBindingSource;
			this.dgvBrowseResult.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvBrowseResult.Location = new System.Drawing.Point(0, 0);
			this.dgvBrowseResult.Margin = new System.Windows.Forms.Padding(2);
			this.dgvBrowseResult.Name = "dgvBrowseResult";
			this.dgvBrowseResult.ReadOnly = true;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			this.dgvBrowseResult.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvBrowseResult.RowTemplate.Height = 27;
			this.dgvBrowseResult.Size = new System.Drawing.Size(451, 372);
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
			// recipeidDataGridViewTextBoxColumn
			// 
			this.recipeidDataGridViewTextBoxColumn.DataPropertyName = "recipe_id";
			this.recipeidDataGridViewTextBoxColumn.HeaderText = "ID";
			this.recipeidDataGridViewTextBoxColumn.Name = "recipeidDataGridViewTextBoxColumn";
			this.recipeidDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// imageurlDataGridViewTextBoxColumn
			// 
			this.imageurlDataGridViewTextBoxColumn.DataPropertyName = "image_url";
			this.imageurlDataGridViewTextBoxColumn.HeaderText = "圖示";
			this.imageurlDataGridViewTextBoxColumn.Name = "imageurlDataGridViewTextBoxColumn";
			this.imageurlDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "料理名稱";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// descriptionDataGridViewTextBoxColumn
			// 
			this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
			this.descriptionDataGridViewTextBoxColumn.HeaderText = "料理敘述";
			this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
			this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// UcBrowserPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "UcBrowserPage";
			this.Size = new System.Drawing.Size(451, 438);
			this.Load += new System.EventHandler(this.UcBrowserSection_Load);
			this.flpCategoryBar.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvBrowseResult)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.recipeBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pokemonSleepSSMSDataSet)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flpCategoryBar;
		private System.Windows.Forms.Button btnShowBerry;
		private System.Windows.Forms.Button btnShowIngredient;
		private System.Windows.Forms.Button btnShowCurrySoup;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.DataGridView dgvBrowseResult;
		private System.Windows.Forms.Button btnShowSalad;
		private System.Windows.Forms.Button btnShowDessertDrink;
		private System.Windows.Forms.BindingSource recipeBindingSource;
		private PokemonSleepSSMSDataSet pokemonSleepSSMSDataSet;
		private PokemonSleepSSMSDataSetTableAdapters.RecipeTableAdapter recipeTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn recipeidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn imageurlDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
	}
}
