using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesLibrary;


namespace TesterProgram
{
    class TesterProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing Program for CSF2 homework");
            Console.Title = "Testing";
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-=-=-=-=Student=-=-=-=-");

            Student s1 = new Student();
            s1.FirstName = "Kolby";
            s1.LastName = "Williams";
            s1.Id = "My Id";
            s1.Gpa = 3;

            Student s2 = new Student("Kolby", "Williams", "My Id", 2);

            Console.WriteLine(s1);
            Console.WriteLine(s2);



        }//end main
    }//end class
}//end namespace
