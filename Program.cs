using System;

namespace HelloWorlds
{
    internal class Program
    {
        static void Main(String[] arges)
        {
            int myInt = 5;
            int mySecondInt = 10;

            if(myInt < mySecondInt)
            {
                myInt += 10;
            }

            // Console.WriteLine(myInt);

            string myCow = "Cows";
            // string myCapitalizedCow = "cow";

            // if (myCow == myCapitalizedCow)
            // {
            //     Console.WriteLine("Equal");
            //     // cow = cow
            // }

            // else if (myCow == myCapitalizedCow.ToLower())
            // {
            //     Console.WriteLine("Equal without case sensitivity");
            //     Console.WriteLine("get " + myCapitalizedCow.ToLower());
            //     // cow = Cow -> cow
            // }
            // else 
            // {
            //     Console.WriteLine("Not Equal");
            //     // Cows
            // }

            switch (myCow)
            {
                case "cow":
                    Console.WriteLine("Lowercase");
                    break;
                case "Cow":
                    Console.WriteLine("Capitalized");
                    break;
                default: 
                    Console.WriteLine("Default Ran");
                    break;       
            }

        }
    }

}
