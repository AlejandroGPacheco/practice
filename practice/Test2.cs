using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using System.IO;
using System;
using System.Text;
using System.Collections.Generic;

namespace practice

{
    //
    public class Test2 : ITest2
    {
        private readonly ILogger<Test2> _log;
        private readonly IConfiguration _config;
        public Test2(ILogger<Test2> log, IConfiguration config)
        {
            _log = log;
            _config = config;
        }



        public void Run()
        {
            List<Employee> list = new List<Employee>();
            Employee pe1 = new PermanentEmployee("Annie", 35, 2000);
            Employee ce1 = new ContractEmployee("Jose", 35, 1500);
            list.Add(pe1);
            list.Add(ce1);

            for (int i = 0; i < list.Count; i++)
            {
                
                //_log.LogInformation(list[i].EmployeeDetails() + " " + list[i].displaySalary());
            }
        }
    }



}
