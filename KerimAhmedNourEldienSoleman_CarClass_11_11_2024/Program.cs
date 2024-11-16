using System;

namespace CarFactorySimulator
{
	class Car
	{
		public string Name { get; set; }
		public int Wheels { get; set; }
		public string EngineType { get; set; }
		public string Type { get; set; }

		public Car(string name, int wheels, string engineType, string type)
		{
			Name = name;
			Wheels = wheels;
			EngineType = engineType;
			Type = type;
		}

		public void DisplayCarInfo()
		{
			Console.WriteLine($"\nCar Name: {Name}");
			Console.WriteLine($"Wheels: {Wheels}");
			Console.WriteLine($"Engine: {EngineType}");
			Console.WriteLine($"Type: {Type}\n");
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to the Car Factory Simulator made by Kerim!");

			Console.Write("Enter the name of your car: ");
			string name = Console.ReadLine();

			int wheels = GetValidWheels();

			Console.Write("Choose engine type (Sporty, Stock, Luxury): ");
			string engineType = Console.ReadLine();

			Console.Write("Choose car type (Sporty, Stock, Luxury): ");
			string type = Console.ReadLine();

			Car newCar = new Car(name, wheels, engineType, type);
			newCar.DisplayCarInfo();

			Console.WriteLine("Thank you for trying the Car Factory Simulator!");
		}

		static int GetValidWheels()
		{
			int wheels;
			do
			{
				Console.Write("Enter the number of wheels (0-6): ");
				string input = Console.ReadLine();

				if (int.TryParse(input, out wheels) && wheels >= 0 && wheels <= 6)
				{
					return wheels;
				}
				else
				{
					Console.WriteLine("Impossible values detected, try again the wheel number from 0-6");
				}
			} while (true);
		}
	}
}