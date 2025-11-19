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

		public List<RecipeModel> GetRecipesByCategory(string group)
		{
			var all = _recipeRepo.GetAll();

			switch (group)
			{
				case "咖哩、濃湯":
					return all.Where(x => x.category == "咖哩" || x.category == "濃湯").ToList();
				case "沙拉":
					return all.Where(x => x.category == "沙拉").ToList();
				case "甜點、飲料":
					return all.Where(x => x.category == "甜點" || x.category == "飲料").ToList();
				default:
					return all;
			}
		}
	}


}
