using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSleep.Models
{
	public class PokedexModel
	{
		public int pokedex_id { get; set; }
		public string name { get; set; }
		public string image_url { get; set; }
		public string sleep_type { get; set; }
		public string specialty { get; set; }
		public int main_skill_id { get; set; }
		public int family_id { get; set; }
	}
}
