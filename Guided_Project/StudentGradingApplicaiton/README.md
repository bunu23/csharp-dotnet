# Overview

You are developing a Student Grading application that automates the calculation of grades for each student in a class. The parameters for your application are:

- Create a C# console application.
- Start with four students. Each student has five exam scores.
- Each exam score is an integer value, 0-100, where 100 represents 100% correct.
- A student's overall exam score is the average of their five exam scores.
- Criteria for extra credit assignments:

  - Include extra credit assignment scores in the student's scores array.
  - Extra credit assignments are worth 10% of an exam score (when calculating the final numeric grade).
  - Add extra credit assignment scores to the student's total exam score before calculating the final numeric grade.

- Your application needs to automatically assign letter grades based on the calculated final score for each student.
- Your application needs to output/display each student’s name and formatted grade.
- Your application needs to support adding other students and scores with minimal impact to the code.

- You've already completed an initial version of the application. The Starter code project for this Guided project module includes a Program.cs file that provides the following code features:
- The code declares variables used to define student names and individual exam scores for each student.
- The code includes the variables and algorithms used to sum the exam scores and calculate the average exam score for each student.
- The code includes a hard coded letter grade that the developer must apply manually.
- The code includes Console.WriteLine() statements to display the student grading report.

Your goal is to update the existing code to include the following features:

- Use arrays to store student names and assignment scores.
- Use a foreach statement to iterate through the student names as an outer program loop.
- Use an if statement within the outer loop to identify the current student name and access that student's assignment scores.
- Use a foreach statement within the outer loop to iterate through the assignment scores array and sum the values.
- Use an updated algorithm within the outer loop to calculate the average exam score for each student.
- Use an if-elseif-else construct within the outer loop to evaluate the average exam score and assign a letter grade automatically.
- Integrate extra credit scores when calculating the student's final score and letter grade as follows:
  - Your code must detect extra credit assignments based on the number of elements in the student's scores array.
  - Your code must apply the 10% weighting factor to extra credit assignments before adding extra credit scores to the sum of exam scores.

The following list shows the letter grade that corresponds to numeric scores:

```
97 - 100   A+
93 - 96    A
90 - 92    A-
87 - 89    B+
83 - 86    B
80 - 82    B-
77 - 79    C+
73 - 76    C
70 - 72    C-
67 - 69    D+
63 - 66    D
60 - 62    D-
0  - 59    F
```

The update application needs to produce a formatted student grading report that appears as follows:

```
Student         Grade

Sophia:         92.2    A-
Andrew:         89.6    B+
Emma:           85.6    B
Logan:          91.2    A-
```

---

End users often ask developers to add new features to an application. User requests indicate that your application is being used, and more importantly, that the customer plans to continue using your application. The customer just wants some features updated. The ability to update an existing application based on user requests is very important. A successful update will preserve the integrity of the original application while providing the user with the improved experience that they requested.

Suppose you're a teacher's assistant at a school and that you developed an application to automate the grading process. The application uses arrays to store student names and graded assignments. The application also implements a combination of iteration and selection statements to calculate and report each student's final grade. Your application even differentiates between exam assignments and extra credit assignments when calculating student grades. Although the application does everything that the teacher asked for, you've received a request for new features. The teacher has asked you to update the grading report to show exam and extra credit assignment scores separately from the final numeric score and letter grade.

In short, you need to use the teacher's updated grading report specification to:

- update the iteration and selection code to calculate separate final scores for exams, extra credit assignments, and the overall grade.
- update the code that writes the grading report to the console.

```
Student         Exam Score      Overall Grade   Extra Credit

Sophia          92.2            95.88   A       92 (3.68 pts)
Andrew          89.6            91.38   A-      89 (1.78 pts)
Emma            85.6            90.94   A-      89 (5.34 pts)
Logan           91.2            93.12   A       96 (1.92 pts)
```
