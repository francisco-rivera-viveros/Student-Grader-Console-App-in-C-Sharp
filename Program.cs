using System;
using System.Diagnostics.CodeAnalysis;

// initialize variables - graded assignments 
int currentAssignments = 5;

int[] sophiaScores = new int[] {90, 86, 87, 98, 100, 94, 90};
int[] andrewScores = new int[] {92, 89, 81, 96, 90, 89};
int[] emmaScores = new int[] {90, 85, 87, 98, 68, 89, 89, 89};
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };    

int[] studentScores = new int[5];

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" , "Becky", "Chris", "Eric", "Gregor"};


Console.WriteLine("Student\t\tExam Score\tOverall Grade \tExtra Credit\n");


foreach (string name in studentNames)
{
    if (name == "Sophia")
        studentScores = sophiaScores;
    else if (name == "Andrew")
        studentScores = andrewScores;
    else if (name == "Emma")
        studentScores = emmaScores;
    else if (name == "Logan")
        studentScores = loganScores;
    else if (name == "Becky")
        studentScores = beckyScores;
    else if (name == "Chris")
        studentScores = chrisScores;
    else if (name == "Eric")
        studentScores = ericScores;
    else if (name == "Gregor")
        studentScores = gregorScores;
    

    int studentSum = 0;
    decimal studentGrade = 0;
    string studentLetterGrade = "";
    int gradedAssignments = 0;
    decimal examScore = 0;
    int extraCreditNumber = 0;
    decimal extraCreditPoints = 0;

    foreach (int score in studentScores)
    {
        
        gradedAssignments++;

        if (gradedAssignments <= 5)
        {
            studentSum += score;
            examScore += score;
        }
        else
        {
            studentSum += score / 10;
            extraCreditNumber += score;
            extraCreditPoints += (decimal)score / 10;
        }
    }
    studentGrade = (decimal)studentSum / currentAssignments;
    examScore = (decimal)examScore / currentAssignments;
    extraCreditNumber = extraCreditNumber / (studentScores.Length - 5);
    extraCreditPoints = (decimal)extraCreditPoints / currentAssignments;

    if (studentGrade >= 97)
        studentLetterGrade = "A+";

    else if (studentGrade >= 93)
        studentLetterGrade = "A";

    else if (studentGrade >= 90)
        studentLetterGrade = "A-";

    else if (studentGrade >= 87)
        studentLetterGrade = "B+";

    else if (studentGrade >= 83)
        studentLetterGrade = "B";

    else if (studentGrade >= 80)
        studentLetterGrade = "B-";

    else if (studentGrade >= 77)
        studentLetterGrade = "C+";

    else if (studentGrade >= 73)
        studentLetterGrade = "C";

    else if (studentGrade >= 70)
        studentLetterGrade = "C-";

    else if (studentGrade >= 67)
        studentLetterGrade = "D+";

    else if (studentGrade >= 63)
        studentLetterGrade = "D";

    else if (studentGrade >= 60)
        studentLetterGrade = "D-";
    else
        studentLetterGrade = "F";

    

    Console.WriteLine($"{name}\t\t{examScore}\t\t{studentGrade}\t{studentLetterGrade}\t{extraCreditNumber} ({extraCreditPoints} pts)");

}


