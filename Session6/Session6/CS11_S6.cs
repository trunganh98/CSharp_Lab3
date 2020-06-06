using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session6
{
    class CS11_S6Employee
    {
        private int _empId;
        private string _empName;
        private int _age;
        private double _salary;
        CS11_S6Employee(int id, string name, int age, double sal)
        {
            Console.WriteLine("Constructor for Employee called") ;
            _empId = id;
            _empName = name;
            _age = age;
            _salary = sal;
        }
        ~CS11_S6Employee()
        {
            Console.WriteLine("Destructor for Employee called") ;
        }
        static void Main(string[] args)
        {
            CS11_S6Employee objEmp = new CS11_S6Employee(1, "John", 45, 35000);
            Console.WriteLine("Employee ID: " +objEmp._empId);
            Console.WriteLine("Employee Name: " +objEmp._empName);
            Console.WriteLine("Age: " +objEmp._age);
            Console.WriteLine("Salary: " +objEmp._salary);
        }
    }
}
