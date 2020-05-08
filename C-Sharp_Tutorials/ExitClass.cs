using System;

namespace C_Sharp_Tutorials
{
    public class ExitClass
    {
        public static void ExitClassMethod()
        {
            Console.WriteLine("\n\n\n>>>>>>>>>>>>>>>>>>>>>Great<<<<<<<<<<<<<<<<<<<<");
        ReExecuteIfInputIsWrong:                        //This is called "Labels". Create this to rerun if user-input is wrong or incorrect.
            Console.WriteLine("Please enter any number \n 1. If you wish to continue again. \n 2. If you wish to exit the program ");
            int InputKeyWord = Convert.ToInt32(Console.ReadLine());
            switch (InputKeyWord)
            {
                case 1:
                    Program.Main();
                    break;
                case 2:
                    break;
                default:
                    Console.WriteLine("Incorrect input. Please try again");
                    goto ReExecuteIfInputIsWrong;
            }
        }
    }
}