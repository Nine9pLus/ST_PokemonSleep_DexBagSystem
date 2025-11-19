using PokemonSleep.Models;
using PokemonSleep.SecurtyInterface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSleep.Service  // 商業邏輯（Service 層）
								// 放商業邏輯服務本身，如 AuthService
{
    public class AuthService : IAuth
	{
		public bool Login(string account, string password, out UserModel user, out string avatarFile)
		{
			user = null; // 尚未登入/查表前無值
			avatarFile = "image1.png"; // 預設頭像1

			string connectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=PokemonSleepSSMS;Integrated Security=True;";
			string sql = "SELECT account, avatarFile FROM Users WHERE account = @account AND password = @password";

			using (SqlConnection conn = new SqlConnection(connectionString))
			using (SqlCommand cmd = new SqlCommand(sql, conn))              
			{
				cmd.Parameters.AddWithValue("@account", account); 
				cmd.Parameters.AddWithValue("@password", password); 

				conn.Open();

				using (SqlDataReader reader = cmd.ExecuteReader()) // 會回傳一個SqlDataReader物件（資料列的結果串流），需要用reader.Read()來逐行讀取資料。
				{
					if (reader.Read())  // 如果有讀到資料，表示登入成功 //嘗試「讀取下一筆資料」，若有資料列回傳，就進入 if 區塊。
					{
						user = new UserModel();
						user.Account = reader.GetString(0); // 取得用戶名稱	// 取得第一欄account的字串資料
						avatarFile = reader.GetString(1);  // 取得頭像檔名 	// 取得第二欄avatarFile的字串資料
						return true;
					}
				}
			}
			return false;
		}		
	}
}
