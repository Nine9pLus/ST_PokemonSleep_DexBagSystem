using PokemonSleep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSleep.SecurtyInterface
{
	public interface IAuth    // 驗證登入邏輯
	{	
		bool Login(string username, string password, out UserModel user, out string avatarFile);
		// 嘗試登入，成功回傳 true 和 UserModel 結果
	}
}
