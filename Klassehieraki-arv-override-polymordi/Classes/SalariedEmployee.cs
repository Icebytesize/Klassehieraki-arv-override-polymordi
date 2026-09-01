using System;
using System.Collections.Generic;
using System.Text;

namespace Klassehieraki_arv_override_polymordi.Classes
{
    internal class SalariedEmployee : Employee
    {

        private decimal baseSalary;
        private decimal bonus;
        private decimal seniority;
        public SalariedEmployee(string name, int employeeId, DateTime hireDate, decimal baseSalary, decimal bonus) : base(name, employeeId, hireDate)
        {
            this.baseSalary = baseSalary;
            this.bonus = bonus;

            int yearsWorked = DateTime.Today.Year - hireDate.Year;
            // Hvis årets jubilæum ikke er nået endnu, trækkes et år fra
            if (hireDate.Date > DateTime.Today.AddYears(-yearsWorked))    
            {
                yearsWorked--;    
            }
            this.seniority = yearsWorked * 100; // Example seniority calculation
        }

        public override decimal CalculateSalary()
        {
            // Specific salary calculation logic for salaried employees
            return baseSalary + bonus + seniority; // Example salary calculation
        }

        public override string Description()
        {
            return $"{base.Description()}\n Base Salary: {baseSalary:C}, Bonus: {bonus:C}, Seniority: {seniority:C}";
        }
    }
}
