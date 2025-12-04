// In this file, I’m practicing different types of methods in C#.
// I cover: void methods, parameterized methods, return & type methods, 
// string/int parameter methods, and a real world style example.
// This project helps me understand how methods work and how to structure them properly.

#region Basic Void Methods

//// A simple method that prints a static customer list.
//void ShowCustomerList()
//{
//    Console.WriteLine("Linus Torwalds");
//    Console.WriteLine("Onur Tirpan");
//    Console.WriteLine("Ege Soysal");
//}

//// Calling the method multiple times will print the list multiple times.
//ShowCustomerList();
//ShowCustomerList();

//// A simple sum example (no parameters).
//void SumBasic()
//{
//    int a = 3;
//    int b = 5;
//    Console.WriteLine(a + b);
//}
//SumBasic();

#endregion


#region Void Methods With String Parameters

//// Prints a single customer's name.
//void PrintCustomerName(string customerName)
//{
//    Console.WriteLine("Customer: " + customerName);
//}
//PrintCustomerName("Oliver Knight");

//// Customer card example.
//void CustomerCard(string firstName, string lastName)
//{
//    Console.WriteLine("Customer: " + firstName + " " + lastName);
//}
//CustomerCard("Aykiz", "Tirpan");
//CustomerCard("Onur", "Tirpan");

#endregion


#region Void Methods With Integer Parameters

//// Prints the sum of three integers.
//void SumThreeNumbers(int n1, int n2, int n3)
//{
//    Console.WriteLine("Sum: " + (n1 + n2 + n3));
//}
//SumThreeNumbers(10, 20, 30);

#endregion


#region Methods Returning Values

//// Returns a fixed customer name.
//string GetCustomerName()
//{
//    return "Anna Johnson";
//}
//GetCustomerName(); // not printed unless written to console :D

//// Returns a student's full card.
//string StudentCard()
//{
//    string firstName = "Onur";
//    string lastName = "Tirpan";
//    return firstName + " " + lastName;
//}
//Console.WriteLine(StudentCard());

#endregion


#region Methods Returning String With Parameters

//// Creates a formatted country information card.
//string CountryCard(string country, string capital)
//{
//    return "Country: " + country + "\nCapital: " + capital;
//}

//string c1, c2;

//Console.WriteLine("---------------");
//Console.Write("Enter a country: ");
//c1 = Console.ReadLine();
//Console.WriteLine("---------------");

//Console.Write("Enter its capital: ");
//c2 = Console.ReadLine();
//Console.WriteLine("---------------");

//Console.WriteLine(CountryCard(c1, c2));
#endregion


#region Methods Returning Int With Parameters

//// Returns the sum of two integers.
//int Add(int a, int b)
//{
//    return a + b;
//}
//Console.WriteLine(Add(28, 48));
//Console.WriteLine(Add(487, 488));
//Console.WriteLine(Add(1999, 2000));
////adds both numbers in 3 different WriteLines and writes them one under the other.

#endregion


#region Realistic Example: Exam Result

//// Calculates a student's average and returns a formatted result.
//string ExamResult(string student, int exam1, int exam2, int exam3)
//{
//    int average = (exam1 + exam2 + exam3) / 3;

//    if (average >= 50)
//        return student + " has passed the exam! Average: " + average;
//    else
//        return student + " has failed the exam! Average: " + average;
//}

//Console.WriteLine(ExamResult("Onur", 31, 80, 69));
//Console.WriteLine(ExamResult("Soysal", 40, 35, 50));
////Three exam scores are entered the average of these exams is then compared to 50.

#endregion
