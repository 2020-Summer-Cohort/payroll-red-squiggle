﻿using System;
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
        private double HourlyRate = 20;
      
        public PayrollHourly(int empID)
        {
            this.EmployeeID = empID;
        }

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
