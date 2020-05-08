using System;

namespace C_Sharp_Tutorials
{
    class EncapsulationProperties
    {
        public static void EncapsulationPropertiesMethod()
        {
            /* In Encapsulation, means keeping fields private and avoiding access from other classes (which may mess up the values of fields). And this can be accessed through properties.
             * In encapsulation, we acces fields through properties using get & set properties
             * In SET Property, WE MUST USE 'value' KEYWORD instead of field name in the function else, we get runtime errors. This wont be available in the GET properties.
             * We can create, Write&Read, Read Only, Write Only modes for the fields using properties.
             * this.field can be used in get & set methods but I'm not sure what exactly difference it makes. We did not use static keyword for it.
             * 
             * Auto Implemented properties can be used when there is no function to be added in the get, set property. This helps to reduce the code size a lot.
             * Ex:
             *      Private int _X;
             *      Private int _Y;
             *      public int X_temp
             *      {
             *          _X= value;
             *      }
             *      public int Y-temp
             *      {
             *          return _Y;
             *      }
             *      
             *      ****This can be converted to below****
             *      public int _X {get; set;}
             *      public int _Y {get; set;}
             *      
             */



            Student S1 = new Student();
            S1.Name = "Venkat";
            S1.Id = 1234567890;
            Console.WriteLine("\nScenario-1: Read & Write acess properties");
            Console.WriteLine("Student Name is: {0}", S1.Name);
            Console.WriteLine("\nScenario-2: Read & Write acess properties with ***AutoImplemented Properties****");
            Console.WriteLine("Student ID is: {0}", S1.Id);
            Console.WriteLine("\nScenario-3: Write only acess property");
            S1.Age = 5;
            Console.WriteLine("\nScenario-4: Read only acess property");
            Console.WriteLine("PassMarks is: {0}", S1.PassMarks);
        }

        class Student
        {
            //Im creating private fields for creating properties for it
            private string _name;
            //private int _id;      //This field can be implemented using auto implimented properties
            private int _age;
            private int _passMarks= 35;



            //Scenario-1: Read & Write acess properties
            public string Name
            {
                set                                             //In Set property, we MUST have to use 'value' keyword to avoid errors. In any case (get or set), In writeonly mode, we get No Get accessor error. Plz research on it.
                {
                    _name = string.IsNullOrEmpty(value) ? throw new Exception("Student Name can't be empty") : value;       //Ternary operators are easy to implimenmt in this Set, Get properties. It reduces code.
                }
                get                                                 //In Get property, 'value' keyword is not available.
                {
                    return string.IsNullOrEmpty(_name) ? throw new Exception("No Name") : _name; ;     //this._id to be used for better understanding
                }
            }



            //Scenario-2: Read & Write acess properties
            public int Id {set; get;}          //Auto Implemented Property. This creates the private field as well as public property and assign value to the field or get from the field.



            //Scenario-3: Write only acess property
            public int Age
            {
                set
                {
                    this._age = value > 0 ? value : throw new Exception("Student Age can not be empty or or zero or negative"); //Here, We MUST have to use 'value' keyword else it throws error says No Get accessor. Please research about it if needed.
                }
            }



            //Scenario-4: Read only acess property
            public int PassMarks
            {
                get
                {
                    return _passMarks;     //this._id to be used for better understanding
                }
            }
        }
    }
}