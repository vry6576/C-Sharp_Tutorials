using System;


namespace C_Sharp_Tutorials
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("*******************************************************************\nHello!!!!! Welcome to my C# learning tutorial.\n*******************************************************************");

            MainOptions:                            //This is called "Labels". Create this to rerun if user-input is wrong or incorrect.

            Console.WriteLine("Please select your option (in numbers) from below \n 1. Static Vs Instance (Methods) \n 2. Method Parameters \n 3. NameSpaces \n 4. Classes \n 5. Static Vs Instance (Class Members) \n 6. OOPS - Inheritance \n 7. Method Hiding (Inheritance) \n 8. OOPS - Polymorphism \n 9. Method Overiding VS Method Hiding \n 10. Method Overloading \n 11. OOPS - Encapsulation (Properties) \n 12. Interfaces \n");
            int InputKeyWord = Convert.ToInt32(Console.ReadLine());
            switch (InputKeyWord)
            {
                case 1:
                    StaticVsInstance_Methods.StaticVsInstanceMethod();
                    break;
                case 2:
                    MethodParameters.MethodParametersMethod();
                    break;
                case 3:
                    NameSpaces.NameSpacesMethod();
                    break;
                case 4:
                    ClassesAndConstructors.Method();
                    break;
                case 5:
                    StaticVsInstance_ClassMembers.StaticVsInstance_ClassMembersMethod();
                    break;
                case 6:
                    Inheritance.InheritanceMethod();
                    break;
                case 7:
                    MethodHidingInheritance.MethodHidingInheritanceMethod();
                    break;
                case 8:
                    Polymorphism.PolymorphismMethod();
                    break;
                case 9:
                    MethodOverRidingVSMethodHiding.MethodOverRidingVSMethodHidingMethod();
                    break;
                case 10:
                    MethodOverloading.MethodOverloadingMethod();
                    break;
                case 11:
                    EncapsulationProperties.EncapsulationPropertiesMethod();
                    break; 
                case 12:
                    Interfaces.InterfacesMethod();
                    break; 
                default:
                    Console.WriteLine("Incorrect input. Please try again");
                    goto MainOptions;

                    /* We can also develop same functionality which is developed using Switch statement using "if-else" statement as like below.
                                 }
                    if (InputKeyWord == 1)
                    {
                        StaticVsInstance.StaticVsInstanceMethod();
                    }
                    else if (InputKeyWord == 2)
                    {
                        MethodParameters.MethodParametersMethod();
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input. Please try again");
                        goto MainOptions;
                    }
                    */
            }
            ExitClass.ExitClassMethod();
        }
    }
}
