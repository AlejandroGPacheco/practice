using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class PermanentEmployee : Employee
    {
        public PermanentEmployee(string _name, int _age, double _salary) : base(_name, _age, _salary)
        {
            name = _name;
            age = _age;
            salary = _salary;
        }


        public override string EmployeeDetails()
        {

            return name + " " + Convert.ToString(age); 
        }

        public override double displaySalary()
        {
            return salary;
        }

    }
}
