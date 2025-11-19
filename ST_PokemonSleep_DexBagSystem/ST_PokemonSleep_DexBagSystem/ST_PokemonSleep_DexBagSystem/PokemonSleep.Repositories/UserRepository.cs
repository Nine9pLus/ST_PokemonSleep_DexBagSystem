using PokemonSleep.Models;
using PokemonSleep.SecurtyInterface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSleep.Service    // 資料存取實作（Repository 層）
								  // 純資料存取，實作 interface 資料來源
{
	public class UserRepository : IUserRepository
	// 資料存取層
	{
		private readonly string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=PokemonSleepSSMS;Integrated Security=True";

		public UserModel GetUserByCredentials(string account)
		{
			UserModel user = null;
			string sql = "SELECT user_id, account, password, avatarFile, username FROM Users WHERE account = @account";

			using (SqlConnection conn = new SqlConnection(connectionString))
			using (SqlCommand cmd = new SqlCommand(sql, conn))
			{
				cmd.Parameters.AddWithValue("@account", account);

				conn.Open();
				using (SqlDataReader reader = cmd.ExecuteReader())
				{
					if (reader.Read())
					{
						user = new UserModel
						{
							UserId = reader.GetInt32(reader.GetOrdinal("user_id")),
							Account = reader.GetString(reader.GetOrdinal("account")),
							PasswordHash = (byte[])reader["password"],
							AvatarFile = reader.IsDBNull(reader.GetOrdinal("avatarFile")) ? null : reader.GetString(reader.GetOrdinal("avatarFile")),
							Username = reader.IsDBNull(reader.GetOrdinal("username")) ? "訓練家" : reader.GetString(reader.GetOrdinal("username"))
						};
					}
				}
			}
			return user;
		}

		public void AddUser(UserModel user)
		{
			string sql = @"INSERT INTO Users (account, password, avatarFile, username)
	               VALUES (@account, @password, @avatarFile, @username)";

			using (SqlConnection conn = new SqlConnection(connectionString))
			using (SqlCommand cmd = new SqlCommand(sql, conn))
			{
				cmd.Parameters.AddWithValue("@account", user.Account);
				cmd.Parameters.Add("@password", SqlDbType.VarBinary, 32).Value = user.PasswordHash;
				cmd.Parameters.AddWithValue("@avatarFile", user.AvatarFile ?? "image1.png");
				cmd.Parameters.AddWithValue("@username", user.Username ?? "訓練家");
				conn.Open();
				cmd.ExecuteNonQuery();
			}
		}

		public void UpdateUser(UserModel user)
		{
			string sql = "SELECT user_id, account, password, avatarFile, username FROM Users WHERE account = @account";

			using (SqlConnection conn = new SqlConnection(connectionString))
			using (SqlCommand cmd = new SqlCommand(sql, conn))
			{
				cmd.Parameters.AddWithValue("@account", user.Account);
				cmd.Parameters.Add("@password", SqlDbType.VarBinary, 32).Value = user.PasswordHash;
				cmd.Parameters.AddWithValue("@avatarFile", user.AvatarFile ?? "image1.png");
				cmd.Parameters.AddWithValue("@username", user.Username ?? "訓練家");
				cmd.Parameters.AddWithValue("@id", user.UserId);
				conn.Open();
				cmd.ExecuteNonQuery();
			}
		}
	}
}
