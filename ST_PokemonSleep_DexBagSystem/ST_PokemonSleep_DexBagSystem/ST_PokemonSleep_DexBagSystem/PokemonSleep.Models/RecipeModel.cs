using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSleep.Models
{
	public class RecipeModel	//食譜
	{
		public int recipe_id { get; set; }
		public string name { get; set; }
		public string description { get; set; }
		public string category { get; set; }	// "咖哩/濃湯"、"沙拉"、"甜點/飲料"
		public string image_url { get; set; }

	}
}
