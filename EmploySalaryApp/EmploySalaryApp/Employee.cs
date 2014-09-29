using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmploySalaryApp
{
    class Employee
    {
        public string name;

        public double salary;
        public double houseRent=0;
        public double medicalAlloance;

        public double GetHouseRent()
        {
            return (salary*houseRent)/100;
        }
        public double GetMedical()
        {
            return (salary * medicalAlloance) / 100;
        }

        public double GetTotal()
        {
            return salary + GetHouseRent() + GetMedical();
        }

    }
}
