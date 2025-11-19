using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSleep.Models
{
	public class PokedexModel
	{
		public int Pokedex_id { get; set; }
		public string Name { get; set; }
		public string Image_url { get; set; }
		public string Sleep_type { get; set; }
		public string Specialty { get; set; }
		public int Main_skill_id { get; set; }
		public int Family_id { get; set; }

		public override string ToString()
		{
			return $"{Pokedex_id:D3} - {Name}";
		}
	}
}

