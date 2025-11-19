using PokemonSleep.Models;
using PokemonSleep.Repositories;
using PokemonSleep.SecurtyInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSleep.Service
{
	public class BrowseService
	{

		private readonly IReadOnlyRepository<RecipeModel> _recipeRepo = new RecipeRepository();

		public List<RecipeModel> GetRecipesByCategory(string category)
		{
			var all = _recipeRepo.GetAll();
			return all.Where(x => x.category == category).ToList();
		}
	}


}
