using PokemonSleep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSleep.SecurtyInterface
{
	public interface IReadOnlyRepository<T>
	{
		List<T> GetAll();
		T GetById(int id);
	}
}
