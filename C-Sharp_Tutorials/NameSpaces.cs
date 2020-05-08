using System;
/* Namespaces will have other namespaces and classes. These are used to property manage the clean code. 
 * When you are initialising namespaces inside a namespace we can do
 *              1. namespace TeamA
 *                      {
 *                          namespace ClassA
 *                              {
 *                                  public static void main()
 *                                      {
 *                                      }
 *                              }
 *                      }
 *              2. namespace TeamA.ClassA
 *                          {
 *                              public static void main()
 *                                  {
 *                                  }
 *                          }
 * Namespaces from different project can be accessed by adding referencing of other project to main project. 
 * Namespaces in same project can be declared and found easily without adding referncing.
 * Namespaces, Classes and Methods structures can be found using "IL DASM" tool by opening DLL file of each project.
 */

/*In this program: I created sample namespaces and projects. Just for learning purpose. Worked on them in different ways.
 * 
 * 
 *                                         ==> Class-A ==> Method-A & Method-B
 * Project-A ==> Project-A (NameSpace) ==>
 *                                         ==> Class-B ==> Method-A & Method-B
 *                                         
 *                                         
 *                                                                                      ==> Class-A ==> Method-A & Method-B
 *                                                  ==> Team-A (NameSpace-2nd Level) ==>  
 *                                                                                      ==> Class-B ==> Method-A & Method-B
 * Project-B ==> Project-B (NameSpace-1st Level) ==> 
 *                                                                                      ==> Class-A ==> Method-A & Method-B
 *                                                  ==> Team-B (NameSpace-2nd Level) ==>  
 *                                                                                      ==> Class-B ==> Method-A & Method-B
 */
using ProjectA;             //Scenario-1: Calling NameSpace from different project
using ProjectB;             //Scenario-2: Calling NameSpace which has other namespaces and classes and which is located in different project
using PBTB = ProjectB.TeamB;    //Scenario-3: Calling namespace which is inside another namespace from different project and writing alias to it. PBTA means Project-B Team-B. I just used as a shortcut instead of entering 

namespace C_Sharp_Tutorials
{
class NameSpaces
   {
       public static void NameSpacesMethod()
       {
            
            Console.WriteLine("There two projects: Project-A & Project-B.\n 1. Project-A has two classes: Class-A & Class-B. Each class has two methods: Method-A & Method-B.\n 2. Project-B has two namespaces: Namespace-A & Namespace-B. Each Namespace has two classes and each class has two methods.");
            StartNameSpaceMethod:
            Console.WriteLine("Please select any one: \n 1. Project-A \n 2. Project-B");
            int InputKeyWord = Convert.ToInt32(Console.ReadLine());
            switch (InputKeyWord)
            {
                case 1:
                    ProjectAMethod();
                    break;
                case 2:
                    ProjectBMethod();
                    break;
                default:
                    Console.WriteLine("Incorrect input. Please try again");
                    goto StartNameSpaceMethod;
            }
        }
        public static void ProjectAMethod()
        {
            ProjectA_Start:
            Console.WriteLine("Please select any one: \n 1. Class-A \n 2. Class-B");
            int InputKeyWord_ClassSelection_ProjectA = Convert.ToInt32(Console.ReadLine());
            switch (InputKeyWord_ClassSelection_ProjectA)
            {
                case 1:
                    ProjectA_ClassA_Start:
                    Console.WriteLine("Please select any one: \n 1. Method-A \n 2. Method-B");
                    int InputKeyWord_MethodSelection_ProjectA_ClassA = Convert.ToInt32(Console.ReadLine());
                    switch (InputKeyWord_MethodSelection_ProjectA_ClassA)
                    {
                        case 1:
                            ProjectA.ClassA.MethodA();
                            break;
                        case 2:
                            ProjectA.ClassA.MethodB();
                            break;
                        default:
                            Console.WriteLine("Incorrect input. Please try again");
                            goto ProjectA_ClassA_Start;
                    }
                    break;
                case 2:
                    ProjectA_ClassB_Start:
                    Console.WriteLine("Please select any one: \n 1. Method-A \n 2. Method-B");
                    int InputKeyWord_MethodSelection_ProjectA_ClassB = Convert.ToInt32(Console.ReadLine());
                    switch (InputKeyWord_MethodSelection_ProjectA_ClassB)
                    {
                        case 1:
                            ProjectA.ClassB.MethodA();
                            break;
                        case 2:
                            ProjectA.ClassB.MethodB();
                            break;
                        default:
                            Console.WriteLine("Incorrect input. Please try again");
                            goto ProjectA_ClassB_Start;
                    }
                    break;
                default:
                    Console.WriteLine("Incorrect input. Please try again");
                    goto ProjectA_Start;
            }
      

        }
        public static void ProjectBMethod()
        {
        ProjectB_Start:
            Console.WriteLine("Please select any one: \n 1. Team-A \n 2. Team-B");
            int InputKeyWord_NameSpaceSelection_ProjectB = Convert.ToInt32(Console.ReadLine());
            switch (InputKeyWord_NameSpaceSelection_ProjectB)
            {
                case 1:
                    ProjectB_TeamA_Start:
                    Console.WriteLine("Please select any one: \n 1. Class-A \n 2. Class-B");
                    int InputKeyWord_ClassSelection_ProjectB_TeamA = Convert.ToInt32(Console.ReadLine());
                    switch (InputKeyWord_ClassSelection_ProjectB_TeamA)
                    {
                        case 1:
                            ProjectB_TeamA_ClassAStart:
                            Console.WriteLine("Please select any one: \n 1. Method-A \n 2. Method-B");
                            int InputKeyWord_MethodSelection_ProjectB_TeamA_ClassA = Convert.ToInt32(Console.ReadLine());
                            switch (InputKeyWord_MethodSelection_ProjectB_TeamA_ClassA)
                            {
                                case 1:
                                    ProjectB.TeamA.ClassA.MethodA();
                                    break;
                                case 2:
                                    ProjectB.TeamA.ClassA.MethodB();
                                    break;
                                default:
                                    Console.WriteLine("Incorrect input. Please try again");
                                    goto ProjectB_TeamA_ClassAStart;
                            }
                            break;
                        case 2:
                            ProjectB_TeamA_ClassBStart:
                            Console.WriteLine("Please select any one: \n 1. Method-A \n 2. Method-B");
                            int InputKeyWord_MethodSelection_ProjectB_TeamA_ClassB = Convert.ToInt32(Console.ReadLine());
                            switch (InputKeyWord_MethodSelection_ProjectB_TeamA_ClassB)
                            {
                                case 1:
                                    ProjectB.TeamA.ClassB.MethodA();
                                    break;
                                case 2:
                                    ProjectB.TeamA.ClassB.MethodB();
                                    break;
                                default:
                                    Console.WriteLine("Incorrect input. Please try again");
                                    goto ProjectB_TeamA_ClassBStart;
                            }
                            break;
                        default:
                            Console.WriteLine("Incorrect input. Please try again");
                            goto ProjectB_TeamA_Start;
                    }
                    break;
                case 2:
                ProjectB_TeamB_Start:
                    Console.WriteLine("Please select any one: \n 1. Class-A \n 2. Class-B");
                    int InputKeyWord_ClassSelection_ProjectB_TeamB = Convert.ToInt32(Console.ReadLine());
                    switch (InputKeyWord_ClassSelection_ProjectB_TeamB)
                    {
                        case 1:
                        ProjectB_TeamB_ClassAStart:
                            Console.WriteLine("Please select any one: \n 1. Method-A \n 2. Method-B");
                            int InputKeyWord_MethodSelection_ProjectB_TeamB_ClassA = Convert.ToInt32(Console.ReadLine());
                            switch (InputKeyWord_MethodSelection_ProjectB_TeamB_ClassA)
                            {
                                case 1:
                                    PBTB.ClassA.MethodA();
                                    break;
                                case 2:
                                    PBTB.ClassA.MethodB();
                                    break;
                                default:
                                    Console.WriteLine("Incorrect input. Please try again");
                                    goto ProjectB_TeamB_ClassAStart;
                            }
                            break;
                        case 2:
                        ProjectB_TeamB_ClassBStart:
                            Console.WriteLine("Please select any one: \n 1. Method-A \n 2. Method-B");
                            int InputKeyWord_MethodSelection_ProjectB_TeamB_ClassB = Convert.ToInt32(Console.ReadLine());
                            switch (InputKeyWord_MethodSelection_ProjectB_TeamB_ClassB)
                            {
                                case 1:
                                    PBTB.ClassB.MethodA();
                                    break;
                                case 2:
                                    PBTB.ClassB.MethodB();
                                    break;
                                default:
                                    Console.WriteLine("Incorrect input. Please try again");
                                    goto ProjectB_TeamB_ClassBStart;
                            }
                            break;
                        default:
                            Console.WriteLine("Incorrect input. Please try again");
                            goto ProjectB_TeamB_Start;
                    }
                    break;
                default:
                    Console.WriteLine("Incorrect input. Please try again");
                    goto ProjectB_Start;
            }


        }
    }
}
