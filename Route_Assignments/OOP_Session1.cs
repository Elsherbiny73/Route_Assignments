using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Channels;

namespace Route_Assignments
{
    internal class OOP_Session1
    {
        public enum Gender // -> for part 1
        {
            male,
            female
        }
        public class person // -> for part 1
        {
            public int Id { get; set; }
            public string? Name { get; set; }
            public Gender Gender { get; set; }
        }

        #region part2 Q1
        enum WeekDays
        {
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday,
            sunday
        }
        #endregion

        #region part2 Q2
        enum Seas_on
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }
        #endregion

        #region part2 Q3
        [Flags]
        enum permissions : byte
        {
            Read = 1,
            write = 2,
            Delete = 4,
            Execute = 8
        }
        #endregion

        #region part2 Q4
        enum Colors
        {
            Red,
            Green,
            Blue
        }
        #endregion

        static void Main(string[] args)
        {
            #region Part1 give an example from the video
            //person person = new person();
            //person.Id = 1;
            //person.Name = "Ahmed";
            //person.Gender = Gender.male;
            //Console.WriteLine(person.Gender);
            #endregion

            #region part2 Q1 print all the days
            //for (int i = 0; i < Enum.GetValues(typeof(WeekDays)).Length; i++)
            //{
            //    Console.WriteLine((WeekDays)i);
            //}
            #endregion

            #region part2 Q2  displays the corresponding month range for that season
            //Seas_on s = new Seas_on();
            //s = (Seas_on)Enum.Parse(typeof(Seas_on), Console.ReadLine());
            //if (s == (Seas_on)1) Console.WriteLine("march to may");
            //else if (s == (Seas_on)2) Console.WriteLine("june to august");
            //else if (s == (Seas_on)3) Console.WriteLine("September to November");
            //else if (s == (Seas_on)4) Console.WriteLine("December to February");
            #endregion

            #region part2 Q3 permissions
            //permissions p = new permissions();
            //p = (permissions)15;
            //Console.WriteLine(p);
            //p ^= permissions.Delete; 
            //Console.WriteLine(p);
            //p |= permissions.Delete; 
            //Console.WriteLine(p);
            //if ((p & permissions.Delete) == permissions.Delete) Console.WriteLine("the permission is already exist"); // to check if the permission is exist or not 
            //else p ^= permissions.Delete;
            #endregion

            #region part2 Q4 displays a message
            // Colors c = new Colors();
            // c = (Colors)Enum.Parse(typeof(Colors), Console.ReadLine());
            // if(c==(Colors)1||c==(Colors)2||c==(Colors)3)Console.WriteLine("Yes, it's primary color");
            // else Console.WriteLine("No, it not a primary color");
            #endregion

        }
    }
}
