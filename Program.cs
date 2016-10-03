using System;

namespace DnD_dice
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string die = "";
			Random rnd = new Random();
			int num = 0;
			bool keepgoing = true;

			while (keepgoing)
			{
				int count = 1;
				int sum = 0;
				int mod = 0;
				//Grab Selection From User
				Console.WriteLine("Which die would you like to roll?(d4,d6,d8,d10,d12,d20,d100)");
				Console.WriteLine("To exit type 'q'");
				die = Console.ReadLine();
				// Check for valid input
				if (die != "d4" && die != "d6" && die != "d8" && die != "d10" && die != "d12" && die != "d20" && die != "d100" && die != "q")
				{
					Console.WriteLine("That is not a valid input, please enter: d4, d6, d8, d10, d12, d20, or d100");
					die = "";
				}

				if (die != "q")
				{
					Console.WriteLine("How many would you like to roll?");
					count = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("What modifiers would you like to apply?(ex. -2)");
					mod = Convert.ToInt32(Console.ReadLine());

				}

				for (int i = 0; i < count; i++ )
				{
					switch (die)
					{
						// Generate for d4 option
						case "d4":
							{
								num = rnd.Next(1, 5);
								Console.WriteLine("---------------------------------");
								Console.WriteLine("d4 = " + num);
								Console.WriteLine("---------------------------------");
								Console.WriteLine();
								if (count > 1)
								{
									sum = sum + num;
								}
								num = 0;
								break;
							}
						// Generate for d6 option
						case "d6":
							{
								num = rnd.Next(1, 7);
								Console.WriteLine("---------------------------------");
								Console.WriteLine("d6 = " + num);
								Console.WriteLine("---------------------------------");
								Console.WriteLine();
								if (count > 1)
								{
									sum = sum + num;
								}
								num = 0;
								break;
							}
						// Generate for d8 option
						case "d8":
							{
								num = rnd.Next(1, 9);
								Console.WriteLine("---------------------------------");
								Console.WriteLine("d8 = " + num);
								Console.WriteLine("---------------------------------");
								Console.WriteLine();
								if (count > 1)
								{
									sum = sum + num;
								}
								num = 0;
								break;
							}
						// Generate for d10 option
						case "d10":
							{
								num = rnd.Next(1, 11);
								Console.WriteLine("---------------------------------");
								Console.WriteLine("d10 = " + num);
								Console.WriteLine("---------------------------------");
								Console.WriteLine();
								if (count > 1)
								{
									sum = sum + num;
								}
								num = 0;
								break;
							}
						// Generate for d12 option
						case "d12":
							{
								num = rnd.Next(1, 13);
								Console.WriteLine("---------------------------------");
								Console.WriteLine("d12 = " + num);
								Console.WriteLine("---------------------------------");
								Console.WriteLine();
								if (count > 1)
								{
									sum = sum + num;
								}
								num = 0;
								break;
							}
						// Generate for d20 option
						case "d20":
							{
								num = rnd.Next(1, 21);
								Console.WriteLine("---------------------------------");
								Console.WriteLine("d20 = " + num);
								Console.WriteLine("---------------------------------");
								Console.WriteLine();
								if (count > 1)
								{
									sum = sum + num;
								}
								num = 0;
								break;
							}
						// Generate for d100 option
						case "d100":
							{
								num = rnd.Next(1, 101);
								Console.WriteLine("---------------------------------");
								Console.WriteLine("d100 = " + num);
								Console.WriteLine("---------------------------------");
								Console.WriteLine();
								if (count > 1)
								{
									sum = sum + num;
								}
								num = 0;
								break;
							}

						// if exit command
						case "q":
							{
								Console.WriteLine("Thanks for using homemade DnD roller!");
								keepgoing = false;
								break;
							}
						default:
							{
								break;
							}
					}
				}

				if (count > 1)
				{
					sum = sum + mod;
					Console.WriteLine("Total: " + sum);
					Console.WriteLine();
				}
			}
		}
	}
}
