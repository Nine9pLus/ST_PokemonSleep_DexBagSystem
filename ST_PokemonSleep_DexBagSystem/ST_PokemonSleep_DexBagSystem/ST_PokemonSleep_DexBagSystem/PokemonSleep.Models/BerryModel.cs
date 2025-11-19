using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSleep.Models
{
	public class BerryModel
	{
		public int berry_id { get; set; }
		public string name { get; set; }
		public string type { get; set; }
		public string description { get; set; }
		public string image_url { get; set; }
	}
}
