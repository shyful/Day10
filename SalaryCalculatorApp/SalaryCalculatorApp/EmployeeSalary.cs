using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorApp
{
    class EmployeeSalary
    {
        public string name;
        private double basicAmount;
        private double percentofHouseRent;
        private double percentofMedicalAllowance;
        public double CalculateSalary()
        {
            return basicAmount + GetHouserent() + GetMedicalAllowance();
        }

        private double GetMedicalAllowance()
        {
           return (percentofMedicalAllowance*basicAmount)/100;
        }

        private double GetHouserent()
        {
          return  (percentofHouseRent*basicAmount)/100;
        }
    }
}
