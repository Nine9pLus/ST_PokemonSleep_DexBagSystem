using PokemonSleep.Models;
using PokemonSleep.SecurtyInterface;
using PokemonSleep.Utility;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSleep.Service
{
	public class UserService : IUserService
	{
		private readonly string _connectionString;

		public UserService()
		{
			_connectionString = ConfigurationManager
				.ConnectionStrings["ST_PokemonSleep_DexBagSystem.Properties.Settings.PokemonSleepSSMSConnectionString"]
				?.ConnectionString
				?? throw new Exception("找不到資料庫連線字串！");
		}

		/// <summary>
		/// 驗證帳密是否正確，並回傳使用者資料與頭像路徑
		/// </summary>
		public bool Login(string account, string password, out UserModel user)
		{
			user = null;

			string sql = @"
SELECT user_id, account, username, avatarFile 
FROM Users
WHERE account = @account AND password = @password";

			using (var conn = new SqlConnection(_connectionString))
			using (var cmd = new SqlCommand(sql, conn))
			using (SHA256 sha256 = SHA256.Create())
			{
				byte[] hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

				cmd.Parameters.AddWithValue("@account", account);
				cmd.Parameters.Add("@password", SqlDbType.VarBinary, 32).Value = hash;

				conn.Open();
				using (var reader = cmd.ExecuteReader())
				{
					if (reader.Read())
					{
						user = new UserModel
						{
							UserId = reader.GetInt32(0),
							Account = reader.GetString(1),
							Username = reader.IsDBNull(2) ? "訓練家" : reader.GetString(2),
							AvatarFile = AssetHelper.GetAvatarPath(reader.IsDBNull(3) ? null : reader.GetString(3))
						};
						return true;
					}
				}
			}

			return false;
		}

		/// <summary>
		/// 取得使用者基本資料（不含密碼驗證）
		/// </summary>
		public UserModel GetUserByAccount(string account)
		{
			string sql = "SELECT user_id, username, avatarFile FROM Users WHERE account = @account";

			using (var conn = new SqlConnection(_connectionString))
			using (var cmd = new SqlCommand(sql, conn))
			{
				cmd.Parameters.AddWithValue("@account", account);

				conn.Open();
				using (var reader = cmd.ExecuteReader())
				{
					if (reader.Read())
					{
						return new UserModel
						{
							UserId = reader.GetInt32(0),
							Account = account,
							Username = reader.IsDBNull(1) ? "訓練家" : reader.GetString(1),
							AvatarFile = AssetHelper.GetAvatarPath(reader.IsDBNull(2) ? null : reader.GetString(2))
						};
					}
				}
			}
			return null;
		}
	}
}
