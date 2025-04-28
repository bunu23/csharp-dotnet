int examAssignments = 5;
int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

string[] studentNames = new string[]{
    "Sophia",
    "Andrew",
    "Emma",
    "Logan"
};

int[] studentScores = new int[10];
string currentStudentLetterGrade = "";

Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

foreach (string name in studentNames)
{
    string currentStudent = name;
    if (currentStudent == "Sophia")
        studentScores = sophiaScores;
    else if (currentStudent == "Andrew")
        studentScores = andrewScores;
    else if (currentStudent == "Emma")
        studentScores = emmaScores;
    else if (currentStudent == "Logan")
        studentScores = loganScores;

    int sumAssignmentScores = 0;
    int sumExtraCreditScores = 0;


    int gradedAssignments = 0;
    int gradedExtraCreditAssignments = 0;


    decimal currentStudentGrade = 0;
    decimal currentStudentExamScore = 0;
    decimal currentStudentExtraCreditScore = 0;



    foreach (int score in studentScores)
    {
        gradedAssignments += 1;
        if (gradedAssignments <= examAssignments)
        {
            sumAssignmentScores += score;
        }
        else
        {
            sumExtraCreditScores += score;
            gradedExtraCreditAssignments += 1;
        }
    }



    currentStudentExamScore = (decimal)sumAssignmentScores / examAssignments;
    currentStudentExtraCreditScore = (decimal)sumExtraCreditScores / gradedExtraCreditAssignments;
    currentStudentGrade = (decimal)((decimal)sumAssignmentScores + ((decimal)sumExtraCreditScores / 10)) / examAssignments;

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";

    Console.WriteLine($"{currentStudent}\t\t{currentStudentExamScore}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}\t{currentStudentExtraCreditScore} ({(((decimal)sumExtraCreditScores / 10) / examAssignments)} pts)");
}


Console.WriteLine("Press any key to continue...");
Console.ReadLine();