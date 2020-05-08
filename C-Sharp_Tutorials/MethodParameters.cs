using System;

namespace C_Sharp_Tutorials
{
	class MethodParameters
	{
		public static void MethodParametersMethod()
		{
		ReExecuteIfInputIsWrong:                    //This is called "Labels". Create this to rerun if user-input is wrong or incorrect.
			Console.WriteLine("Please select your option (in numbers) from below \n 1. Value Parameters (Pass by Value) \n 2. Reference Parameters (Pass by Reference) \n 3. Out Parameter \n 4. Parameter Arrays");
			int InputKeyWord = Convert.ToInt32(Console.ReadLine());
			if (InputKeyWord == 1)
			{
				ValueParameter.ValueParameterMethod();
			}
			else if (InputKeyWord == 2)
			{
				ReferenceParameter.ReferenceParameterMethod();
			}
			else if (InputKeyWord == 3)
			{
				OutParameter.OutParameterMethod();
			}
			else if (InputKeyWord == 4)
			{
				ParameterArrays.ParameterArraysMethod();
			}
			else
			{
				Console.WriteLine("Incorrect input. Please try again");
				goto ReExecuteIfInputIsWrong;
			}
		}
	}

	class ValueParameter
	{
		public static void ValueParameterMethod()
		{
			int i = 0;
			Console.WriteLine("Value of 'i' initially = {0}", i);
			Temp1(i);                                                                            //Here this implimentation is called Pass By Value. No keyword is required. Value of argument will not be changed.
			Console.WriteLine("Value of 'i' after Pass By Value is implimented = {0}", i);
		}
		public static void Temp1(int Temp1)
		{
			Temp1 = 100;
		}
	}
	class ReferenceParameter
	{
		public static void ReferenceParameterMethod()
		{
			int i = 0;
			Console.WriteLine("Value of 'i' initially = {0}", i);
			Temp2(ref i);                                                   //Here this implimentation is called Pass By Reference. 'ref' keyword is used for this. 'ref' is used in Parameter and Arguments fpr this Pass By Reference. Value of argument will be changed here in this code.
			Console.WriteLine("Value of 'i' after Pass By Refence is implimented = {0}", i);
		}
		public static void Temp2(ref int Temp2)                               //Here this implimentation is called Pass By Reference. 'ref' keyword is used for this.
		{
			Temp2 = 100;
		}
	}
	class OutParameter                                                      //OUT parameter is used when we need to pass parameters and Return result also.
	{
		public static void OutParameterMethod()
		{
			Console.WriteLine("Please enter two values to find SUM & PRODUCT:");
			int FirstValue = Convert.ToInt32(Console.ReadLine());
			int SecondValue = Convert.ToInt32(Console.ReadLine());
			int Sum, Product;
			Temp3(FirstValue, SecondValue, out Sum, out Product);
			Console.WriteLine("SUM of two numbers: {0} & PRODUCT of two numbers: {1}", Sum, Product);
		}
		public static void Temp3(int x, int y, out int Addition, out int Multiplication)        //Here this implimentation is called Pass By Reference. 'ref' keyword is used for this.
		{
			Addition = x + y;
			Multiplication = x * y;
		}
	}
	class ParameterArrays
	{
		public static void ParameterArraysMethod()
		{
			int[] Array = { 1, 3, 5, 66, 102, 111, 124, 999 };
			Temp4(Array);                                       //Example:1:    public static void Temp4(1,2,3,4,5,6,6,5)
		}

		/*Array Parameter is used when an Array needs to pass through a method. 
		 * 'params' is used for this funcationality.
		 * Only ONE Array can be used in parameter at any time of passing array. Can't pass 2 array parameters.
		 * If you are passing array along with other integers, we have to pass the array at the end. Ex: Integers, strings & others are passed first and the Array should be present at the end.
		 * We can also pass the list of numbers instead of array directly like above example:1 in comments
		 */
		public static void Temp4(params int[] Temp4)
		{
			Console.WriteLine("There are {0} number of elements in the given array", Temp4.Length);
			Console.WriteLine("The elements are:");
			foreach (int i in Temp4)                            //'foreach' is used when we need each element to be used in each iteration. 'i' holds the elements from Temp[0] to end.
			{
				Console.WriteLine(i);
			}
		}
	}
}
 