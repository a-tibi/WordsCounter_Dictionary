using System;
using System.Collections.Generic;

namespace WordsCounter_Dictionary
{
	class Program
	{
		static void Main(string[] args)
		{
			var article = "Dot NET is a free cross-platform and open source developer platform" 
						+ "for building many different types of applications"
						+ "with Dot NET you can use multiple laguages and libraries"
						+ "to build for web and IoT";

			Dictionary<char, List<string>> wordsCounter = new Dictionary<char, List<string>>();
			foreach (var word in article.Split())
			{
				foreach (var ch in word)
				{
					
					if(!wordsCounter.ContainsKey(ch))
					{
						wordsCounter.Add(ch, new List<string> {word});
					}
					else
					{
						wordsCounter[ch].Add(word);
					}
				}
			}

			foreach (var entry in wordsCounter)
			{
				Console.Write($"{entry.Key}:");
				foreach (var word in entry.Value)
				{
					Console.WriteLine($"\t\t{word}");
				}
			}

			//foreach (var key in wordsCounter.Keys)
			//{
			//	Console.Write($"{key}:");
			//	foreach (var value in wordsCounter[key])
			//	{
			//		Console.WriteLine($"\t\t{value}");
			//	}
			//}
			Console.ReadKey();
		}
	}
}
