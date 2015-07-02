using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace travistest
{

	class MainClass
	{
		public static void Main (string[] args)
		{
			string json = @"['Hello David Moody!']";
			List<string> test = JsonConvert.DeserializeObject<List<string>>(json);
			Console.WriteLine (test[0]);
		}
	}
}
