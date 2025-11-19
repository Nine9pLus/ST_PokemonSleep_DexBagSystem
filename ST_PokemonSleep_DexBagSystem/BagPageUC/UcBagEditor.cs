using PokemonSleep.Models;
using PokemonSleep.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST_PokemonSleep_DexBagSystem.BagPageUC
{
	public enum BagEditorMode
	{
		Add, Edit
	}

	public partial class UcBagEditor : UserControl
	{
		public event EventHandler ConfirmClicked;
		private BagEditorMode _mode = BagEditorMode.Add;

		public BagEditorMode Mode
		{
			get => _mode;
			set
			{
				_mode = value;
				UpdateModeUI();
			}
		}			

		private void UpdateModeUI()
		{
			// 切換按鈕可見狀態
			tableLayoutPanelBtnAdd.Visible = (_mode == BagEditorMode.Add);
			tableLayoutPanelBtnConfirm.Visible = (_mode == BagEditorMode.Edit);
		}

		public UcBagEditor()
		{
			InitializeComponent();

			btnAdd.Click += FormSubmitted;
			btnConfirm.Click += FormSubmitted;
			Mode = BagEditorMode.Add;
		}

		private void FormSubmitted(object sender, EventArgs e)
		{
			ConfirmClicked?.Invoke(this, EventArgs.Empty);
		}			

		/// <summary>
		/// 提供外部取得選擇的 Pokédex ID
		/// </summary>
		public int PokedexId
		{
			get => cboPokedex.SelectedValue != null ? (int)cboPokedex.SelectedValue : 0;
			set => cboPokedex.SelectedValue = value;
		}

		public string CustomName
		{
			get => txtCustomName.Text.Trim();
			set => txtCustomName.Text = value ?? "";
		}

		public int Level
		{
			get => (int)numLevel.Value;
			set => numLevel.Value = Math.Min(Math.Max(value, 1), 99);
		}

		public int EvolutionCount
		{
			get => int.TryParse(Convert.ToString(cboEvoCount.SelectedItem), out int result) ? result : 0;
			set => cboEvoCount.SelectedItem = value;
		}

		public string ConfirmButtonText
		{
			get => Mode == BagEditorMode.Edit ? btnConfirm.Text : btnAdd.Text;
			set
			{
				btnAdd.Text = value;
				btnConfirm.Text = value;
			}
		}

		/// <summary>
		/// 初始化控制項資料（傳入圖鑑資料來源）
		/// </summary>
		public void Init(DexRepository dexRepo)
		{
			var pokedexList = dexRepo.GetAll();

			cboPokedex.DataSource = null;
			cboPokedex.DataSource = pokedexList;
			cboPokedex.DisplayMember = "Name";
			cboPokedex.ValueMember = "Pokedex_id";
			cboPokedex.SelectedIndex = -1;

			#region 測試用 內容確認
			//MessageBox.Show($"🔍 第1筆名稱：{pokedexList[0].Name}");
			//MessageBox.Show($"cboPokedex.Items.Count: {cboPokedex.Items.Count}");

			//for (int i = 0; i < Math.Min(5, cboPokedex.Items.Count); i++)
			//{
			//	string itemText = cboPokedex.GetItemText(cboPokedex.Items[i]);
			//	MessageBox.Show($"#{i + 1} - {itemText}");
			//}
			//List<string> testItems = new List<string> { "001 皮卡丘", "002 小火龍", "003 妙蛙種子" };
			//cbTest.DataSource = testItems;
			//MessageBox.Show(cbTest.Items.Count.ToString());
			#endregion

			// 等級：1~99
			numLevel.Minimum = 1;
			numLevel.Maximum = 99;
			numLevel.Value = 1;

			// 進化次數
			cboEvoCount.Items.Clear();
			cboEvoCount.Items.AddRange(new object[] { 0, 1, 2 });
			cboEvoCount.SelectedIndex = 0;

			#region 測試用 內容確認
			//if (cboPokedex.Items.Count > 0)
			//{
			//	string first = cboPokedex.GetItemText(cboPokedex.Items[0]);
			//	MessageBox.Show($"🔍 第1筆選項：{first}", "ComboBox 測試");
			//}
			//else
			//{
			//	MessageBox.Show("❌ cboPokedex.Items 為 0，畫面會看不到任何選單", "錯誤");
			//}
			#endregion
		}

		/// <summary>
		/// 快速清空欄位（新增後呼叫）
		/// </summary>
		public void Clear()
		{
			cboPokedex.SelectedIndex = 0;
			txtCustomName.Clear();
			numLevel.Value = 1;
			cboEvoCount.SelectedIndex = 0;
		}

		/// <summary>
		/// 清空選取
		/// </summary>
		public void SetEmpty()
		{
			cboPokedex.SelectedIndex = -1;
			txtCustomName.Clear();
			numLevel.Value = numLevel.Minimum;
			numLevel.Text = "";
			cboEvoCount.SelectedIndex = -1;
		}
	}
}
