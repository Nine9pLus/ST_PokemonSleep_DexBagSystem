using PokemonSleep.Models;
using PokemonSleep.Repositories;
using PokemonSleep.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prompt = PokemonSleep.Utility.Prompt;

namespace ST_PokemonSleep_DexBagSystem.BagPageUC
{
	public partial class UcBagPage : UserControl
	{
		private readonly UserPokemonRepository _repository = new UserPokemonRepository();
		private readonly DexRepository _dexRepo = new DexRepository(); // 顯示寶可夢選單（Pokédex）
		private UserModel _currentUser;
		private UcBagEditor _ucBagEditorTop;

		public UcBagPage()
		{
			InitializeComponent();

			dgvBag.CellContentClick += dgvBag_CellClick;
			dgvBag.DataBindingComplete += dgvBag_DataBindingComplete;
			dgvBag.Resize += (s, e) => ResizeAdjustColumns(); // Resize 時欄位調整

			_ucBagEditorTop = new UcBagEditor();
			_ucBagEditorTop.Dock = DockStyle.Fill;
			_ucBagEditorTop.Init(_dexRepo);
			_ucBagEditorTop.Mode = BagEditorMode.Add;
			_ucBagEditorTop.ConfirmClicked += BagEditor_AddClicked;

			panelBagEditorTop.Controls.Add(_ucBagEditorTop);
		}

		#region 根據登入狀態切換
		public void SetLoginUser(UserModel user)
		{
			_currentUser = user;

			if (_currentUser != null)
			{
				ShowLoginPanel();  // 顯示功能區（可新增）
				LoadUserPokemons();
			}
			else
			{
				ShowUnloginPanel(); // 顯示未登入提示						
			}
		}
		#endregion

		#region 登入與否顯示Panel
		private void ShowUnloginPanel() //未登入
		{
			dgvBag.DataSource = null;

			panelBagEditorTop.Enabled = false;
			dgvBag.Enabled = false;

			tableLayoutPanelHint.Visible = true;

			_ucBagEditorTop.SetEmpty();
		}

		private void ShowLoginPanel()   //已登入
		{
			panelBagEditorTop.Enabled = true;
			dgvBag.Enabled = true;

			tableLayoutPanelHint.Visible = false;

			_ucBagEditorTop.Clear();
		}
		#endregion

		private void LoadUserPokemons()
		{
			if (_currentUser == null) return;

			List<UserPokemonModel> pokemons = _repository.GetUserPokemons(_currentUser.UserId);

			dgvBag.Columns.Clear();
			dgvBag.DataSource = null;
			dgvBag.AutoGenerateColumns = false;

			#region dgvBag 新增欄位 - 固定欄寬（序號、等級、進化次數）、變動欄寬（官方名稱、暱稱）

			// 序號,未繫結
			dgvBag.Columns.Add(new DataGridViewTextBoxColumn
			{
				Name = "colNo",           // 手動欄位
				HeaderText = "No.",
				ReadOnly = true,
				Width = 35,
				AutoSizeMode = DataGridViewAutoSizeColumnMode.None
			});

			// 官方名稱
			dgvBag.Columns.Add(new DataGridViewTextBoxColumn
			{
				DataPropertyName = "name",
				HeaderText = "官方名稱",
				Width = 80,
				ReadOnly = true,
				AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
			});

			// 暱稱
			dgvBag.Columns.Add(new DataGridViewTextBoxColumn
			{
				DataPropertyName = "Custom_name",
				HeaderText = "暱稱",
				Width = 50,
				ReadOnly = true,
				AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
			});

			// 等級
			dgvBag.Columns.Add(new DataGridViewTextBoxColumn
			{
				DataPropertyName = "Level",
				HeaderText = "等級",
				Width = 25,
				AutoSizeMode = DataGridViewAutoSizeColumnMode.None
			});

			// 進化次數
			dgvBag.Columns.Add(new DataGridViewTextBoxColumn
			{
				DataPropertyName = "Evolution_count",
				HeaderText = "進化次數",
				Width = 70,
				AutoSizeMode = DataGridViewAutoSizeColumnMode.None
			});
			#endregion

			#region dgvBag 新增 - 固定欄寬（編輯刪除btn）

			// 編輯
			dgvBag.Columns.Add(new DataGridViewButtonColumn
			{
				Name = "colEdit",
				Text = "編輯",
				UseColumnTextForButtonValue = true,
				HeaderText = "",
				Width = 60,
				AutoSizeMode = DataGridViewAutoSizeColumnMode.None
			});

			// 刪除
			dgvBag.Columns.Add(new DataGridViewButtonColumn
			{
				Name = "colDelete",
				Text = "刪除",
				UseColumnTextForButtonValue = true,
				HeaderText = "",
				Width = 60,
				AutoSizeMode = DataGridViewAutoSizeColumnMode.None
			});
			#endregion

			#region old
			//dgvBag.Columns.Add(new DataGridViewTextBoxColumn
			//{
			//	DataPropertyName = "Pokedex_id",
			//	HeaderText = "編號",
			//	ReadOnly = true,
			//	Width = 60
			//});

			//dgvBag.Columns.Add(new DataGridViewTextBoxColumn
			//{
			//	DataPropertyName = "DisplayName",
			//	HeaderText = "寶可夢名稱",
			//	AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
			//	ReadOnly = true
			//});
			#endregion

			// 資料繫結
			dgvBag.DataSource = pokemons;
			dgvBag.ClearSelection();  // 預設不要選中第一列

			// 換行
			dgvBag.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
			dgvBag.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

			// 數據繫結完成後，為每列填入序號
			for (int i = 0; i < dgvBag.Rows.Count; i++)
			{
				dgvBag.Rows[i].Cells["colNo"].Value = i + 1;
			}

			dgvBag.ClearSelection();
		}

		#region 新增 / 刷新按鈕 Click 事件
		private void BagEditor_AddClicked(object sender, EventArgs e)
		{
			if (_currentUser == null) return;

			#region old
			//if (cboPokedex.SelectedItem == null || cboEvoCount.SelectedItem == null)
			//{
			//	MessageBox.Show("請選擇寶可夢與進化次數！");
			//	return;
			//}

			//var model = new UserPokemonModel
			//{
			//	User_id = _currentUser.UserId,
			//	Pokedex_id = (int)cboPokedex.SelectedValue,
			//	Custom_name = txtCustomName.Text.Trim(),
			//	Level = (int)numLevel.Value,
			//	Evolution_count = Convert.ToInt32(cboEvoCount.SelectedItem)
			//};
			#endregion

			var model = new UserPokemonModel
			{
				User_id = _currentUser.UserId,
				Pokedex_id = _ucBagEditorTop.PokedexId,
				Custom_name = _ucBagEditorTop.CustomName,
				Level = _ucBagEditorTop.Level,
				Evolution_count = _ucBagEditorTop.EvolutionCount
			};

			if (model.Pokedex_id == 0)
			{
				MessageBox.Show("請選擇寶可夢");
				return;
			}

			_repository.InsertUserPokemon(model);
			LoadUserPokemons();
			_ucBagEditorTop.Clear(); // 清除輸入欄位
		}

		private void BagEditor_RefreshClicked(object sender, EventArgs e)
		{
			LoadUserPokemons();
		}
		#endregion

		#region 在背包畫面（UcBagPage）裡點擊 dgvBag 編輯/刪除按鈕
		private void dgvBag_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			// 排除點擊欄頭或空白列
			if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
			if (e.RowIndex >= dgvBag.Rows.Count) return;

			// 確保 Row 有資料綁定
			var row = dgvBag.Rows[e.RowIndex];
			var data = row.DataBoundItem as UserPokemonModel;
			if (data == null) return;

			//判斷是哪個欄位被點
			string colName = dgvBag.Columns[e.ColumnIndex].Name;

			if (colName == "colEdit")
			{
				// 使用靜態 ShowDialog，回傳是否按 OK 並取得修改資料
				if (EditPokemonForm.ShowDialog(_dexRepo, data, out UserPokemonModel updated))
				{
					if (updated != null)
					{
						_repository.UpdatePokemon(updated);
						LoadUserPokemons();
					}
				}
			}
			else if (colName == "colDelete")
			{
				var confirm = MessageBox.Show($"確定要刪除 No.{row.Cells["colNo"].Value} 的 {data.Name}？", "刪除確認",
				MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

				if (confirm == DialogResult.Yes)
				{
					_repository.DeletePokemon(data.Box_id); // 從 DB 刪除
					LoadUserPokemons(); // 重新載入
				}
			}
		}
		#endregion

		private void dgvBag_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			for (int i = 0; i < dgvBag.Rows.Count; i++)
			{
				if (!dgvBag.Rows[i].IsNewRow)
					dgvBag.Rows[i].Cells["colNo"].Value = i + 1;
			}
			ResizeAdjustColumns();
		}

		private void ResizeAdjustColumns()
		{
			DataGridViewHelper.BoxAutoSizeColumnsByContent(dgvBag);
		}


		private void LoadImages() //todo:依據查詢結果動態載入圖檔
		{
			foreach (DataGridViewRow row in dgvBag.Rows)
			{
				if (row.IsNewRow) continue;

				string category = null;
				string imageFile = null;
				if (row.DataBoundItem is RecipeModel recipe)
				{
					category = recipe.category?.Trim();
					imageFile = recipe.image_url?.Trim();
				}

				string path = AssetHelper.GetRecipeImagePath(category, imageFile);

				#region 測試用 圖片輸出檢查
				//MessageBox.Show(path ?? "path=null", "Debug 2");

				// 印出全部關鍵資訊，方便比對
				//MessageBox.Show(
				//	$"category: [{category ?? "null"}]\n" +
				//	$"imageFile: [{imageFile ?? "null"}]\n" +
				//	$"path: [{path ?? "null"}]\n" +
				//	$"File.Exists(path): [{(path != null && File.Exists(path) ? "true" : "false")}]",
				//	"Debug");

				//MessageBox.Show($"category = {category ?? "null"}\nimageFile = {imageFile ?? "null"}");
				//if (path == null)
				//{
				//	MessageBox.Show($"找不到圖片路徑：\n分類={category}\n檔案={imageFile}");
				//	// 或 Console.WriteLine($"[找不到圖] {category}/{imageFile}");
				//}

				#endregion

				if (!string.IsNullOrEmpty(path) && File.Exists(path))
				{
					try
					{
						using (var img = Image.FromFile(path))
						{
							row.Cells["img"].Value = new Bitmap(img);
						}
					}
					catch (Exception ex)
					{
						row.Cells["img"].Value = null;
						Console.WriteLine($"[圖片錯誤] {category}/{imageFile}：{ex.Message}");
					}
				}
				else
				{
					row.Cells["img"].Value = null;
					Console.WriteLine($"[圖片缺失] {category}/{imageFile}");
				}
			}
		}		
	}
}
