using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyPayroll
{
    class PayrollSales : PayrollEmployee
    {
        public double salesCommission = 0.00;
        double PayPeriodEarning = 3000.00;
        
        public PayrollSales(int empID, string firstName, string lastName)
        {
            this.EmployeeID = empID;
            this.FirstName = firstName;
            this.LastName = lastName;

        }

        public override void SetPaycheckTotal()
        {
            this.PaycheckTotal = PayPeriodEarning + SalesCommission; 
        }
        
        public void GiveEmployeeBonus(double payPeriodBonus)
        {
            this.EmployeeBonus = payPeriodBonus;
        }
        
        public double SalesCommission
        {
            get { return this.salesCommission; }
            set { this.salesCommission = value; }
        }
        public double PayPeriodEarnings
        {
            get { return this.PayPeriodEarning; }
            set { this.PayPeriodEarning = value; }
        }
    

    }
}
