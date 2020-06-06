using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session6
{
    class CS9_S6Employees
    {
        string _empName;
        int _empAge;
        string _deptName;
        CS9_S6Employees(string name, int num)
        {
            _empName = name;
            _empAge = num;
            _deptName = "Research & Development";
        }
        static void Main(string[] args)
        {
            CS9_S6Employees objEmp = new CS9_S6Employees("John", 10);
            Console.WriteLine(objEmp._deptName);
        }
    }
}
