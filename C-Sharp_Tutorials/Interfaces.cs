using System;

namespace C_Sharp_Tutorials
{
    public class Interfaces
    {
        public static void InterfacesMethod()
        {
            FirstClass Temp = new FirstClass();
            Temp.print1();          //From first interface
            Temp.print2();          //From second interface


            IThirdInterface Temp1 = new FirstClass();
            Temp1.print1();
            //Temp.print2();
        }
    }
    
    class FirstClass : IFirstInterface
    {
        public void print1()                         
        {
            Console.WriteLine("First Interface");
        }
        public void print2()
        {
            Console.WriteLine("SecondInterface");
        }
    }

    interface IFirstInterface : ISecondInterface, IThirdInterface
    {
        /*
        *An Interface are same like class but it contains only declarations but not function implementations or definitions  
        * An Interface should not contain Fields.
        * Interfaces are public by default unlike Classes.
        * Interfaces hide the methods came from parent interface which has same method name & signatures. Ex: IFirstInterface Print() hides the IThirdInterface Print().
        * We have to use public access modifier for the method implementation inside class. Else interface can not 
        * Usually, everyone use prefix 'I' before the name Ex: for Customer ==> ICustomer. This is just to understand easily when we see it. 
        * 
        */
        void print1();
    }
    interface ISecondInterface
    {
        void print2();
    }
    interface IThirdInterface
    {
        void print1();      //This method is hidden by IFirstInterface when it is invoked because there is already a method with same name.
    }
}