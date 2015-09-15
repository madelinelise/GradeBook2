using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook2
{
    class GradeBookTest
    {

    public static void Main(string[] args )
        {
            GradeBook myGradeBook = new GradeBook(
                "CS101 Intro to C#");

            myGradeBook.DisplayMessage();
            myGradeBook.DetermineClassAverage();
            Console.ReadLine();
        }

    } // end class GradeBookTest
}
