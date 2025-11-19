using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSleep.Models   //資料模型
{
	public class UserModel
	{
		public int UserId { get; set; }		// -- 用戶唯一ID
		public string Account { get; set; }		// -- 登入用帳號
		public byte[] PasswordHash { get; set; }    // -- 密碼 (SHA-256 雜湊處理
		public string AvatarFile { get; set; }	// -- 頭像檔名
		public string Username { get; set; }    // -- 顯示用戶暱稱 -- DEFAULT N'訓練家'
	}
}
