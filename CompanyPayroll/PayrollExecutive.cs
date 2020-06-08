using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyPayroll
{
    class PayrollExecutive : PayrollEmployee
    {

        public double PayPeriodEarnings = 20000.00;
        private double InsuranceAmount = 10.00;
       

        public PayrollExecutive(int empID, string firstName, string lastName)
        {
            this.EmployeeID = empID;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public void RecieveBonus(double BonusAmount)
        {
            this.EmployeeBonus = BonusAmount * 3;
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
