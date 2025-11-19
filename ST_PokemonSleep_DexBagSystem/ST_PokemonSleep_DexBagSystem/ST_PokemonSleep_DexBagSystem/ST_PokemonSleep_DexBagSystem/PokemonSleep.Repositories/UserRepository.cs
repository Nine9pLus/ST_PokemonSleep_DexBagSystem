using PokemonSleep.Models;
using PokemonSleep.SecurtyInterface;
using System;
using System.Collections.Generic;
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
			string sql = "SELECT user_id, account, password, avatarFile FROM Users WHERE account = @account";

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
							UserId = reader.GetInt32(0),
							Account = reader.GetString(1),
							Password = reader.GetString(2),
							AvatarFile = reader.GetString(3)
						};
					}
				}
			}
			return user;
		}

		public void AddUser(UserModel user)
		{
			string sql = "INSERT INTO Users(account, password, avatarFile) VALUES(@account, @password, @avatarFile)";
			
			using (SqlConnection conn = new SqlConnection(connectionString))
			using (SqlCommand cmd = new SqlCommand(sql, conn))
			{
				cmd.Parameters.AddWithValue("@account", user.Account);
				cmd.Parameters.AddWithValue("@password", user.Password);
				cmd.Parameters.AddWithValue("@avatarFile", user.AvatarFile);
				conn.Open();
				cmd.ExecuteNonQuery();
			}
		}

		public void UpdateUser(UserModel user)
		{
			string sql = "UPDATE Users SET account = @account, password = @password, avatarFile = @avatarFile WHERE user_id = @id";
			
			using (SqlConnection conn = new SqlConnection(connectionString))
			using (SqlCommand cmd = new SqlCommand(sql, conn))
			{
				cmd.Parameters.AddWithValue("@account", user.Account);
				cmd.Parameters.AddWithValue("@password", user.Password);
				cmd.Parameters.AddWithValue("@avatarFile", user.AvatarFile);
				cmd.Parameters.AddWithValue("@id", user.UserId);
				conn.Open();
				cmd.ExecuteNonQuery();
			}
		}
	}
}
