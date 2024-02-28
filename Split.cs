using System;

namespace Split
{
	internal class Split
	{
		static void Main(string[] args)
		{
			Console.Write("Введите строку с текстом: ");

			string stringText = Console.ReadLine();

			char spaceCharacter = ' ';
			string[] subStrings = stringText.Split(spaceCharacter);

			for (int i = 0; i < subStrings.Length; i++)
			{
				Console.WriteLine(subStrings[i]);
			}
		}
	}
}
