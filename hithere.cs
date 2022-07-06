using System;

namespace Simple
{

	class Program
	{
		static void Main()
		{
			// int var1=3;
			// int var2=6;
			// Console.WriteLine($"Two sample integers are {var1} and {var2}");
			//--格式化数字字符串--:C
			Console.WriteLine("The value:{0}.",500);
			Console.WriteLine("The value:{0:C}.",500);
			//--使用字符串插值--
			int myInt = 500;
			Console.WriteLine($"The value:{myInt}.");
			Console.WriteLine($"The value:{myInt:C}.");
			//--使用对齐说明符--
			Console.WriteLine("|{0,10}|",myInt);
			Console.WriteLine("|{0,-10}|",myInt);
		}
	}
}