using PokemonSleep.Models;
using PokemonSleep.SecurtyInterface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
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

		public void UpdateUser(int userId, string newAccount, string newPassword, string newUsername, string avatarFile)
		{
			List<string> setClauses = new List<string>();
			var cmd = new SqlCommand();

			if (!string.IsNullOrWhiteSpace(newAccount))
			{
				setClauses.Add("account = @account");
				cmd.Parameters.AddWithValue("@account", newAccount);
			}

			if (!string.IsNullOrWhiteSpace(newPassword))
			{
				using (var sha256 = SHA256.Create())
				{
					byte[] hashed = sha256.ComputeHash(Encoding.UTF8.GetBytes(newPassword));
					cmd.Parameters.Add("@password", SqlDbType.VarBinary, 32).Value = hashed;
					setClauses.Add("password = @password");
				}
			}

			if (!string.IsNullOrWhiteSpace(newUsername))
			{
				setClauses.Add("username = @username");
				cmd.Parameters.AddWithValue("@username", newUsername);
			}

			// avatar 是必填，不是選填
			setClauses.Add("avatarFile = @avatarFile");
			cmd.Parameters.AddWithValue("@avatarFile", avatarFile ?? "image1.png");

			if (setClauses.Count == 0) return; // 沒有任何要更新的資料

			string sql = $"UPDATE Users SET {string.Join(", ", setClauses)} WHERE user_id = @userId";
			cmd.CommandText = sql;
			cmd.Parameters.AddWithValue("@userId", userId);

			using (var conn = new SqlConnection(connectionString))
			{
				cmd.Connection = conn;
				conn.Open();
				cmd.ExecuteNonQuery();
			}
		}
		public bool IsAccountDuplicate(string account, int excludeUserId)
		{
			string sql = "SELECT COUNT(*) FROM Users WHERE account = @account AND user_id <> @userId";

			using (var conn = new SqlConnection(connectionString))
			using (var cmd = new SqlCommand(sql, conn))
			{
				cmd.Parameters.AddWithValue("@account", account);
				cmd.Parameters.AddWithValue("@userId", excludeUserId);

				conn.Open();
				int count = (int)cmd.ExecuteScalar();
				return count > 0;
			}
		}

	}
}
