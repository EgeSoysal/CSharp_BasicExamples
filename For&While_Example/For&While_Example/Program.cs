#region For Example Grade Average Calculator
//int total = 0;
//int grade;

//Console.WriteLine("--- *GRADE AVERAGE CALCULATOR* ---");

//for (int i = 1; i <= 5; i++)
//{
//    Console.Write($"Enter grade for student {i}: ");
//    grade = int.Parse(Console.ReadLine());
//    total += grade;
//}

//double avg = total / 5.0;

//Console.WriteLine("Class Average: " + avg);
//Console.ReadLine();
#endregion

#region While Example Password & Username Checker
//string correctUsername = "ruhi";
//string correctPassword = "ruhi123";

//string usernameInput = "";
//string passwordInput = "";

//// Username check loop
//while (usernameInput != correctUsername)
//{
//    Console.Write("Enter username: ");
//    usernameInput = Console.ReadLine();

//    if (usernameInput != correctUsername)
//    {
//        Console.WriteLine("Incorrect username, please try again !!!");
//    }
//}

//// Password check loop
//while (passwordInput != correctPassword)
//{
//    Console.Write("Enter password: ");
//    passwordInput = Console.ReadLine();

//    if (passwordInput != correctPassword)
//    {
//        Console.WriteLine("Incorrect password, please try again.\n");
//    }
//}

//Console.WriteLine("Login successful!");
//Console.ReadLine();
#endregion

#region For & While Loop Example
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        List<double> prices = new List<double>();
//        string komut = "";

//        while (komut != "2")
//        {
//            Console.WriteLine("--------------------------");
//            Console.Write("How Many Products Would you Like to add? ");
//            int count = int.Parse(Console.ReadLine());
//            Console.WriteLine("--------------------------");

//            for (int i = 1; i <= count; i++)
//            {
                
//                Console.Write($"Product {i} Price: ");
//                double price = double.Parse(Console.ReadLine());
//                prices.Add(price);
//                Console.WriteLine("--------------------------");
//            }
//            Console.WriteLine("**************************");
//            Console.WriteLine("1- Continue adding Products");
//            Console.WriteLine("2- Show total price and exit");
//            Console.WriteLine("***************************");
//            Console.WriteLine("--------------------------");
//            Console.Write("Choice: ");
//            komut = Console.ReadLine();
//        }
//        Console.WriteLine("--------------------------");
//        double total = 0;
//        for (int i = 0; i < prices.Count; i++)
//        {
//            total += prices[i];
//        }

//        Console.WriteLine("--------------------------");
//        Console.WriteLine("Your total Payment: " + total + " $");
//        Console.WriteLine("--------------------------");

//        Console.ReadLine();
//    }
//}





#endregion