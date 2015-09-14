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

    } // end Gradebook class
}
