using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyPayroll
{
    class PayrollSales : PayrollEmployee
    {
        public double salesCommission = 0.00;
        double PayPeriodEarning = 3000.00;
        
        public PayrollSales(int v)
        {
           this.EmployeeID = v;
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
