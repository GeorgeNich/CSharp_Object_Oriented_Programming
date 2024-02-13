using System;

namespace Employee
{
    class Employeeee {
        //instance variables
       private string customerName;
       private double customerSalary, amountinc, taxAmount;

       public Employeeee (string customerName, double customerSalary)
       {
           this.customerName = customerName;
           this.customerSalary =  customerSalary;
       }
       //Accessor methods - Get name
       public string getName()
       {
           return this.customerName;
       }
      
       //returns the salary as a currency through
        // the ToString method and parameter "C" - Get Salary
       public string getSalary()
       {
           return this.customerSalary.ToString("C");
       }

        // Get TAX
       public string getTax()
        {
            return this.taxAmount.ToString("C");
        }

       //mutator methods
        public void raiseSalary(double amountinc)
        {
            this.customerSalary += amountinc;
            Console.WriteLine("Salary increase succesful, new Salary is: " + getSalary());
        }
        public void Tax() //taxAmount
        {
        if (customerSalary <= 18200)
        {
         this.taxAmount+= 0;
        } 
        else if((customerSalary >= 18201)&&(customerSalary <= 37000))
        {                 
            this.taxAmount = ((customerSalary - 18200)/100 * 19);
        }
        else if((customerSalary >= 37001)&&(customerSalary <= 90000))
        {
            this.taxAmount = ((customerSalary - 37000)/100 * 32.5) + 3572;
        }
        else if((customerSalary >= 90001)&&(customerSalary <= 180000))
        {
            this.taxAmount = ((customerSalary - 90000)/100 * 37) + 20797;
        }
        else
        {
            this.taxAmount = ((customerSalary - 180000)/100 * 45) + 54096;
        }

        this.customerSalary = customerSalary - this.taxAmount;
        
        Console.WriteLine("Employee tax is: " + getTax());
        Console.WriteLine("Employee Salary after tax is: " + this.customerSalary.ToString("C"));
        
        }
        

        
    }
}