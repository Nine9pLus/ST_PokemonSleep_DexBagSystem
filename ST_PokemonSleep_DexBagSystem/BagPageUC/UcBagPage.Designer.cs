namespace ST_PokemonSleep_DexBagSystem.BagPageUC
{
	partial class UcBagPage
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.panelBagEditorTop = new System.Windows.Forms.Panel();
			this.tableLayoutPanelHint = new System.Windows.Forms.TableLayoutPanel();
			this.lblHint = new System.Windows.Forms.Label();
			this.dgvBag = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tableLayoutPanelHint.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvBag)).BeginInit();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.panelBagEditorTop);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanelHint);
			this.splitContainer1.Panel2.Controls.Add(this.dgvBag);
			this.splitContainer1.Size = new System.Drawing.Size(677, 515);
			this.splitContainer1.SplitterDistance = 260;
			this.splitContainer1.TabIndex = 2;
			// 
			// panelBagEditorTop
			// 
			this.panelBagEditorTop.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelBagEditorTop.Location = new System.Drawing.Point(0, 0);
			this.panelBagEditorTop.Margin = new System.Windows.Forms.Padding(4);
			this.panelBagEditorTop.Name = "panelBagEditorTop";
			this.panelBagEditorTop.Size = new System.Drawing.Size(677, 260);
			this.panelBagEditorTop.TabIndex = 0;
			// 
			// tableLayoutPanelHint
			// 
			this.tableLayoutPanelHint.ColumnCount = 3;
			this.tableLayoutPanelHint.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanelHint.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanelHint.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanelHint.Controls.Add(this.lblHint, 1, 1);
			this.tableLayoutPanelHint.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelHint.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanelHint.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanelHint.Name = "tableLayoutPanelHint";
			this.tableLayoutPanelHint.RowCount = 3;
			this.tableLayoutPanelHint.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanelHint.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
			this.tableLayoutPanelHint.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanelHint.Size = new System.Drawing.Size(677, 251);
			this.tableLayoutPanelHint.TabIndex = 2;
			// 
			// lblHint
			// 
			this.lblHint.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblHint.AutoSize = true;
			this.lblHint.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.lblHint.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblHint.Location = new System.Drawing.Point(274, 117);
			this.lblHint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblHint.Name = "lblHint";
			this.lblHint.Size = new System.Drawing.Size(127, 15);
			this.lblHint.TabIndex = 1;
			this.lblHint.Text = "請登入再進行管理";
			// 
			// dgvBag
			// 
			this.dgvBag.AllowUserToAddRows = false;
			this.dgvBag.AllowUserToDeleteRows = false;
			this.dgvBag.AllowUserToOrderColumns = true;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.PapayaWhip;
			this.dgvBag.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvBag.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.PapayaWhip;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvBag.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvBag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBag.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvBag.GridColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dgvBag.Location = new System.Drawing.Point(0, 0);
			this.dgvBag.Margin = new System.Windows.Forms.Padding(0);
			this.dgvBag.Name = "dgvBag";
			this.dgvBag.ReadOnly = true;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
			this.dgvBag.RowsDefaultCellStyle = dataGridViewCellStyle6;
			this.dgvBag.RowTemplate.Height = 27;
			this.dgvBag.Size = new System.Drawing.Size(677, 251);
			this.dgvBag.TabIndex = 0;
			// 
			// UcBagPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "UcBagPage";
			this.Size = new System.Drawing.Size(677, 515);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.tableLayoutPanelHint.ResumeLayout(false);
			this.tableLayoutPanelHint.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvBag)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.DataGridView dgvBag;
		private System.Windows.Forms.Label lblHint;
		private System.Windows.Forms.Panel panelBagEditorTop;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelHint;
	}
}
