namespace ST_PokemonSleep_DexBagSystem.BagPageUC
{
	partial class UcBagEditor
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
			this.tableLayoutPanelChoose = new System.Windows.Forms.TableLayoutPanel();
			this.lblPokemonName = new System.Windows.Forms.Label();
			this.cboPokedex = new System.Windows.Forms.ComboBox();
			this.lblLevel = new System.Windows.Forms.Label();
			this.lblStage = new System.Windows.Forms.Label();
			this.cboEvoCount = new System.Windows.Forms.ComboBox();
			this.lblCustomName = new System.Windows.Forms.Label();
			this.txtCustomName = new System.Windows.Forms.TextBox();
			this.numLevel = new System.Windows.Forms.NumericUpDown();
			this.btnAdd = new System.Windows.Forms.Button();
			this.tableLayoutPanelBtnAdd = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanelBtnConfirm = new System.Windows.Forms.TableLayoutPanel();
			this.btnConfirm = new System.Windows.Forms.Button();
			this.tableLayoutPanelChoose.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numLevel)).BeginInit();
			this.tableLayoutPanelBtnAdd.SuspendLayout();
			this.tableLayoutPanelBtnConfirm.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanelChoose
			// 
			this.tableLayoutPanelChoose.ColumnCount = 6;
			this.tableLayoutPanelChoose.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.tableLayoutPanelChoose.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19F));
			this.tableLayoutPanelChoose.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26F));
			this.tableLayoutPanelChoose.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanelChoose.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanelChoose.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.tableLayoutPanelChoose.Controls.Add(this.lblPokemonName, 1, 1);
			this.tableLayoutPanelChoose.Controls.Add(this.cboPokedex, 2, 1);
			this.tableLayoutPanelChoose.Controls.Add(this.lblLevel, 1, 2);
			this.tableLayoutPanelChoose.Controls.Add(this.lblStage, 3, 2);
			this.tableLayoutPanelChoose.Controls.Add(this.cboEvoCount, 4, 2);
			this.tableLayoutPanelChoose.Controls.Add(this.lblCustomName, 3, 1);
			this.tableLayoutPanelChoose.Controls.Add(this.txtCustomName, 4, 1);
			this.tableLayoutPanelChoose.Controls.Add(this.numLevel, 2, 2);
			this.tableLayoutPanelChoose.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanelChoose.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanelChoose.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
			this.tableLayoutPanelChoose.Name = "tableLayoutPanelChoose";
			this.tableLayoutPanelChoose.RowCount = 3;
			this.tableLayoutPanelChoose.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
			this.tableLayoutPanelChoose.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
			this.tableLayoutPanelChoose.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
			this.tableLayoutPanelChoose.Size = new System.Drawing.Size(677, 166);
			this.tableLayoutPanelChoose.TabIndex = 7;
			// 
			// lblPokemonName
			// 
			this.lblPokemonName.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.lblPokemonName.AutoSize = true;
			this.lblPokemonName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblPokemonName.Location = new System.Drawing.Point(84, 44);
			this.lblPokemonName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblPokemonName.Name = "lblPokemonName";
			this.lblPokemonName.Size = new System.Drawing.Size(73, 20);
			this.lblPokemonName.TabIndex = 4;
			this.lblPokemonName.Text = "寶可夢：";
			// 
			// cboPokedex
			// 
			this.cboPokedex.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.cboPokedex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboPokedex.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.cboPokedex.FormattingEnabled = true;
			this.cboPokedex.Location = new System.Drawing.Point(165, 44);
			this.cboPokedex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cboPokedex.Name = "cboPokedex";
			this.cboPokedex.Size = new System.Drawing.Size(160, 28);
			this.cboPokedex.TabIndex = 3;
			// 
			// lblLevel
			// 
			this.lblLevel.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.lblLevel.AutoSize = true;
			this.lblLevel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblLevel.Location = new System.Drawing.Point(68, 118);
			this.lblLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblLevel.Name = "lblLevel";
			this.lblLevel.Size = new System.Drawing.Size(89, 20);
			this.lblLevel.TabIndex = 6;
			this.lblLevel.Text = "等級選擇：";
			// 
			// lblStage
			// 
			this.lblStage.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.lblStage.AutoSize = true;
			this.lblStage.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblStage.Location = new System.Drawing.Point(379, 118);
			this.lblStage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblStage.Name = "lblStage";
			this.lblStage.Size = new System.Drawing.Size(89, 20);
			this.lblStage.TabIndex = 5;
			this.lblStage.Text = "進化次數：";
			// 
			// cboEvoCount
			// 
			this.cboEvoCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.cboEvoCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboEvoCount.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.cboEvoCount.FormattingEnabled = true;
			this.cboEvoCount.Location = new System.Drawing.Point(476, 118);
			this.cboEvoCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cboEvoCount.Name = "cboEvoCount";
			this.cboEvoCount.Size = new System.Drawing.Size(160, 28);
			this.cboEvoCount.TabIndex = 8;
			// 
			// lblCustomName
			// 
			this.lblCustomName.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.lblCustomName.AutoSize = true;
			this.lblCustomName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblCustomName.Location = new System.Drawing.Point(379, 44);
			this.lblCustomName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCustomName.Name = "lblCustomName";
			this.lblCustomName.Size = new System.Drawing.Size(89, 20);
			this.lblCustomName.TabIndex = 5;
			this.lblCustomName.Text = "自訂名稱：";
			// 
			// txtCustomName
			// 
			this.txtCustomName.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtCustomName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtCustomName.Location = new System.Drawing.Point(476, 40);
			this.txtCustomName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtCustomName.Name = "txtCustomName";
			this.txtCustomName.Size = new System.Drawing.Size(160, 28);
			this.txtCustomName.TabIndex = 10;
			// 
			// numLevel
			// 
			this.numLevel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numLevel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.numLevel.Location = new System.Drawing.Point(165, 114);
			this.numLevel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.numLevel.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
			this.numLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numLevel.Name = "numLevel";
			this.numLevel.Size = new System.Drawing.Size(160, 28);
			this.numLevel.TabIndex = 11;
			this.numLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnAdd.Location = new System.Drawing.Point(287, 11);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(100, 29);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "新增";
			this.btnAdd.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanelBtnAdd
			// 
			this.tableLayoutPanelBtnAdd.ColumnCount = 3;
			this.tableLayoutPanelBtnAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanelBtnAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanelBtnAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanelBtnAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanelBtnAdd.Controls.Add(this.btnAdd, 1, 1);
			this.tableLayoutPanelBtnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelBtnAdd.Location = new System.Drawing.Point(0, 166);
			this.tableLayoutPanelBtnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tableLayoutPanelBtnAdd.Name = "tableLayoutPanelBtnAdd";
			this.tableLayoutPanelBtnAdd.RowCount = 3;
			this.tableLayoutPanelBtnAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanelBtnAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.10526F));
			this.tableLayoutPanelBtnAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.421053F));
			this.tableLayoutPanelBtnAdd.Size = new System.Drawing.Size(677, 73);
			this.tableLayoutPanelBtnAdd.TabIndex = 8;
			// 
			// tableLayoutPanelBtnConfirm
			// 
			this.tableLayoutPanelBtnConfirm.ColumnCount = 3;
			this.tableLayoutPanelBtnConfirm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanelBtnConfirm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanelBtnConfirm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanelBtnConfirm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanelBtnConfirm.Controls.Add(this.btnConfirm, 1, 1);
			this.tableLayoutPanelBtnConfirm.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelBtnConfirm.Location = new System.Drawing.Point(0, 166);
			this.tableLayoutPanelBtnConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tableLayoutPanelBtnConfirm.Name = "tableLayoutPanelBtnConfirm";
			this.tableLayoutPanelBtnConfirm.RowCount = 3;
			this.tableLayoutPanelBtnConfirm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanelBtnConfirm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.10526F));
			this.tableLayoutPanelBtnConfirm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.421053F));
			this.tableLayoutPanelBtnConfirm.Size = new System.Drawing.Size(677, 73);
			this.tableLayoutPanelBtnConfirm.TabIndex = 9;
			// 
			// btnConfirm
			// 
			this.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnConfirm.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnConfirm.Location = new System.Drawing.Point(275, 11);
			this.btnConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnConfirm.Name = "btnConfirm";
			this.btnConfirm.Size = new System.Drawing.Size(125, 45);
			this.btnConfirm.TabIndex = 0;
			this.btnConfirm.Text = "確認更新";
			this.btnConfirm.UseVisualStyleBackColor = true;
			// 
			// UcBagEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanelBtnConfirm);
			this.Controls.Add(this.tableLayoutPanelBtnAdd);
			this.Controls.Add(this.tableLayoutPanelChoose);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "UcBagEditor";
			this.Size = new System.Drawing.Size(677, 239);
			this.tableLayoutPanelChoose.ResumeLayout(false);
			this.tableLayoutPanelChoose.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numLevel)).EndInit();
			this.tableLayoutPanelBtnAdd.ResumeLayout(false);
			this.tableLayoutPanelBtnConfirm.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelChoose;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Label lblPokemonName;
		private System.Windows.Forms.ComboBox cboPokedex;
		private System.Windows.Forms.Label lblLevel;
		private System.Windows.Forms.Label lblStage;
		private System.Windows.Forms.ComboBox cboEvoCount;
		private System.Windows.Forms.Label lblCustomName;
		private System.Windows.Forms.TextBox txtCustomName;
		private System.Windows.Forms.NumericUpDown numLevel;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBtnAdd;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBtnConfirm;
		private System.Windows.Forms.Button btnConfirm;
	}
}
