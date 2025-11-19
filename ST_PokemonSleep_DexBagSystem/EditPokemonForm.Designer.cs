namespace ST_PokemonSleep_DexBagSystem
{
	partial class EditPokemonForm
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
			this.panelBagEditorContainer = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// panelBagEditorContainer
			// 
			this.panelBagEditorContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelBagEditorContainer.Location = new System.Drawing.Point(0, 0);
			this.panelBagEditorContainer.Name = "panelBagEditorContainer";
			this.panelBagEditorContainer.Size = new System.Drawing.Size(545, 270);
			this.panelBagEditorContainer.TabIndex = 1;
			// 
			// EditPokemonForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(545, 270);
			this.Controls.Add(this.panelBagEditorContainer);
			this.Name = "EditPokemonForm";
			this.Text = "FormEditPokemon";
			this.Shown += new System.EventHandler(this.EditPokemonForm_Shown);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelBagEditorContainer;
	}
}