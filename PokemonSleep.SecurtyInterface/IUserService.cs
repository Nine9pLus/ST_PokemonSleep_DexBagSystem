using PokemonSleep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSleep.SecurtyInterface
{
	public interface IUserService
	{
		bool Login(string account, string password, out UserModel user);
		UserModel GetUserByAccount(string account);
	}

}
