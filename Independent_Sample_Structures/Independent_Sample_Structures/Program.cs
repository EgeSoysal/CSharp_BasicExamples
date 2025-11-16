#region Weather Selector Example 
//char weather;

//Console.Write("Enter today's weather code (S for Sunny, R for Rainy, C for Cloudy): ");
//weather = char.Parse(Console.ReadLine());

//if (weather == 'S' || weather == 's')
//{
//    Console.WriteLine("It's a bright and sunny day!");
//}
//else if (weather == 'R' || weather == 'r')
//{
//    Console.WriteLine("Don't forget your umbrella, it's raining!");
//}
//else if (weather == 'C' || weather == 'c')
//{
//    Console.WriteLine("It's cloudy, maybe a good day for a walk.");
//}
//else
//{
//    Console.WriteLine("Invalid weather code entered.");
//}
#endregion

#region C# Game Camp - Character Selection Example
//Console.WriteLine("** C# Game Camp - Character Selection **");
//Console.WriteLine();
//Console.WriteLine("---------------------------------------------");
//Console.WriteLine("1- Warrior");
//Console.WriteLine("2- Archer");
//Console.WriteLine("3- Mage");
//Console.WriteLine("4- Healer");
//Console.WriteLine("---------------------------------------------");
//Console.WriteLine();

//string characterChoice;
//Console.Write("Enter the number of the character you want to select: ");
//characterChoice = Console.ReadLine();

//if (characterChoice == "1")
//{
//    Console.WriteLine("You selected the Warrior!");
//    Console.WriteLine(" - High strength");
//    Console.WriteLine(" - Medium defense");
//    Console.WriteLine(" - Close combat specialist");
//    Console.WriteLine("---------------------------------------------");
//}
//else if (characterChoice == "2")
//{
//    Console.WriteLine("You selected the Archer!");
//    Console.WriteLine(" - High agility");
//    Console.WriteLine(" - Long-range attacks");
//    Console.WriteLine(" - Weak in close combat");
//    Console.WriteLine("---------------------------------------------");
//}
//else if (characterChoice == "3")
//{
//    Console.WriteLine("You selected the Mage!");
//    Console.WriteLine(" - Uses powerful magic spells");
//    Console.WriteLine(" - Low defense");
//    Console.WriteLine(" - High damage output");
//    Console.WriteLine("---------------------------------------------");
//}
//else if (characterChoice == "4")
//{
//    Console.WriteLine("You selected the Healer!");
//    Console.WriteLine(" - Can restore health to allies");
//    Console.WriteLine(" - Medium defense");
//    Console.WriteLine(" - Supports the team");
//    Console.WriteLine("---------------------------------------------");
//}
//else
//{
//    Console.WriteLine("Invalid selection. Please enter a number between 1 and 4.");
//}
#endregion

#region C# Game Camp - Advanced Character Creator Example PUSHING THE LIMITS

//Console.WriteLine("** C# Game Camp - Advanced Character Creator **");
//Console.WriteLine();

//// Karakter tipi seçimi
//Console.WriteLine("Select a character type:");
//Console.WriteLine("1- Warrior");
//Console.WriteLine("2- Archer");
//Console.WriteLine("3- Mage");
//Console.WriteLine("4- Healer");
//Console.WriteLine("5- Rogue");
//Console.WriteLine("---------------------------------------------");

//Console.Write("Enter the number of your character choice: ");
//string characterChoice = Console.ReadLine();

//string characterType = "";
//switch (characterChoice)
//{
//    case "1": characterType = "Warrior"; break;
//    case "2": characterType = "Archer"; break;
//    case "3": characterType = "Mage"; break;
//    case "4": characterType = "Healer"; break;
//    case "5": characterType = "Rogue"; break;
//    default:
//        Console.WriteLine("Invalid character selection!");
//        return;
//}

//// Karakter özelleştirme
//Console.WriteLine();
//Console.WriteLine("Choose your hair color (Blonde, Brown, Black, Red, White): ");
//string hairColor = Console.ReadLine();

//Console.WriteLine("Choose your body type (Slim, Athletic, Muscular, Heavy, Average): ");
//string bodyType = Console.ReadLine();

//Console.WriteLine("Choose your armor type (Light, Medium, Heavy, Robe, Stealth): ");
//string armorType = Console.ReadLine();

//// Karakter tamamlandı mesajı
//Console.WriteLine();
//Console.WriteLine("******** Character Summary ********");
//Console.WriteLine("Character Type: " + characterType);
//Console.WriteLine("Hair Color: " + hairColor);
//Console.WriteLine("Body Type: " + bodyType);
//Console.WriteLine("Armor Type: " + armorType);
//Console.WriteLine("**********************************");
//Console.WriteLine("Character creation complete!");

//// Kıta seçimi
//Console.WriteLine();
//Console.WriteLine("Select your starting continent:");
//Console.WriteLine("A - Asia");
//Console.WriteLine("B - Europe");
//Console.WriteLine("C - Middle East");
//Console.WriteLine("D - America");
//Console.Write("Enter your choice (A/B/C/D): ");
//char continentChoice = char.Parse(Console.ReadLine().ToUpper());

//string continent = "";
//switch (continentChoice)
//{
//    case 'A': continent = "Asia"; break;
//    case 'B': continent = "Europe"; break;
//    case 'C': continent = "Middle East"; break;
//    case 'D': continent = "America"; break;
//    default: continent = "Unknown"; break;
//}

//Console.WriteLine("You have chosen: " + continent);
#endregion   
