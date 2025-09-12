// HW1b Grade

// Your Name:Brandon Tran
// Did you seek help ? If yes, specify the helper or web link here: Friend Nhi

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double score;
            double midterm;
            double final;

            const double homework_weight = 0.20;
            const double participation_weight = 0.05;
            const double quiz_weight = 0.10;
            const double midterm_weight = 0.25;
            const double final_weight = 0.40;

            string studentFirstName;
            string studentLastName;
            string studentIDAsString;
            string homeworkAsString; 
            string participationAsString;
            string quizAsString;
            string midtermAsString;
            string finalAsString;

            Console.WriteLine("What is your first name: ");
            studentFirstName = Console.ReadLine();
            Console.WriteLine("What is your last name: ");
            studentLastName = Console.ReadLine();
            Console.WriteLine("What is your Student ID: ");
            studentIDAsString = Console.ReadLine();
            Console.WriteLine("What is your Overall Grade for Homework: ");
            homeworkAsString = Console.ReadLine();
            Console.WriteLine("What is your Overall Grade for Participation: ");
            participationAsString = Console.ReadLine();
            Console.WriteLine("What is your Overall Grade for Quizzes: ");
            quizAsString = Console.ReadLine();
            Console.WriteLine("What is your Overall Grade for Midterm: ");
            midtermAsString = Console.ReadLine();
            Console.WriteLine("What is your Overall Grade for Final: ");
            finalAsString = Console.ReadLine();

            double finalGrade = (Convert.ToDouble(homeworkAsString) * homework_weight) +
                                (Convert.ToDouble(participationAsString) * participation_weight) +
                                (Convert.ToDouble(quizAsString) * quiz_weight) +
                                (Convert.ToDouble(midtermAsString) * midterm_weight) +
                                (Convert.ToDouble(finalAsString) * final_weight);

            Console.WriteLine($"Student Name: {studentFirstName} {studentLastName}");
            Console.WriteLine($"Student ID: {studentIDAsString}");
            Console.WriteLine($"Your final grade is: {finalGrade.ToString("N2")}%");
            Console.ReadKey();

        }
    }
}
