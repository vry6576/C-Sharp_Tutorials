using System;

namespace C_Sharp_Tutorials
{
    internal class Polymorphism
    {
        public static void PolymorphismMethod()
        {
            Employee[] Employees = new Employee [4];        //Creating instance of base class into an array
            Employees [0] = new Employee();                 //
            Employees [1] = new FullTimeEmployee();         
            Employees [2] = new PartTimeEmployee();         
            Employees [3] = new TemporaryEmployee();        

            foreach (Employee A in Employees)
            {
                A.PrintFullName();                          //Main: This is called encapsulation. Which means invoking method of derived class from instance of base class.
            }

            //Above code can be implimented as like below in comments
            /* 
            Employee Employees = new Employee();
            Employees.PrintFullName();
            Employee FullTimeEmployees = new FullTimeEmployee();
            FullTimeEmployees.PrintFullName();
            Employee PartTimeEmployees = new PartTimeEmployee();
            PartTimeEmployees.PrintFullName();
            Employee TemporaryEmployees = new TemporaryEmployee();
            TemporaryEmployees.PrintFullName();
            */
        }
    }
    public class Employee
    {
        public string firstName = "Venkat";
        public string lastName = "Reddy";
        public virtual void PrintFullName()             //Secnario: 1.1 => Virtual Key owrd is used for method replacement in parent class.
        {
            Console.WriteLine(firstName+" "+lastName);
        }
    }
    public class FullTimeEmployee : Employee        //Inheritance
    {
        public override void PrintFullName()        //Secnario: 1.2 => override Keyword is used to override parent class method. This is Method overriding (Hiding of Parent class) in encapsulation.
        {
            Console.WriteLine(firstName + " " + lastName+ " - Full Time Employee");
        }
    }
    public class PartTimeEmployee : Employee            //Inheritance    
    {
        public override void PrintFullName()        //Method over riding (Hiding of Parent class)
        {
            Console.WriteLine(firstName + " " + lastName + " - Part Time Employee");
        }
    }
    public class TemporaryEmployee : Employee        //Inheritance
    {
        public override void PrintFullName()        //Method overriding (Hiding of Parent class)
        {
            Console.WriteLine(firstName + " " + lastName + " - Temporary Employee");
        }
    }
}