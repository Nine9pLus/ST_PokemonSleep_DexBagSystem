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
{	// v
	public class IngredientRepository : IReadOnlyRepository<IngredientModel>
	{
		private readonly string _connectionString = ConfigurationManager.ConnectionStrings["ST_PokemonSleep_DexBagSystem.Properties.Settings.PokemonSleepSSMSConnectionString"].ConnectionString;

		public List<IngredientModel> GetAll()
		{
			var results = new List<IngredientModel>();

			string sql = "SELECT ingredient_id, name, description, image_url FROM Ingredients";

			using (var conn = new SqlConnection(_connectionString))
			using (var cmd = new SqlCommand(sql, conn))
			{
				conn.Open();
				using (var reader = cmd.ExecuteReader())   
				{
					int idxIngredientid = reader.GetOrdinal("ingredient_id");    
					int idxName = reader.GetOrdinal("name");
					int idxDesc = reader.GetOrdinal("description");
					int idxImage = reader.GetOrdinal("image_url");

					while (reader.Read())
					{
						var model = new IngredientModel      
						{
							ingredient_id = reader.GetInt32(idxIngredientid),  
							name = reader.GetString(idxName),
							description = reader.GetString(idxDesc),
							image_url = reader.GetString(idxImage)
						};
						results.Add(model);
					}
				}
			}
			return results;
		}

		// 查單筆資料
		public IngredientModel GetById(int ingredient_id)
		{
			IngredientModel result = null;
			string sql = "SELECT ingredient_id, name, description, image_url FROM Ingredients WHERE ingredient_id = @ingredient_id";

			using (var conn = new SqlConnection(_connectionString))
			using (var cmd = new SqlCommand(sql, conn))
			{
				cmd.Parameters.AddWithValue("@ingredient_id", ingredient_id);
				conn.Open();

				using (var reader = cmd.ExecuteReader())
				{
					if (reader.Read())
					{
						int idxIngredientid = reader.GetOrdinal("ingredient_id");
						int idxName = reader.GetOrdinal("name");
						int idxDesc = reader.GetOrdinal("description");
						int idxImage = reader.GetOrdinal("image_url");

						result = new IngredientModel
						{
							ingredient_id = reader.GetInt32(idxIngredientid),
							name = reader.GetString(idxName),
							description = reader.GetString(idxDesc),
							image_url = reader.GetString(idxImage)
						};
					}
				}
			}
			return result;
		}
	}

}
