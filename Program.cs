using System;

namespace museum1978
{
	class Program
	{
		static void Main(string[] args)
		{
			string currentRoom = "Entrance";
			string selection;
			// Entrance -> Hall A, Cafe, Hall B, WC
			// Hall A -> Entrance, Cafe
			// Cafe -> Gift Shop, Entrance, Hall A
			// Gift Shop -> Cafe
			// WC -> Entrance
			// Hall B -> Entrance

			while (true)
			{
				string reminderRoom = "\nYou are now at the " + currentRoom + ", what would you like to do?";

				// Entrance
				if (currentRoom == "Entrance")
				{
					Console.WriteLine(reminderRoom);
					Console.WriteLine("1) Exhibition Hall 1\n2) Exhibition Hall 2\n3) Cafe\n4) WC\n5) Leave museum\n\nA) Examine Salt Sculpture\nB) Look at Cigars");
					
					selection = Console.ReadLine();

					if (selection == "1") // Go to line 75
					{
						currentRoom = "Exhibition Hall 1";
					}

					else if (selection == "2") // Go to line 105
					{
						currentRoom = "Exhibition Hall 2";
					}

					else if (selection == "3") // Go to line 133
					{
						currentRoom = "Cafe";
					}

					else if (selection == "4") // Go to line 180
					{
						currentRoom = "WC";
					}

					else if (selection == "5")
					{
						Console.WriteLine("Leaving the museum...");
						System.Threading.Thread.Sleep(2000);
						break;
					}

					else if (selection == "A")
					{
						Console.WriteLine("\nYou examine the salt sculpture. What a view.");
						currentRoom = "Entrance";
					}

					else if (selection == "B")
					{
						Console.WriteLine("\nYou take a look at the cigars. Smoking.");
						currentRoom = "Entrance";
					}
				}
				// Entrance done

				// Exhibition Hall 1
				else if (currentRoom == "Exhibition Hall 1")
				{
					Console.WriteLine(reminderRoom);
					Console.WriteLine("1) Entrance\n2) Cafe\n\nA) Look at Saltwater Evaporate");
					
					selection = Console.ReadLine();

					if (selection == "1") // Go to line 22
					{
						currentRoom = "Entrance";
					}

					if (selection == "2") // Go to line 133
					{
						currentRoom = "Cafe";
					}

					else if (selection == "A")
					{
						Console.WriteLine("\nYou have a look at Saltwater Evaporating. Super interesting...");
					}
				}

				// Exhibition Hall 1 done

				// Exhibition Hall 2
				else if (currentRoom == "Exhibition Hall 2")
				{
					Console.WriteLine(reminderRoom);
					Console.WriteLine("1) Entrance\n\nA) Pipes\nB) Pictures of Himalaya");

					selection = Console.ReadLine();

					if (selection == "1") // Go to line 22
					{
						currentRoom = "Entrance";
					}

					else if (selection == "A") 
					{
						Console.WriteLine("\nYou check out the pipes.");
					}

					else if (selection == "B")
					{
						Console.WriteLine("\nYou walk over to the pictures of Himalaya. Astonishing.");
					}
				}
				// Exhibition Hall 2 done

				// Cafe
				else if (currentRoom == "Cafe")
				{
					Console.WriteLine(reminderRoom);
					Console.WriteLine("\n1) Entrance\n2) Exhibition Hall 1\n3) Gift Shop");

					selection = Console.ReadLine();

					if (selection == "1") // Go to line 22
					{
						currentRoom = "Entrance";
					}

					else if (selection == "2") // Go to line 75
					{
						currentRoom = "Exhibition Hall 1";
					}

					else if (selection == "3") // Go to line 161
					{
						currentRoom = "Gift Shop";
					}
				}
				// Cafe done

				// Gift Shop
				else if (currentRoom == "Gift Shop")
				{
					Console.WriteLine(reminderRoom);
					Console.WriteLine("\n1) Cafe");

					selection = Console.ReadLine();

					if (selection == "1") // Go to line 133
					{
						currentRoom = "Cafe";
					}
				}
				// Gift Shop done

				// WC
				else if (currentRoom == "WC")
				{
					Console.WriteLine(reminderRoom);
					Console.WriteLine("\n1) Entrance");

					selection = Console.ReadLine();

					if (selection == "1") // Go to line 22
					{
						currentRoom = "Entrance";
					}
				}
				// WC done
			}
		}
	}
}