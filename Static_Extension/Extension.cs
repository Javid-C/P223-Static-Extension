using System;
using System.Collections.Generic;
using System.Text;

namespace Static_Extension
{
	static class Extension
	{
		public static bool CustomContain(this string str,char letter)
		{
			foreach (var item in str)
			{
				if (item.ToString().ToLower() == letter.ToString().ToLower())
				{
					return true;
				}
			}
			return false;
		}

		public static string Capitalized(this string str)
		{
			string capitalized = char.ToUpper(str[0]).ToString();

			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(capitalized);

			for (int i = 1; i < str.Length; i++)
			{
				stringBuilder.Append(str[i]);
			}
			return stringBuilder.ToString();
		}
	}
}
