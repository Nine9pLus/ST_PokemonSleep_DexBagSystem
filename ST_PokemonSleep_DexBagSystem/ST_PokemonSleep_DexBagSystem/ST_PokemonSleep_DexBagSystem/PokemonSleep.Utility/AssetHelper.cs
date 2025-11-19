using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSleep.Utility
{
	public static class AssetHelper
	{
		private static readonly string BaseDir = AppDomain.CurrentDomain.BaseDirectory;
		private static readonly string AvatarFolder = Path.Combine(BaseDir, "image", "avatar");

		private static readonly string DefaultAvatarFile = "image1.png";

		/// <summary>
		/// 傳入avatar頭像檔名（.png），回傳對應絕對路徑，找不到則 fallback。
		/// </summary>
		public static string GetAvatarPath(string avatarFile)
		{
			string fileName = string.IsNullOrEmpty(avatarFile) ? DefaultAvatarFile : avatarFile;
			string path = Path.Combine(AvatarFolder, fileName);

			if (File.Exists(path))
			{
				return path;
			}

			// fallback 判斷
			string fallback = Path.Combine(AvatarFolder, DefaultAvatarFile);
			return File.Exists(fallback) ? fallback : null;
		}

		/// <summary>
		/// 回傳預設頭像檔名
		/// </summary>
		/// <returns></returns>
		public static string GetDefaultAvatarFileName()
		{
			return DefaultAvatarFile;
		}


		public static string GetRecipeImagePath(string category, string imageFile)
		{
			if (string.IsNullOrEmpty(category) || string.IsNullOrEmpty(imageFile))
				return null;

			string basePath = AppDomain.CurrentDomain.BaseDirectory;
			string recipePath = Path.Combine(basePath, "image", "Recipe", category, imageFile);

			return File.Exists(recipePath) ? recipePath : null;

			#region 測試用
			//string baseFolder = AppDomain.CurrentDomain.BaseDirectory;
			//string imagePath = Path.Combine(baseFolder, "image", "Recipe", category, imageFile);
			//return File.Exists(imagePath) ? imagePath : null;
			#endregion
		}
	}
}