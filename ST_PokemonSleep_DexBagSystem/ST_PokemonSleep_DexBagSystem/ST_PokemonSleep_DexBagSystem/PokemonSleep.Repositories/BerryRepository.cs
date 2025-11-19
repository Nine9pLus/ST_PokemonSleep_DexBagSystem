using PokemonSleep.Models;
using PokemonSleep.SecurtyInterface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSleep.Repositories
{   // v
	public class BerryRepository : IReadOnlyRepository<BerryModel>
	{
		private readonly string _connectionString;

		public BerryRepository()
		{
			_connectionString = ConfigurationManager.ConnectionStrings["ST_PokemonSleep_DexBagSystem.Properties.Settings.PokemonSleepSSMSConnectionString"].ConnectionString;
		}

		public List<BerryModel> GetAll()
		{
			var results = new List<BerryModel>();

			string sql = "SELECT berry_id, name, type, description, image_url FROM Berries";

			using (var conn = new SqlConnection(_connectionString))
			using (var cmd = new SqlCommand(sql, conn))
			{
				conn.Open();
				using (var reader = cmd.ExecuteReader())   
				{
					int idxBerryId = reader.GetOrdinal("berry_id");   
					int idxName = reader.GetOrdinal("name");
					int idxType = reader.GetOrdinal("type");
					int idxDesc = reader.GetOrdinal("description");
					int idxImage = reader.GetOrdinal("image_url");

					while (reader.Read())
					{
						var model = new BerryModel      
						{
							berry_id = reader.GetInt32(idxBerryId),	
							name = reader.GetString(idxName),
							type = reader.GetString(idxType),
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
		public BerryModel GetById(int berry_id)
		{
			BerryModel result = null;
			string sql = "SELECT berry_id, name, type, description, image_url FROM Berries WHERE berry_id = @berry_id";

			using (var conn = new SqlConnection(_connectionString))
			using (var cmd = new SqlCommand(sql, conn))
			{
				cmd.Parameters.AddWithValue("@berry_id", berry_id);
				conn.Open();

				using (var reader = cmd.ExecuteReader())
				{
					if (reader.Read())
					{
						int idxBerryId = reader.GetOrdinal("berry_id");   
						int idxName = reader.GetOrdinal("name");
						int idxType = reader.GetOrdinal("type");
						int idxDesc = reader.GetOrdinal("description");
						int idxImage = reader.GetOrdinal("image_url");

						result = new BerryModel
						{
							berry_id = reader.GetInt32(idxBerryId),    
							name = reader.GetString(idxName),
							type = reader.GetString(idxType),
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
