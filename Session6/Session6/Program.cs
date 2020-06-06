using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session6
{
    class Student
    {
        void printName(String firstName, String lastName)
        {
            Console.WriteLine("First Name = {0}, Last Name = {1}", firstName, lastName);
        }
        static void Main(string[] args)
        {
            CreateStudent();
            CreatrProduct();
            Console.ReadLine();
        }
        static void CreateStudent() 
            {
            Student student = new Student();
            /* Passing argument by position */
            student.printName("Henrry", "Luffy");
            /* Passing named argument */
            student.printName(firstName: "Henrry", lastName: "Luffy");
            student.printName(lastName: "Luffy", firstName: "Henrry");
            /* Passing named argument after positional argument*/
            student.printName("Henrry", lastName: "Luffy");
            
            }

        

        
            static void CreatrProduct()
            {
                Product.Display();
            }
        
        
        
    }
}
