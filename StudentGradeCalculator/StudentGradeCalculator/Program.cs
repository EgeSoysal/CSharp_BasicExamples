string[] studentName = { "Ege", "Onur", "Soysal", "Tirpan" };
// Array holding student names
// Exam + extra credit points for each student
// First 5 scores: exams
// Scores after 5th: extra credit points
int[] egeScores = { 90, 94, 88, 80 };
int[] onurScores = { 85, 87, 90, 92 };
int[] soysalScores = { 70, 75, 78, 80 };
int[] tirpanScores = { 95, 98, 100, 92 };

// Report header
Console.WriteLine($"Student" + "\t\t" + "Grade" + "\t\t" + "Overall" + "\t\t" + "Letter Grade" + "\t" + "Extra Credit (pts)");

// Outer loop iterating over students
foreach (string student in studentName)
{
    // Array to hold the current student's scores
    int[] scores = new int[0];

    if (student == "Ege")
        scores = egeScores;
    else if (student == "Onur")
        scores = onurScores;
    else if (student == "Soysal")
        scores = soysalScores;
    else if (student == "Tirpan")
        scores = tirpanScores;

    int examCount = 0;
    // Keeps track of how many exams have been processed
    decimal examTotal = 0;
    // Sum of exam scores
    decimal extraCreditTotal = 0;
    // Sum of extra credit points

    // Inner loop iterating over all scores of the student
    foreach (int score in scores)
    {
        // First 5 scores are exams
        if (examCount < 5)
        {
            examTotal += score;
        }
        // Remaining scores are extra credit
        else
        {
            extraCreditTotal += score;
        }
        examCount++;
    }

    // Average of exams (dividing by 5 since there are 5 exams)
    decimal examAverage = examTotal / 5;

    // Overall grade including extra credit
    decimal overallgrade = examAverage + extraCreditTotal;

    // Variable to hold letter grade
    string letterGrade;

    // Automatic letter grade assignment based on overall grade
    if (overallgrade >= 97) letterGrade = "A+";
    else if (overallgrade >= 93) letterGrade = "A";
    else if (overallgrade >= 90) letterGrade = "A-";
    else if (overallgrade >= 87) letterGrade = "B+";
    else if (overallgrade >= 83) letterGrade = "B";
    else if (overallgrade >= 80) letterGrade = "B-";
    else if (overallgrade >= 77) letterGrade = "C+";
    else if (overallgrade >= 73) letterGrade = "C";
    else if (overallgrade >= 70) letterGrade = "C-";
    else if (overallgrade >= 67) letterGrade = "D+";
    else if (overallgrade >= 63) letterGrade = "D";
    else if (overallgrade >= 60) letterGrade = "D-";
    else letterGrade = "F";

    // Extra credit information (raw points and points gained)
    string extraCreditInfo = $"{(int)(extraCreditTotal * 10)} ({extraCreditTotal:F2} pts)";

    // Print results in aligned format
    Console.WriteLine(
        $"{student,-15}" +
        $"{examAverage,-15:F1}" +
        $"{overallgrade,-15:F2}" +
        $"{letterGrade,-15}" +
        $"{extraCreditInfo}"
    );
}
