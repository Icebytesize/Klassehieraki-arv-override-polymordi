using System;
using System.Collections.Generic;
using System.Text;

namespace Klassehieraki_arv_override_polymordi.Classes
{
    internal class HourlyEmployee : Employee
    {
        private decimal hourlyRate;
        private int hoursWorked;

        public HourlyEmployee(string name, int employeeId, DateTime hireDate, decimal hourlyRate, int hoursWorked) : base(name, employeeId, hireDate)
        {
            this.hourlyRate = hourlyRate;
            this.hoursWorked = hoursWorked;
        }

        public override decimal CalculateSalary()
        {
            // Specific salary calculation logic for hourly employees
            return hourlyRate * hoursWorked; // Example salary calculation
        }

        public override string Description()
        {
            return $"{base.Description()}\n Hourly Rate: {hourlyRate:C}, Hours Worked: {hoursWorked}";
        }
    }
}
