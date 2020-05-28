using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyPayroll
{
    class PayrollSales : PayrollEmployee
    {
        public double SalesCommision;
        double PayPeriodEarning = 3000.00;

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
            get { return this.SalesCommission; }
            set { this.SalesCommission = value; }
        }
        public double PayPeriodEarnings
        {
            get { return this.PayPeriodEarning; }
            set { this.PayPeriodEarning = value; }
        }
      
        //no insurance yet
        //public void NoInsurance()
        //{ 

        //}

    }
}
