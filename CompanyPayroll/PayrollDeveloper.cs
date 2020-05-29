using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyPayroll
{
    class PayrollDeveloper : PayrollEmployee
    {
        public double PayPeriodEarnings = 9000.00;
        private double InsuranceAmount = 80.00;
       

        public PayrollDeveloper(int empID)
        {
             this.EmployeeID = empID;
        }

        public void RecieveBonus(double BonusAmount)
        {
            this.EmployeeBonus = BonusAmount;
        }

        public void PayInsurance()
        {
            this.PayPeriodEarnings -= InsuranceAmount;
        }

        public override void SetPaycheckTotal()
        {
            this.PaycheckTotal = PayPeriodEarnings + EmployeeBonus;
        }
    }
}
