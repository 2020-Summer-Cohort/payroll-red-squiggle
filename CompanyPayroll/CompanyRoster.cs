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
            
            
            PayrollExecutive myExec = new PayrollExecutive(0);
            this.Allemployees.Add(myExec);

            //Create three devs
            PayrollDeveloper payrollDeveloper1 = new PayrollDeveloper(1);
            PayrollDeveloper payrollDeveloper2 = new PayrollDeveloper(2);
            PayrollDeveloper payrollDeveloper3 = new PayrollDeveloper(3);
           
            
            
            this.Allemployees.Add(payrollDeveloper1);
            this.Allemployees.Add(payrollDeveloper2);
            this.Allemployees.Add(payrollDeveloper3);
          
            
            
            
            //this.listOfAllEmployees.Add(new PayrollDeveloper());
            PayrollSales mySales = new PayrollSales(4);
            this.Allemployees.Add(mySales);

            //Add( new PayrollHourly())
            PayrollHourly myHourly1 = new PayrollHourly(5);
            PayrollHourly myHourly2 = new PayrollHourly(6);
            this.Allemployees.Add(myHourly1);
            this.Allemployees.Add(myHourly2);
        }


        public void ListEmployeePayForPeriod()
        {

            foreach (PayrollEmployee person in this.Allemployees)
            {
                Console.WriteLine("EmployeeID: " + person.EmployeeID + "  " + person.PaycheckTotal.ToString("C2"));

            }
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
