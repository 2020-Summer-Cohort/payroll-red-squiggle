using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyPayroll
{
    class PayrollHourly : PayrollEmployee
    {
        public override void SetPaycheckTotal()
        {
            this.PaycheckTotal = HoursWorked * HourlyRate;
        }
        private int HoursWorked;
        private double HourlyRate = 20.00;

        public void SetHoursWorked(int newhoursWorked)
        {
            this.HoursWorked = newhoursWorked;
        }

        public void SetHourlyRate(double newhourlyRate)
        {
            this.HourlyRate = newhourlyRate;
        }
    }
}
