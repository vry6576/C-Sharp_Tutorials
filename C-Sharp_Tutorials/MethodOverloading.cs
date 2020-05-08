using System;
using System.Security.Cryptography.X509Certificates;

namespace C_Sharp_Tutorials
{
    internal class MethodOverloading
    {
        public static void MethodOverloadingMethod()
        {
            /* Method Overloading means making existence of methods with same name. In this concept, method signature should be different. 
             * -->Method signature consists of number, type (int, float, etc) & kind (out, ref, Value). 
             * --> Method signature does not contain type of method like void, int. So, ""void Main()"", ""int Main()"" can not be over loaded.
             * There are 3 ways we can make method overloading possible
             * Scenario-1: Number of parameters passed to the method
             * Scenario-2: Type of parameters passed to the method. It can apply with same number of parameters but different types.
             * Scenario-3: 'out' or 'ref' keywords can make different signature of method.
             */
            
            //Verification-1: Method Overloading with different number of passing parameters
            Console.WriteLine("++++++++++++Method overloading with different number of parameters++++++++++++");
            MethodOverloadingUsingNumbers(3, 2);
            MethodOverloadingUsingNumbers(3, 2, 1);

            //Verification-2: Method Overloading with different types of passing parameters with same number of parameters
            Console.WriteLine("++++++++++++Method overloading with different types of parameters with same number++++++++++++");
            MethodOverloadingUsingTypes(3, 2);
            MethodOverloadingUsingTypes(3, 2.2F);

            //Verification-3: 'out' or 'ref' keywords can make different signature of method.
            Console.WriteLine("++++++++++++Method overloading with different kind of parameter like out, ref++++++++++++");
            MethodOverloadingUsingKinds(3, 2, 1);
            Console.WriteLine("Value of Z (x+y)= {0}", MethodOverloadingUsingKinds(3, 2, out int N));
        }


        //Scenario-1: Number of parameters passed to the method
        static void MethodOverloadingUsingNumbers(int x, int y)
        {
            Console.WriteLine("Sum of x,y = {0}", x + y);
        }
        static void MethodOverloadingUsingNumbers(int x, int y, int z)
        {
            Console.WriteLine("Sum of x,y,z = {0}", x + y + z);
        }
        
        
        //Scenario - 2: Type of parameters passed to the method.It can apply with same number of parameters but different types.
        static void MethodOverloadingUsingTypes(int x, int y)
        {
            Console.WriteLine("Sum of x,y = {0}", x + y);
        }
        static void MethodOverloadingUsingTypes(int x, float y)
        {
            Console.WriteLine("Sum of x,y = {0}", x + y);
        }

        //Scenario-3: 'out' or 'ref' keywords can make different signature of method.

        static void MethodOverloadingUsingKinds(int x, int y, int z)        //Method type is void but here parameter kind is different from other method which used 'out' keyword.
        {
            Console.WriteLine("Sum of x,yz = {0}", x + y+z);
        }
        static int MethodOverloadingUsingKinds(int x, int y, out int z)     //Method type is 'int' which does not help to form method overlaoding but here 'out' keyword is made it possible.
        {
            z = x + y; 
            return z;
        }

    }
}