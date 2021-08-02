using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class Employee
    {
        public String name;
        public int age;
        public double salary;
        public Employee (string _name, int _age, double _salary)
        {
            name = _name;
            age = _age;
            salary = _salary;
        }

        public virtual string EmployeeDetails()
        {
            return ("Not what i was expecting");
        }
        public virtual double displaySalary()
        {
            return 0;
        }
        
        

    }
}
