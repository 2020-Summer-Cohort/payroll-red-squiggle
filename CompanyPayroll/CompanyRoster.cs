using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyPayroll
{
    class CompanyRoster
    {
        private List<PayrollEmployee> Allemployees = new List<PayrollEmployee>();

        public CompanyRoster()
        {
            PayrollExecutive myExec = new PayrollExecutive();


            //Create three devs
            PayrollDeveloper payrollDeveloper1 = new PayrollDeveloper();
            PayrollDeveloper payrollDeveloper2 = new PayrollDeveloper();
            PayrollDeveloper payrollDeveloper3 = new PayrollDeveloper();
            this.Allemployees.Add(payrollDeveloper1);
            this.Allemployees.Add(payrollDeveloper2);
            this.Allemployees.Add(payrollDeveloper3);
            //this.listOfAllEmployees.Add(new PayrollDeveloper());
            PayrollSales mySales = new PayrollSales();
            this.Allemployees.Add(mySales);
            PayrollHourly myHourly1 = new PayrollHourly();
            PayrollHourly myHourly2 = new PayrollHourly();
            this.Allemployees.Add(myHourly1);
            this.Allemployees.Add(myHourly2);
        }
        public void CalculatePay()
        {
             foreach  (PayrollEmployee person in this.Allemployees)
            {



                if (person is PayrollDeveloper)
                {

                    PayrollDeveloper myEmp = (PayrollDeveloper)person;
                    myEmp.RecieveBonus(100.00);
                    myEmp.PayInsurance();


                }

                else if  (person is PayrollExecutive)
                {
                    PayrollExecutive myEmp = (PayrollExecutive)person;
                    myEmp.RecieveBonus(100.00);
                    myEmp.PayInsurance();

                }
                else if  (person is PayrollSales)
                {

                    PayrollSales myEmp = (PayrollSales)person;
                    myEmp.GiveEmployeeBonus(100.00);
                   

                }
                else if  (person is PayrollHourly)
                {

                    PayrollHourly myEmp = (PayrollHourly)person;
                    myEmp.SetHoursWorked(80);
                    myEmp.SetHourlyRate(20); //

                }


                person.SetPaycheckTotal();



            }





        }
    }
    
}
