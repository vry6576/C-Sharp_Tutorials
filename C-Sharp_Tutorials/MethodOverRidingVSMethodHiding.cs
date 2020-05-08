using System;

namespace C_Sharp_Tutorials
{
    internal class MethodOverRidingVSMethodHiding
    {
        public static void MethodOverRidingVSMethodHidingMethod()
        {
            /*Here in this example I created one base class and 3 other derived classes with 3 three different scenario.
             * Scenario-1: method overriding with 'override' keyword
             * Scenario-2: method hiding with 'new' keyword
             * Scenario-3: without any keyword
             */

            //Verification-1: Method Override with 'override' Keyword
            Console.WriteLine("++++++++++++Method OverRiding++++++++++++");
            Univerisity temp1 = new Student();              //Base class references point to derived class
            temp1.PrintFullName();
            Student temp2 = new Student();                  //Derived class references point to derived class
            temp2.PrintFullName();
            Univerisity temp3 = new Univerisity();           //Base class references point to base class
            temp3.PrintFullName();

            Console.WriteLine("\n \n");
            //Verification-2: Method Hiding with 'new' Keyword
            Console.WriteLine("++++++++++++Method Hiding++++++++++++");
            Univerisity temp4 = new Teacher();              //Base class references point to derived class. But Base Class method will be called because we used new keyword from method hiding.
            temp4.PrintFullName();
            Teacher temp5 = new Teacher();                  //Derived class references point to derived class
            temp5.PrintFullName();
            Univerisity temp6 = new Univerisity();          //Base class references point to base class
            temp6.PrintFullName();

            Console.WriteLine("\n \n");
            //Verification-3: No KeyWord is used. This is also comes under method hiding
            Console.WriteLine("++++++++++++No Keyword is used++++++++++++");
            Univerisity temp7 = new OnCampusWorker();        //Base class references point to derived class. But Base Class method will be called because we did not use any keyword which is also a method hiding.
            temp7.PrintFullName();
            OnCampusWorker temp8 = new OnCampusWorker();     //Derived class references point to derived class
            temp8.PrintFullName();
            Univerisity temp9 = new Univerisity();           //Base class references point to base class
            temp9.PrintFullName();

        }
    }
    public class Univerisity
    {
        public string firstName = "Venkat";
        public string lastName = "Reddy";
        public virtual void PrintFullName()             
        {
            Console.WriteLine(firstName + " " + lastName + " - BaseClass");
        }
    }
    public class Student : Univerisity        //Scenario-1: method overriding with 'override' keyword
    {
        public override void PrintFullName()        
        {
            Console.WriteLine(firstName + " " + lastName + " - Student");
        }
    }
    public class Teacher : Univerisity           //Scenario-2: method hiding with 'new' keyword
    {
        public new void PrintFullName()        
        {
            Console.WriteLine(firstName + " " + lastName + " - Teacher");
        }
    }
    public class OnCampusWorker : Univerisity       //Scenario-3: without any keyword
    {
        public void PrintFullName()        
        {
            Console.WriteLine(firstName + " " + lastName + " - OnCampusWorker");
        }
    }
}