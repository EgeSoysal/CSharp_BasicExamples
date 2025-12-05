// Foreach Loop is a loop with 4 parameters.
// 1: Variable Type
// 2: Variable Name
// 3: In
// 4: List, Collection, Array

#region Foreach Loops Basic Learn Examples 
////--------------------------------------------
//// Array the Colors
//string[] colors =
//    {"Orange", "Blue", "Black", "White"};
//foreach (string x in colors)
//{
//    Console.WriteLine(x);
//}
////--------------------------------------------

////Array the Numbers 
//int[] numbers = { 23, 32, 70, 1, 789 };
//foreach (int number in numbers)
//{
//    Console.WriteLine(number);
//}
////--------------------------------------------

//// Number Divisible by 2
//int[] numbers = { 23, 32, 70, 1, 789 };
//foreach (int number in numbers)
//{
//    if (number % 2 == 0)
//    {
//        Console.WriteLine(number);
//    }
//}
////--------------------------------------------

//// List Example
//List<char> characters = new List<char>()
//{
// 'a', 'b', 'c', 'p', 'e'
//};
//foreach (char character in characters)
//{
//    Console.WriteLine(character);
//}
////--------------------------------------------
#endregion

#region Mid Level Example Application

//// International Student Evaluation System

//Console.WriteLine("***** International University Admission Evaluation System *****");
//Console.WriteLine();
//Console.WriteLine();

//// Asking number of students
//Console.WriteLine("--------------------");
//Console.Write("How many students are there in your group: ");
//int studentCount = int.Parse(Console.ReadLine());
//Console.WriteLine("--------------------");

//// Arrays for names and averages
//string[] studentNames = new string[studentCount];
//double[] studentAverages = new double[studentCount];

//for (int i = 0; i < studentCount; i++)
//{
//    Console.Write($"{i + 1}. Student Name: ");
//    studentNames[i] = Console.ReadLine();
//    Console.WriteLine("--------------------");

//    Console.WriteLine($"Enter exam scores for {studentNames[i]}");


//    double totalScore = 0;

//    // SAT Score
//    Console.Write("SAT Score (0-1600): ");
//    double sat = double.Parse(Console.ReadLine());
//    totalScore += (sat / 1600) * 100;  // convert to percentage

//    // ACT Score
//    Console.Write("ACT Score (0-36): ");
//    double act = double.Parse(Console.ReadLine());
//    totalScore += (act / 36) * 100; // convert to percentage

//    // TOEFL Score
//    Console.Write("TOEFL Score (0-120): ");
//    double toefl = double.Parse(Console.ReadLine());
//    totalScore += (toefl / 120) * 100; // convert to percentage

//    Console.WriteLine();

//    // Average of the normalized scores
//    studentAverages[i] = totalScore / 3;
//}

//// Results
//for (int i = 0; i < studentCount; i++)
//{
//    Console.WriteLine($"The overall percentage score of {studentNames[i]}: {studentAverages[i]:0.00}%");

//    // Evaluation Based on Thresholds
//    if (studentAverages[i] >= 85)
//    {
//        Console.WriteLine($"{studentNames[i]} can be admitted to Top Tier / Ivy League Universities.");
//    }
//    else if (studentAverages[i] >= 70)
//    {
//        Console.WriteLine($"{studentNames[i]} can be admitted to Good Universities !! XDDD.");
//    }
//    else if (studentAverages[i] >= 50)
//    {
//        Console.WriteLine($"{studentNames[i]} can be admitted to Average Universities.");
//    }
//    else
//    {
//        Console.WriteLine($"{studentNames[i]} is **not eligible** for university admission. Needs improvement.");
//    }

//    Console.WriteLine();
//}

#endregion