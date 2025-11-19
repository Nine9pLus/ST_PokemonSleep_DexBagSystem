using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSleep.Models
{
	public class UserPokemonModel
	{
		//TABLE UserPokemon (              -- 使用者背包表
		public int Box_id { get; set; }				// 主鍵
		public int User_id { get; set; }            // 用戶ID，外鍵
		public int Pokedex_id { get; set; }         // Pokédex主表編號，寶可夢編號
		public string Name { get; set; }			// 官方名稱
		public string Custom_name { get; set; }     // 玩家自訂名稱
		public int Level { get; set; }				// 等級
		public int Evolution_count { get; set; }    // 進化次數

		// 唯讀。顯示名稱: 若有自訂，就用自訂，否則用官方
		public string DisplayName => !string.IsNullOrWhiteSpace(Custom_name) ? Custom_name : Name;

	}
}