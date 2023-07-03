﻿using System;

// initialize variables - graded assignments 
int currentAssignments = 5;

string[] studentsNames = new string[] {"Sophia", "Andrew", "Emma", "Logan"};
string currentStudentLetterGrade = "";

int[] studentScores = new int[10];

int[] sophiaScores = new int[] {90, 86, 87, 98, 100, 94, 90};
int[] andrewScores = new int[] {92, 89, 81, 96, 90, 89};
int[] emmaScores = new int[] {90, 85, 87, 98, 68, 89, 89, 89};
int[] loganScores = new int[] {90, 95, 87, 88, 96, 96};

Console.WriteLine("Student\t\tGrade\n");


foreach(string name in studentsNames){
    
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
    decimal currentStudentGrade = 0;
    
    foreach (int score in studentScores){
        sumAssignmentScores += score;
    }

    currentStudentGrade = (decimal)sumAssignmentScores / currentAssignments;

    if(currentStudentGrade >= 97){
        currentStudentLetterGrade = "A+";
    }else if (currentStudentGrade >= 93){
        currentStudentLetterGrade = "A";
    }else if (currentStudentGrade >= 90){
        currentStudentLetterGrade = "A-";
    }else if (currentStudentGrade >= 87){
        currentStudentLetterGrade = "B+";
    }else if (currentStudentGrade >= 83){
        currentStudentLetterGrade = "B";
    }else if (currentStudentGrade >= 80){
        currentStudentLetterGrade = "B-";
    }else if (currentStudentGrade >= 77){
        currentStudentLetterGrade = "C+";
    }else if (currentStudentGrade >= 73){
        currentStudentLetterGrade = "C";
    }else if (currentStudentGrade >= 70){
        currentStudentLetterGrade = "C-";
    }else if (currentStudentGrade >= 67){
        currentStudentLetterGrade = "D+";
    }else if (currentStudentGrade >= 63){
        currentStudentLetterGrade = "D";
    }else if (currentStudentGrade >= 60){
        currentStudentLetterGrade = "D-";
    }else{
        currentStudentLetterGrade = "F";
    }
    
    Console.WriteLine($"{currentStudent}:\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();