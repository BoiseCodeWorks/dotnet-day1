using System; //NOTE 'import'
using System.Collections.Generic;
using csharp_day1.Models;

namespace csharp_day1 //NOTE folder
{
    class Program //Singleton Class
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string name = "Mark " + "Ohnsman";
            Console.WriteLine($"Hello {name}");
            Console.WriteLine("Happy days!");

            int x = 7; //int represents whole integer values, positive or negative
            float y = 3.8654981f;
            double t = 43.232442343d;
            decimal j = 33534.23423425344234234243m;

            // string result = j == 0 ? "yup": "nah";


            //NOTE C# Arrays have a fixed length defined on creation
            string[] staff = new string[]{
                "mark",
                "Jake",
                "Zach",
                "D$",
                "Brittany"
            };
            staff[0] = "Mark";
            foreach (var staffName in staff)
            {
                System.Console.WriteLine(staffName);
            }
            staff[0] = null;

            List<string> staffList = new List<string>();

            staffList.Add("Kenny");
            staffList.AddRange(staff);
            staffList.Remove("Kenny");
            staffList.RemoveAt(3);

            try
            {
                if (staffList.Count > 10)
                    Console.WriteLine(staffList[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            System.Console.WriteLine("here");
            staffList.ForEach(staffList =>
            {

            });

            // var me = {
            // There is no POCO
            // }


            //NOTE Classes

            Animal simba = new Animal("Simba");
            System.Console.WriteLine(simba.ChangeName("Kimba"));
        }
    }
}
