using PokemonSleep.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST_PokemonSleep_DexBagSystem
{
	public partial class UcBrowserPage : UserControl
	{
		
		public UcBrowserPage()
		{
			InitializeComponent();

			btnShowCurrySoup.Click += CategoryButton_Click;
			btnShowSalad.Click += CategoryButton_Click;
			btnShowDessertDrink.Click += CategoryButton_Click;

			// 預設載入第一類
			LoadCategory("咖哩、濃湯");
		}

		private void UcBrowserSection_Load(object sender, EventArgs e)
		{
			dgvBrowseResult_Resize(sender, e);  // 自動調dgv寬度
		}
		
		private BrowseService _browseService = new BrowseService();

		private void CategoryButton_Click(object sender, EventArgs e)
		{
			if (sender is Button btn && btn.Tag is string group)
				LoadCategory(group);
		}
		private void LoadCategory(string group)
		{
			// 刷新資料來源
			dgvBrowseResult.DataSource = _browseService.GetRecipesByCategory(group);

			// 切換按鈕狀態：目前分類的按鈕設為 Disabled（無法再點），其餘 Enabled
			foreach (Control ctrl in flpCategoryBar.Controls)
			{
				if (ctrl is Button btn)
				{
					btn.Enabled = btn.Tag.ToString() != group;
				}
			}
		}

		private void dgvBrowseResult_Resize(object sender, EventArgs e)  // 自動調dgv寬度
		{
			int ColumnCount = dgvBrowseResult.ColumnCount;
			int With = dgvBrowseResult.Width - 60;
			foreach (DataGridViewColumn column in dgvBrowseResult.Columns)
			{
				column.Width = With / ColumnCount;
			}
		}
	}
}
