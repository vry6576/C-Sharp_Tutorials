using System;

namespace C_Sharp_Tutorials
{
    class StaticVsInstance_Methods
    {
        public static void StaticVsInstanceMethod()
        {
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            ExtraClass P = new ExtraClass();        
            P.ExtraMethod(age);                 //Scenario-1: This is called instance method
        }
        public static void AgeEligibility(int YourAge)   //For checking static (instead of instance method, add static to this method and remove comments for static class on bottom
        {
            if (YourAge >= 18)
            {
                Console.WriteLine("Great!!!!You are eligible for taking decisions on your own.");
            }
            else
            {
                Console.WriteLine("Sorry, You are not eligible for taking decisions on your own.");
            }
        }
    }
    /*Below class is the example for initialising instance methods from other classes*/
    //class ExtraClass
    //{
    //    public void ExtraMethod(int ExtraParameter)
    //    {
    //        StaticVsInstance P = new StaticVsInstance();
    //        P.AgeEligibility(ExtraParameter);
    //    }
    //}
    /*Below Class is the example for initialising static methods from other classes*/
    class ExtraClass
    {
        public void ExtraMethod(int ExtraParameter)
        {
            StaticVsInstance_Methods.AgeEligibility(ExtraParameter);        //Scenario-2: This is example of static method
        }
    }
}