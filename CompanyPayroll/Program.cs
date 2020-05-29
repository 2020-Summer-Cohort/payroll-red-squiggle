using System;

namespace CompanyPayroll
{
    class Program
    {
       
        static void Main(string[] args)
        {
            DoPayrollThisPeriod();

            }


        private static void DoPayrollThisPeriod()
        {

            CompanyRoster companyRoster = new CompanyRoster();
            companyRoster.CalculatePay();
            companyRoster.ListEmployeePayForPeriod();


        }
    }
}
