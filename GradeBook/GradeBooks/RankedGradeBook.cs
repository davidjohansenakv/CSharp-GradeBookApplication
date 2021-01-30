using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Ranked; 
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
                throw new InvalidOperationException("Ranked grading requires a minimum of 5 students to work");

            int gradeToSwitch; 
            double studentsToDropGrade = Students.Count * 0.2;

            var query = from stud in Students
                        where stud.AverageGrade > averageGrade
                        select stud;

            double numberOfStudentWithHigherGrade = (int)query.Count(); 
            int levelsToDrop = (int)(numberOfStudentWithHigherGrade / studentsToDropGrade);

            gradeToSwitch = 5 - levelsToDrop; 

            GradeDictionary gradeDict = new GradeDictionary();

            char grade = gradeDict.GradeSwitcher[gradeToSwitch]; 

            return grade;
        }

        public override void CalculateStatistics()
        {
            if (Students.Count < 5 )
            {
                Console.Write("Ranked grading requires at least 5 students with" +
                    " grades in order to properly calculate a student's overall grade.");
                return; 
            }

            base.CalculateStatistics(); 
        }

        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count < 5)
            {
                Console.Write("Ranked grading requires at least 5 students with grades " +
                    "in order to properly calculate a student's overall grade.");
                return;
            }
            base.CalculateStudentStatistics(name);
        }

    }
}
