using PokemonSleep.Models;
using PokemonSleep.Repositories;
using ST_PokemonSleep_DexBagSystem.BagPageUC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST_PokemonSleep_DexBagSystem
{
	public partial class EditPokemonForm : Form
	{
		private readonly UserPokemonModel _original;
		private readonly UcBagEditor bagEditorControl;

		public EditPokemonForm(DexRepository dexRepo, UserPokemonModel model)
		{
			InitializeComponent();
			 
			this.Text = "編輯寶可夢資料";
			this.Size = new Size(520, 235);
			this.StartPosition = FormStartPosition.CenterParent;
			this.MinimumSize = new Size(500, 250);

			_original = model;
						
			this.Controls.Add(panelBagEditorContainer);


			// 初始化編輯區
			bagEditorControl = new UcBagEditor
			{
				Dock = DockStyle.Fill,
				ConfirmButtonText = "確認更新",
				Mode = BagEditorMode.Edit
			};
			bagEditorControl.Init(dexRepo);

			panelBagEditorContainer.Controls.Add(bagEditorControl);

			bagEditorControl.ConfirmClicked += (s, e) =>
			{
				var confirm = MessageBox.Show("你確定要儲存修改嗎？", "確認更新", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (confirm != DialogResult.Yes) return;

				this.DialogResult = DialogResult.OK;
				this.Close();
			};

			#region 測試用 傳進的筆數
			//MessageBox.Show($"Init 已執行，dexRepo.GetAll()＝{_dexRepo.GetAll().Count} 筆");
			#endregion

			var btnCancel = new Button
			{
				Text = "取消",
				DialogResult = DialogResult.Cancel,
				Anchor = AnchorStyles.Bottom | AnchorStyles.Right,
				Width = 80,
				Left = this.ClientSize.Width - 100,
				Top = this.ClientSize.Height - 70
			};
			this.Controls.Add(btnCancel);
			this.CancelButton = btnCancel;

			this.Shown += EditPokemonForm_Shown;
		}
		private void EditPokemonForm_Shown(object sender, EventArgs e)
		{
			bagEditorControl.PokedexId = _original.Pokedex_id;
			bagEditorControl.CustomName = _original.Custom_name;
			bagEditorControl.Level = _original.Level;
			bagEditorControl.EvolutionCount = _original.Evolution_count;
		}

		public UserPokemonModel GetResult()
		{
			return new UserPokemonModel
			{
				Box_id = _original.Box_id,
				User_id = _original.User_id,
				Pokedex_id = bagEditorControl.PokedexId,
				Custom_name = bagEditorControl.CustomName,
				Level = bagEditorControl.Level,
				Evolution_count = bagEditorControl.EvolutionCount
			};
		}

		/// <summary>
		/// 封裝一鍵彈窗調用方式
		/// </summary>
		public static bool ShowDialog(DexRepository repo, UserPokemonModel original, out UserPokemonModel updated)
		{
			var form = new EditPokemonForm(repo, original);
			if (form.ShowDialog() == DialogResult.OK)
			{
				updated = form.GetResult();
				return true;
			}
			else
			{
				updated = null;
				return false;
			}
		}
	}
}
