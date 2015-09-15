// Fig. 5.6
// Gradebook Class that solves the class average problem using counter controlled repetition.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook2
{
    public class GradeBook
    {
        //  auto implemented property courseName
        public string courseName { get; set; }

        // constructor initializes CourseName property
        public GradeBook (string name)
        {
            courseName = name;
        } // end constructor

        public void DisplayMessage()
        {
            // property CourseName gets the name of the course
            Console.WriteLine("Welcome to the grade book for\n{0}!\n", courseName);
        } // end method DisplayMessage

        public void DetermineClassAverage()
        {
            int total;
            int gradeCounter;
            int grade;
            int average;

            // initialization phase
            total = 0; // intitalized the total
            gradeCounter = 1; // initializaed the loop counter

            while ( gradeCounter <= 10 )
            {
                Console.WriteLine("Enter Grade: ");
                grade = Convert.ToInt32(Console.ReadLine());
                total = total + grade;
                gradeCounter = gradeCounter + 1;
            } // end while

            // termination phase
            average = total / 10;

            Console.WriteLine("\nTotal of all 10 grades is {0}", total);
            Console.WriteLine("\nClass average of all 10 grades is {0}", average);

            
        } // end method DetermineClassAverage

    } // end Gradebook class
}
