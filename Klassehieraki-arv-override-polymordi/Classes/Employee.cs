using System;
using System.Collections.Generic;
using System.Text;

namespace Klassehieraki_arv_override_polymordi.Classes
{
    internal class Employee
    {
        private string name;
        private int employeeId;
        private DateTime hireDate;

        public Employee(string name, int employeeId, DateTime hireDate)
        {
            this.name = name;
            this.employeeId = employeeId;
            this.hireDate = hireDate;
        }

        public virtual decimal CalculateSalary()
        {
            // Base salary calculation logic for a generic employee
            return 30000.00m; // Example base salary
        }

        public virtual string Description()
        {
            return $"{name} tjener {CalculateSalary():C} om måneden"; 
        }
    }
}
