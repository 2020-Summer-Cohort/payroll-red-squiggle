using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyPayroll
{
    public class CompanyRoster
    {
        public List<PayrollEmployee> Allemployees = new List<PayrollEmployee>();
        
        public CompanyRoster()
        {
            
            
            PayrollExecutive myExec = new PayrollExecutive(0, "Bill", "Gates");
            this.Allemployees.Add(myExec);

            //Create three devs
            PayrollDeveloper payrollDeveloper1 = new PayrollDeveloper(1, "Mike", "Bloomberg");
            PayrollDeveloper payrollDeveloper2 = new PayrollDeveloper(2, "Larry", "Stevenson");
            PayrollDeveloper payrollDeveloper3 = new PayrollDeveloper(3, "Valerija", "Sestic");




            this.Allemployees.Add(payrollDeveloper1);
            this.Allemployees.Add(payrollDeveloper2);
            this.Allemployees.Add(payrollDeveloper3);
          
            
            
            
            //this.listOfAllEmployees.Add(new PayrollDeveloper());
            PayrollSales mySales = new PayrollSales(4, "Johnny", "Dev");
            this.Allemployees.Add(mySales);

            //Add( new PayrollHourly())
            PayrollHourly myHourly1 = new PayrollHourly(5, "Sammy", "Minutes");
            PayrollHourly myHourly2 = new PayrollHourly(6, "Joe", "Smith");
            this.Allemployees.Add(myHourly1);
            this.Allemployees.Add(myHourly2);
        }


        public void ListEmployeePayForPeriod()
        {
            double payTotal = 0.0d;
            foreach (PayrollEmployee person in this.Allemployees)
            {
                Console.WriteLine("Employee: " + person.IdEmployeeName + "  " + person.PaycheckTotal.ToString("C2"));
                payTotal += person.PaycheckTotal;
            }

            Console.WriteLine("Total for this pay period is: " + payTotal.ToString("C2"));
            System.Threading.Thread.Sleep(3000);
        }



            public void CalculatePay()
            {
                foreach  (PayrollEmployee person in this.Allemployees)
                {



                if (person is PayrollDeveloper)
                {

                    Console.WriteLine("This employee is a developer with employeeID: " + person.EmployeeID  + ", please enter their bonus amount: ");
                    string val = Console.ReadLine();
                    double inputVal = double.Parse(val);

                    PayrollDeveloper myEmp = (PayrollDeveloper)person;
                    myEmp.RecieveBonus(inputVal);
                    myEmp.PayInsurance();

                }

                else if  (person is PayrollExecutive)
                {

                    Console.WriteLine("This employee is an executive, please enter their bonus amount: ");
                    string val = Console.ReadLine();
                    double inputVal = double.Parse(val);
                    PayrollExecutive myEmp = (PayrollExecutive)person;
                    myEmp.RecieveBonus(inputVal);
                    myEmp.PayInsurance();

                }
                else if  (person is PayrollSales)
                {
                    Console.WriteLine("This employee is salesman, please enter their bonus amount: ");
                    string val = Console.ReadLine();
                    double inputVal = double.Parse(val);
                    PayrollSales myEmp = (PayrollSales)person;
                    myEmp.GiveEmployeeBonus(inputVal);
                   

                }
                else if  (person is PayrollHourly)
                {
                    
                    Console.WriteLine("This emplyee is hourly, please enter hours worked: ");
                    string val = Console.ReadLine();
                    int hoursWorked = int.Parse(val);

                    PayrollHourly myEmp = (PayrollHourly)person;
                    myEmp.SetHoursWorked(hoursWorked);
                    myEmp.SetHourlyRate(20); 

                }


               
                person.SetPaycheckTotal();

               


            }

            Console.WriteLine("ALl Employees total will now be calculated which will take a moment to compute!!");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("All employee data was entered... The total will now be calculated");
        }
    }
    
}
