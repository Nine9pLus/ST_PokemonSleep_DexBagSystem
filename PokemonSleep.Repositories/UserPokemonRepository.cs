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
	public class UserPokemonRepository
	{
		private readonly string _connectionString;

		public UserPokemonRepository()
		{
			_connectionString = ConfigurationManager.ConnectionStrings["ST_PokemonSleep_DexBagSystem.Properties.Settings.PokemonSleepSSMSConnectionString"].ConnectionString;
		}

		public List<UserPokemonModel> GetUserPokemons(int userId)
		{
			var list = new List<UserPokemonModel>();

			string sql = @"
		SELECT 
			up.Box_id,
			up.User_id,
			up.Pokedex_id,
			p.Name,
			up.Custom_name,
			up.Level,
			up.Evolution_count
		FROM UserPokemon up
		JOIN Pokedex p ON up.Pokedex_id = p.Pokedex_id
		WHERE up.User_id = @User_id";

			using (var conn = new SqlConnection(_connectionString))
			using (var cmd = new SqlCommand(sql, conn))
			{
				cmd.Parameters.AddWithValue("@User_id", userId);
				conn.Open();

				using (var reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						list.Add(new UserPokemonModel
						{
							Box_id = reader.GetInt32(0),
							User_id = reader.GetInt32(1),
							Pokedex_id = reader.GetInt32(2),
							Name = reader.GetString(3),
							Custom_name = reader.IsDBNull(4) ? null : reader.GetString(4),
							Level = reader.GetInt32(5),
							Evolution_count = reader.GetInt32(6)
						});
					}
				}
			}
			return list;
		}

		public void InsertUserPokemon(UserPokemonModel model)
		{
			string sql = @"
		INSERT INTO UserPokemon (User_id, Pokedex_id, Custom_name, Level, Evolution_count)
		VALUES (@User_id, @Pokedex_id, @Custom_name, @Level, @Evolution_count)";

			using (SqlConnection conn = new SqlConnection(_connectionString))
			using (SqlCommand cmd = new SqlCommand(sql, conn))
			{
				cmd.Parameters.AddWithValue("@User_id", model.User_id);
				cmd.Parameters.AddWithValue("@Pokedex_id", model.Pokedex_id);
				cmd.Parameters.AddWithValue("@Custom_name", (object)model.Custom_name ?? DBNull.Value);
				cmd.Parameters.AddWithValue("@Level", model.Level);
				cmd.Parameters.AddWithValue("@Evolution_count", model.Evolution_count);

				conn.Open();
				cmd.ExecuteNonQuery();
			}
		}

		public void DeletePokemon(int boxId)
		{
			string sql = "DELETE FROM UserPokemon WHERE Box_id = @Box_id";
			using (SqlConnection conn = new SqlConnection(_connectionString))
			using (SqlCommand cmd = new SqlCommand(sql, conn))
			{
				cmd.Parameters.AddWithValue("@Box_id", boxId);
				conn.Open();
				cmd.ExecuteNonQuery();
			}
		}

		public void UpdatePokemon(UserPokemonModel model)
		{
			string sql = @"
		UPDATE UserPokemon
		SET Custom_name = @Custom_name,
			Level = @Level,
			Evolution_count = @Evolution_count
		WHERE Box_id = @Box_id";

			using (SqlConnection conn = new SqlConnection(_connectionString))
			using (SqlCommand cmd = new SqlCommand(sql, conn))
			{
				cmd.Parameters.AddWithValue("@Custom_name", (object)model.Custom_name ?? DBNull.Value);
				cmd.Parameters.AddWithValue("@Level", model.Level);
				cmd.Parameters.AddWithValue("@Evolution_count", model.Evolution_count);
				cmd.Parameters.AddWithValue("@Box_id", model.Box_id);

				conn.Open();
				cmd.ExecuteNonQuery();
			}
		}

	}
}
