using System;

namespace C_Sharp_Tutorials
{
    internal class Inheritance
    {
        public static void InheritanceMethod()
        {
            ChildClassInheritance temp = new ChildClassInheritance();
            temp.PrintFullName();

        }
    }
    public class ParentClassInInheritance
    {
        public string firstName = "Venkat";
        public string lastName = "Reddy";
    }
    public class ChildClassInheritance : ParentClassInInheritance       //This is inheritance. Fields from Parent class are inherited to child class and used a method to print the name.
    {
        public void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }

 
}