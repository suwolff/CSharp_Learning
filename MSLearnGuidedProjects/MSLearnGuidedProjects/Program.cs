﻿// See https://aka.ms/new-console-template for more information



// 1 Write Your First Code Using C# --- A: Guided Project - Calculate and Print Student Grades

// Input

int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;

//Berechnungen

int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

decimal sophiaScore = (decimal)sophiaSum / currentAssignments;
decimal nicolasScore = (decimal)nicolasSum / currentAssignments;
decimal zahirahScore = (decimal)zahirahSum / currentAssignments;
decimal jeongScore = (decimal)jeongSum / currentAssignments;


//Output

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine($"Sophia:\t\t{sophiaScore}\tA");
Console.WriteLine($"Nicolas:\t{nicolasScore}\tB");
Console.WriteLine($"Zahirah:\t{zahirahScore}\tB");
Console.WriteLine($"Jeong:\t\t{jeongScore}\tA");




// 1 Write Your First Code Using C# --- B: Guided Project - Calculate Final GPA

string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int gradeA = 4;
int gradeB = 3;

int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;


int totalCreditHours = course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;

int totalGradePoints = 0;
totalGradePoints += course1Credit * course1Grade; //mehr Text, aber übersichtlicher als lange Reihe
totalGradePoints += course2Credit * course2Grade;
totalGradePoints += course3Credit * course3Grade;
totalGradePoints += course4Credit * course4Grade;
totalGradePoints += course5Credit * course5Grade;

decimal GPA = Math.Round((decimal)totalGradePoints / totalCreditHours, 2); //Vorgriff auf Rundung (kommt später genauer)


Console.WriteLine($"Student: {studentName}\n");
Console.WriteLine("Course\t\t\t\tGrade\tCredit Hours");
Console.WriteLine($"{course1Name}\t\t\t{course1Grade}\t\t{course1Credit}");
Console.WriteLine($"{course2Name}\t\t\t{course2Grade}\t\t{course2Credit}");
Console.WriteLine($"{course3Name}\t\t\t{course3Grade}\t\t{course3Credit}");
Console.WriteLine($"{course4Name}\t{course4Grade}\t\t{course4Credit}");
Console.WriteLine($"{course5Name}\t\t{course5Grade}\t\t{course5Credit}");
Console.WriteLine($"\nFinal GPA:\t\t\t{GPA}");

