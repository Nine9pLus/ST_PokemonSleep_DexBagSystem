using PokemonSleep.Models;
using PokemonSleep.SecurtyInterface;
using PokemonSleep.Utility;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonSleep.Service  // 商業邏輯（Service 層）
								// 放商業邏輯服務本身，如 AuthService
{
	public class AuthService : IAuth    //做「帳號密碼比對」與回傳 UserModel 等「登入會用到的資料」
	{
		public bool Login(string account, string password, out UserModel user, out string avatarFile)
		{
			user = null; // 尚未登入/查表前無值
			avatarFile = null;

			string connectionString = ConfigurationManager.ConnectionStrings["ST_PokemonSleep_DexBagSystem.Properties.Settings.PokemonSleepSSMSConnectionString"].ConnectionString;
			string sql = "SELECT account, avatarFile, username  FROM Users WHERE account = @account AND password = @password";

			using (SHA256 sha256 = SHA256.Create())
			using (SqlConnection conn = new SqlConnection(connectionString))
			using (SqlCommand cmd = new SqlCommand(sql, conn))
			{
				byte[] hashedPassword = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

				cmd.Parameters.AddWithValue("@account", account);
				cmd.Parameters.Add("@password", SqlDbType.VarBinary, 32).Value = hashedPassword;

				conn.Open();

				#region 測試用 顯示目前連線的資料庫名
				//string realDb = conn.Database;
				//MessageBox.Show("目前程式連線的實際資料庫為：" + realDb);
				#endregion

				using (SqlDataReader reader = cmd.ExecuteReader()) 
				{
					if (reader.Read())  // 如果有讀到資料，表示登入成功
					{
						user = new UserModel
						{
							Account = reader.GetString(0),
							Username = reader.IsDBNull(2) ? "訓練家" : reader.GetString(2)
						};

						// 使用 AssetHelper 組成圖片實體路徑字串
						string avatarFileName = reader.IsDBNull(1) ? "image1.png" : reader.GetString(1);
						avatarFile = AssetHelper.GetAvatarPath(avatarFileName);

						return true; // 登入成功
					}
				}
			}
			return false; // 登入失敗
		}
	}
}
