using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDepartment.Entities
{
    internal class Department
    {
        public string name { get; set; }


        public Department(string Name)
        {
            name = Name;
        }

        public Department()
        {
        }
    }
}
