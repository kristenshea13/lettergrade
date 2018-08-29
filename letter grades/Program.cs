using System;

namespace letter_grades
{
    class Program
    {
        static void Main(string[] args)
        {

            //Write a method which is given an exam score, and it returns the corresponding letter grade as a 
            //    string according to this scheme: >= 90 A, [80-90) B, [70-80) C, [60-70) D, < 60 F

            Console.WriteLine("What grade do you have?");
            Console.Write("Please enter your test score: ");
            int testScore = int.Parse(Console.ReadLine());

            Console.WriteLine("Your grade is: {0}", LetterGrade(testScore));
            Console.ReadLine();


        }

        private static string LetterGrade(int testScore)
        {
            if (testScore >= 90)
                return "A";
            else if (testScore >= 80 && testScore <= 90)
                return "B";
            else if (testScore >= 70 && testScore <= 80)
                return "C";
            else if (testScore >= 60 && testScore <= 70)
                return "D";
            else
                return "F";

        }



    }
}
