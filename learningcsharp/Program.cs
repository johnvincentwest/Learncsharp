using System;

namespace learningcsharp
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			Console.WriteLine("Hello this is my trying to learn C#");
			Console.WriteLine("Hope this helps me document my learnings");
			Console.WriteLine("I am also quite new to GitHub");

			Console.WriteLine("What is your first name?");
			string firstName = Console.ReadLine();
			Console.WriteLine("First name: " + firstName);
			Console.WriteLine("What is your last name?");
			string lastName = Console.ReadLine();
			Console.WriteLine("Last name: " + lastName);
			Console.WriteLine("Your full name is " + firstName + " " + lastName);
		}
	}
}
