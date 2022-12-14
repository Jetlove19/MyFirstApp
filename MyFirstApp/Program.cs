using System;

namespace MyFirstApp
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			///Задание 3.2.4
			///Задание 3.2.3
			string myName = "Любовь";

			Console.WriteLine(myName);

			string name2 = "Jane";
			Console.WriteLine(name2);
			Console.WriteLine("\t Привет, мир \n \t Мне 27 лет \n \t My name is \n Jane");

			Console.WriteLine("Привет, \n мир!");
			///Задание 3.2.8
			Console.WriteLine("\u0023");
			Console.ReadKey();

			///Задание 3.3.2
			string name = "Jane";
			byte age = 27;
			bool pet = true;
			double shoe = 37.5;

			Console.WriteLine("My name is " + name);
			Console.WriteLine("My Age " + age);
			Console.WriteLine("Do I have a pet? " + pet);
			Console.WriteLine("My shoe size is " + shoe);



			Console.WriteLine("IntMin {0} ", int.MinValue);
			Console.WriteLine("IntMax {0} ", int.MaxValue);
			Console.WriteLine("ByteMin {0} ", byte.MinValue);
			Console.WriteLine("ShortMin {0} ", short.MinValue);
			Console.WriteLine("DecimalMin {0} ", decimal.MinValue);
			Console.WriteLine("DoubleMax {0} ", double.MaxValue);

			double result = 5.0 / 2.0;
			Console.WriteLine("5 / 2 = {0}", result);
			
			///Задание 3.6.8
			double result2 = 10 % 3;
            Console.WriteLine("10 % 3 = {0}", result2);
            Console.WriteLine("{0}", result2);

            Console.WriteLine("Enter your name");
			string nik = Console.ReadLine();
            Console.WriteLine("Enter your age");
			int years = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your favourite day of week?");
			string dayofweek = Console.ReadLine();
			Console.WriteLine("Your favourite day is {0}", dayofweek);

            ///Задание с анкетой
            Console.WriteLine("Enter your name: ");
			var nameof = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
			var yourage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your birthdate: ");
			var birthday = Console.ReadLine();
            Console.WriteLine("Your birthdate is {0}", birthday);
		}
     

			///Задание 3.4.3
		enum Semaphore
		{
			Red = 100,
			Yellow = 200,
			Green = 300
		}

		
	}

}
