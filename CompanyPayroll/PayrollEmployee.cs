using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyPayroll
{

    abstract class PayrollEmployee
    {
        private int employeeId;
        String firstName;
        String lastName;
        double paycheckTotal;
        double employeeBonus;



        public int EmployeeID
        { 
            get { return this.employeeId;  }
            set { this.employeeId = value; }
        
        }
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public double PaycheckTotal
        {
            get { return this.paycheckTotal; }
            set { this.paycheckTotal = value; }
        }

        public double EmployeeBonus
        {
            get { return this.employeeBonus; }
            set { this.employeeBonus = value; }
        }
         

        abstract public void SetPaycheckTotal();

       

        
    }
    
}
