using PokemonSleep.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSleep.Repositories
{
	public class DexRepository
	{
		private readonly string _connectionString;

		public DexRepository()
		{
			_connectionString = ConfigurationManager.ConnectionStrings["ST_PokemonSleep_DexBagSystem.Properties.Settings.PokemonSleepSSMSConnectionString"].ConnectionString;
		}

		public List<PokedexModel> GetAll()
		{
			var list = new List<PokedexModel>();
			string sql = @"SELECT Pokedex_id, Name FROM Pokedex ORDER BY Pokedex_id";

			using (SqlConnection conn = new SqlConnection(_connectionString))
			using (SqlCommand cmd = new SqlCommand(sql, conn))
			{
				conn.Open();
				using (SqlDataReader reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						list.Add(new PokedexModel
						{
							Pokedex_id = reader.GetInt32(0),
							Name = reader.GetString(1)
						});
					}
				}
			}
			return list;
		}
	}
}
