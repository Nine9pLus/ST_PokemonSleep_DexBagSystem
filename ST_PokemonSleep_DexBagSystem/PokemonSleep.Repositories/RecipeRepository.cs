using PokemonSleep.Models;
using PokemonSleep.SecurtyInterface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSleep.Repositories
{   // v
	public class RecipeRepository : IReadOnlyRepository<RecipeModel>
	{
		private readonly string _connectionString;

		public RecipeRepository()
		{
			_connectionString = ConfigurationManager.ConnectionStrings["ST_PokemonSleep_DexBagSystem.Properties.Settings.PokemonSleepSSMSConnectionString"].ConnectionString;
		}

		public List<RecipeModel> GetAll()
		{
			var results = new List<RecipeModel>();

			string sql = "SELECT recipe_id, name, description, category, image_url FROM Recipe";

			using (var conn = new SqlConnection(_connectionString))
			using (var cmd = new SqlCommand(sql, conn))
			{
				conn.Open();
				using (var reader = cmd.ExecuteReader())    //執行SQL命令後，取得一個資料讀取器（SqlDataReader），用來逐筆讀取資料庫查詢結果。
				{
					int idxRecipeId = reader.GetOrdinal("recipe_id");    // 從查詢結果取得recipe_id欄位索引
					int idxName = reader.GetOrdinal("name");
					int idxDesc = reader.GetOrdinal("description");
					int idxCategory = reader.GetOrdinal("category");
					int idxImage = reader.GetOrdinal("image_url");

					while (reader.Read())
					{
						var model = new RecipeModel		//建立一個新的RecipeModel物件，然後從reader取得對應欄位的值
						{
							recipe_id = reader.GetInt32(idxRecipeId),		// 讀取該欄位的字串值
							name = reader.GetString(idxName),
							description = reader.GetString(idxDesc),
							category = reader.GetString(idxCategory),
							image_url = reader.GetString(idxImage)
						};
						results.Add(model);
					}
				}
			}
			return results;
		}

		// 查單筆資料
		public RecipeModel GetById(int recipe_id)
		{
			RecipeModel result = null;
			string sql = "SELECT recipe_id, name, description, category, image_url WHERE recipe_id = @recipe_id";

			using (var conn = new SqlConnection(_connectionString))
			using (var cmd = new SqlCommand(sql, conn))
			{
				cmd.Parameters.AddWithValue("@Idrecipe_id", recipe_id);
				conn.Open();

				using (var reader = cmd.ExecuteReader())
				{
					if (reader.Read())
					{
						int idxRecipeId = reader.GetOrdinal("Recipe_id");
						int idxName = reader.GetOrdinal("Name");
						int idxDesc = reader.GetOrdinal("Description");
						int idxCategory = reader.GetOrdinal("Category");
						int idxImage = reader.GetOrdinal("Image_Url");

						result = new RecipeModel
						{
							recipe_id = reader.GetInt32(idxRecipeId),
							name = reader.GetString(idxName),
							description = reader.GetString(idxDesc),
							category = reader.GetString(idxCategory),
							image_url = reader.GetString(idxImage)
						};
					}
				}
			}
			return result;
		}
	}
}
