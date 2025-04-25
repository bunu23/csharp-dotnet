// This program calculates and prints the grades of students based on their assignment scores.
int currentAssignments = 5; // Number of assignments each student has completed

int alex1 = 91;
int alex2 = 88;
int alex3 = 94;
int alex4 = 90;
int alex5 = 96;

int mia1 = 77;
int mia2 = 85;
int mia3 = 80;
int mia4 = 83;
int mia5 = 82;

int ethan1 = 86;
int ethan2 = 90;
int ethan3 = 78;
int ethan4 = 84;
int ethan5 = 81;

int luna1 = 92;
int luna2 = 94;
int luna3 = 97;
int luna4 = 99;
int luna5 = 95;

int alexSum = alex1 + alex2 + alex3 + alex4 + alex5;
int miaSum = mia1 + mia2 + mia3 + mia4 + mia5;
int ethanSum = ethan1 + ethan2 + ethan3 + ethan4 + ethan5;
int lunaSum = luna1 + luna2 + luna3 + luna4 + luna5;

decimal alexScore = (decimal)alexSum / currentAssignments;
decimal miaScore = (decimal)miaSum / currentAssignments;
decimal ethanScore = (decimal)ethanSum / currentAssignments;
decimal lunaScore = (decimal)lunaSum / currentAssignments;

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Alex:\t\t" + alexScore + "\tA");
Console.WriteLine("Mia:\t\t" + miaScore + "\tB");
Console.WriteLine("Ethan:\t\t" + ethanScore + "\tB");
Console.WriteLine("Luna:\t\t" + lunaScore + "\tA");


string studentName = "Liam Thompson";
string course1Name = "History 201";
string course2Name = "Geometry 101";
string course3Name = "Chemistry 101";
string course4Name = "Software Engineering I";
string course5Name = "Philosophy 101";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

int gradeA = 4;
int gradeB = 3;

int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;

int totalCreditHours = 0;
totalCreditHours += course1Credit;
totalCreditHours += course2Credit;
totalCreditHours += course3Credit;
totalCreditHours += course4Credit;
totalCreditHours += course5Credit;

int totalGradePoints = 0;
totalGradePoints += course1Credit * course1Grade;
totalGradePoints += course2Credit * course2Grade;
totalGradePoints += course3Credit * course3Grade;
totalGradePoints += course4Credit * course4Grade;
totalGradePoints += course5Credit * course5Grade;

decimal gradePointAverage = (decimal)totalGradePoints / totalCreditHours;

int leadingDigit = (int)gradePointAverage;
int firstDigit = (int)(gradePointAverage * 10) % 10;
int secondDigit = (int)(gradePointAverage * 100) % 10;

Console.WriteLine($"Student: {studentName}\n");
Console.WriteLine("Course\t\t\t\t\tGrade\tCredit Hours");

Console.WriteLine($"{course1Name}\t\t\t{course1Grade}\t\t{course1Credit}");
Console.WriteLine($"{course2Name}\t\t\t{course2Grade}\t\t{course2Credit}");
Console.WriteLine($"{course3Name}\t\t\t{course3Grade}\t\t{course3Credit}");
Console.WriteLine($"{course4Name}\t{course4Grade}\t\t{course4Credit}");
Console.WriteLine($"{course5Name}\t\t\t{course5Grade}\t\t{course5Credit}");

Console.WriteLine($"\nFinal GPA:\t\t\t {leadingDigit}.{firstDigit}{secondDigit}");
