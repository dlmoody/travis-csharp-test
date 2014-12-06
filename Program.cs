using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace travistest
{

	class MainClass
	{
		public static void Main (string[] args)
		{
			string json = @"['Hello World']";
			List<string> test = JsonConvert.DeserializeObject<List<string>>(json);
			Console.WriteLine (test[0]);
		}
	}
}
