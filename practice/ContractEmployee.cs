using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class ContractEmployee : Employee
    {
        public ContractEmployee(string _name, int _age, double _salary) : base(_name, _age, _salary) { }

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

