using PokemonSleep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSleep.SecurtyInterface
{
	public interface IUserRepository  // 對資料庫做 CRUD 操作
	{
		UserModel GetUserByCredentials(string account);
		// 登入查詢/用帳號查使用者（登入）

		void AddUser(UserModel user);
		// 新增使用者（註冊）

		void UpdateUser(UserModel user);
		// 更新使用者資料（修改個人資料）


	}
}
