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
		void AddUser(UserModel user);
		void UpdateUser(int userId, string newAccount, string newPassword, string newUsername, string avatarFile);


	}
}
