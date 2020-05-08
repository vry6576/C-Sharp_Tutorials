using System;


namespace C_Sharp_Tutorials
{
    public class ClassesAndConstructors
    {
        public static void Method()
        {
            Customer.CustomerMethod();
        }
    }


    /* Classes have variables, methods, constructors, distructors 
     * 
     * 
     * 
     * 
     */
    class Customer
    {
        static string _firstName;           //Private is used for checking its initialisation using constructors. Static is used because this keyword not working at writeline step. so, used customer._firstname and kept static for field at starting.
        static string _lastName;

        /* Below is example for creating constructor
         * Constructor has same name as it's class. It does not have return type. It has parameters unlike class.
         * It is used to initialise the private fields of class.
         * 
         */

        public Customer(): this("NULL","NULL")       //Default constructor. When a constructor is initialised witout arguments.
        {

        }
        public Customer (string firstName, string lastName)         //Actual constructor which is called when there are two arguments.
        {
            _firstName = firstName;
            _lastName = lastName;
        }
        public static void CustomerMethod()
        {
            Customer New = new Customer("Venkat", "Reddy");     //calling contructor with two parameters
            Console.WriteLine("Full name (with Passing Parameters through constructor) is {0} {1}", _firstName, _lastName);     //'this' keyword is not working. Need to check why. Also, I have to use static at the time of variable initialisation to use customer._firstName.
            Customer New2 = new Customer();     //calling contructor without parameters
            Console.WriteLine("Full name (without Passing Parameters through constructor) is {0} {1}", _firstName, _lastName);
        }
    }
}