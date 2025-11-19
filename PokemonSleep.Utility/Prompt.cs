using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonSleep.Utility
{
	public static class Prompt  //（顯示簡易輸入對話框）
	{
		public static string ShowDialog(string text, string caption, string defaultValue = "")
		{
			Form prompt = new Form()
			{
				Width = 400,
				Height = 160,
				FormBorderStyle = FormBorderStyle.FixedDialog,
				Text = caption,
				StartPosition = FormStartPosition.CenterScreen
			};

			Label lblText = new Label() { Left = 20, Top = 20, Text = text, Width = 340 };
			TextBox inputBox = new TextBox() { Left = 20, Top = 50, Width = 340 };
			inputBox.Text = defaultValue ?? "";

			Button confirm = new Button() { Text = "確定", Left = 280, Width = 80, Top = 80, DialogResult = DialogResult.OK };

			prompt.Controls.Add(lblText);
			prompt.Controls.Add(inputBox);
			prompt.Controls.Add(confirm);

			prompt.AcceptButton = confirm;

			return prompt.ShowDialog() == DialogResult.OK ? inputBox.Text : null;
		}
	}
}
