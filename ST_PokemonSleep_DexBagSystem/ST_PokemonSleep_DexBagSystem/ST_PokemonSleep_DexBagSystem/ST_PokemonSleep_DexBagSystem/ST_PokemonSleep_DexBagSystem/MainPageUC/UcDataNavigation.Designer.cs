namespace ST_PokemonSleep_DexBagSystem
{
	partial class UcDataNavigation
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
			this.btnGoToBerry = new System.Windows.Forms.Button();
			this.btnGoToRecipe = new System.Windows.Forms.Button();
			this.btnGoToIngredient = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnGoToBerry
			// 
			this.btnGoToBerry.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnGoToBerry.Location = new System.Drawing.Point(172, 20);
			this.btnGoToBerry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnGoToBerry.Name = "btnGoToBerry";
			this.btnGoToBerry.Size = new System.Drawing.Size(67, 30);
			this.btnGoToBerry.TabIndex = 0;
			this.btnGoToBerry.Text = "樹果";
			this.btnGoToBerry.UseVisualStyleBackColor = true;
			// 
			// btnGoToRecipe
			// 
			this.btnGoToRecipe.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnGoToRecipe.Location = new System.Drawing.Point(20, 20);
			this.btnGoToRecipe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnGoToRecipe.Name = "btnGoToRecipe";
			this.btnGoToRecipe.Size = new System.Drawing.Size(67, 30);
			this.btnGoToRecipe.TabIndex = 0;
			this.btnGoToRecipe.Text = "食譜";
			this.btnGoToRecipe.UseVisualStyleBackColor = true;
			// 
			// btnGoToIngredient
			// 
			this.btnGoToIngredient.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnGoToIngredient.Location = new System.Drawing.Point(96, 20);
			this.btnGoToIngredient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnGoToIngredient.Name = "btnGoToIngredient";
			this.btnGoToIngredient.Size = new System.Drawing.Size(67, 30);
			this.btnGoToIngredient.TabIndex = 0;
			this.btnGoToIngredient.Text = "食材";
			this.btnGoToIngredient.UseVisualStyleBackColor = true;
			// 
			// UcDataNavigation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnGoToBerry);
			this.Controls.Add(this.btnGoToIngredient);
			this.Controls.Add(this.btnGoToRecipe);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "UcDataNavigation";
			this.Size = new System.Drawing.Size(440, 496);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnGoToBerry;
		private System.Windows.Forms.Button btnGoToRecipe;
		private System.Windows.Forms.Button btnGoToIngredient;
	}
}
