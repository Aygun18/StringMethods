using System.Globalization;
using static System.Net.Mime.MediaTypeNames;

namespace StringMethods
{
	internal class Program
	{
		static void Main(string[] args)
		{


            Console.WriteLine("Task1: ");
            Text("Hello world");


			Console.WriteLine("Task2: ");
			Text1("b::c::s");
			
			Console.WriteLine("Task3: ");

			Text2("a b,c.d/e");
			Console.WriteLine("Task4:");

			Text3("banana");
			Console.WriteLine(" ");
			Console.WriteLine("Task5: ");

			Console.WriteLine(Text4("raddr"));


		}

		static void Text(string text)
		{
			string result = "";
			for (int i = text.Length - 1; i >= 0; i--)
			{
				result += text[i];
			}
			Console.WriteLine(char.ToUpper(result[0]) + result.Substring(1).ToLower());

		}
		static void Text1(string text)
		{
			string remove = "::";
			string[] arr = text.Split(remove,StringSplitOptions.RemoveEmptyEntries);
			foreach (string item in arr)
			{
                Console.WriteLine(item);
            }
			
        }
		static void Text2(string text)
		{
			string[] remove = {" ", ",", ".", "/" };
			string[] arr=text.Split(remove, StringSplitOptions.RemoveEmptyEntries);
			foreach (var item in arr)
			{
                Console.WriteLine(item);
            }
		}
		static void Text3(string text)
		{
			string remove = "a";
			string[] arr = text.Split(remove, StringSplitOptions.RemoveEmptyEntries);
			foreach (string item in arr)
			{
				Console.Write(item);
			}
		}
		static bool Text4(string text)
		{

			for (int i = 0; i < text.Length/2; i++)
			{
				if (text[i] != text[text.Length-i-1])
				{
					
					return false;
				}
			}
			return true;
			
		}

		

	}
}