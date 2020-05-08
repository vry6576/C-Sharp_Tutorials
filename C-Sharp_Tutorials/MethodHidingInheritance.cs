using System;

namespace C_Sharp_Tutorials
{
    class MethodHidingInheritance
    {
        public static void MethodHidingInheritanceMethod()
        {
            ChildClass CHLD = new ChildClass();
            //ParentClass CHLD = new ChildClass(); // Scenario-4: I did not understand clearly this. But, here, Child class uses parent class method. 
            CHLD.firstName = "Child";
            CHLD.lastName = "Class";
            CHLD.PrintFullName();
            //((ParentClass)CHLD).PrintFullName();      //Scenario-2: If you want parent class's method when you are calling it, you can do in this way as well.

            ParentClass PRNT = new ParentClass();
            PRNT.firstName = "Parent";
            PRNT.lastName = "Class";
            PRNT.PrintFullName();
        }
    }
    public class ParentClass
    {
        public string firstName;
        public string lastName;
        public void PrintFullName()     //This method is hidden by childclass method in childclass.
        {
            Console.WriteLine("Parent FullName is {0} {1}", firstName, lastName);
        }
    }
    public class ChildClass: ParentClass
    {
        public new void PrintFullName()      //Scenario-1: Here, we used same method name as parentclass. This is called method hiding. it uses 'new' keyword before return type (just to avoid warning message. We can also proceed without new keyword) This method created as new and DOES NOT replace parent class. This is not useful much
        {
            Console.WriteLine("Child FullName is {0} {1}", firstName, lastName);
            //base.PrintFullName();     //Scenario-3: If you want certain fields as like base or parent class, use 'base' keyword
        }
    }
}