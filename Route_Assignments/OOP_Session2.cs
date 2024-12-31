using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Channels;

namespace Route_Assignments
{
    internal class OOP_Session2
    {
        #region Q1 Struct Person
        //struct Person
        //{
        //    public string Name { get; set; }
        //    public int Age { get; set; }

        //    public Person(string name, int age)
        //    {
        //        Name = name;
        //        Age = age;
        //    }
        //}
        #endregion

        #region Q2 Struct Point 
        //struct Point
        //{
        //    public double x { get; set; }
        //    public double y { get; set; }
        //    public Point(double _x, double _y)
        //    {
        //        x = _x;
        //        y = _y;
        //    }
        //}

        #endregion

        #region Q3 Struct Person
        //struct Person
        //{
        //    public string Name { get; set; }
        //    public int Age { get; set; }
        //    public Person(string name, int age)
        //    {
        //        Name = name;
        //        Age = age;
        //    }
        //}
        #endregion
        static void Main(string[] args)
        {
            #region Q1
            //Person[] persons = new Person[4];
            //persons[0] = new Person("Youssef", 20);
            //persons[1] = new Person("Mahmoud", 47);
            //persons[2] = new Person("Elsherbiny", 70);
            //persons[3] = new Person("Mohamed", 80);

            //for (int i = 0; i < persons.Length; i++) Console.WriteLine($"Name -> {persons[i].Name} :: Age -> {persons[i].Age}");
            #endregion

            #region Q2
            //Console.Write("X1: ");
            //double x1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Y1: ");
            //double y1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("X2: ");
            //double x2 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Y2: ");
            //double y2 = Convert.ToDouble(Console.ReadLine());

            //Point point1 = new Point(x1, y1);
            //Point point2 = new Point(x2, y2);

            //double distance = Math.Sqrt(Math.Pow(point2.x - point1.x, 2) + Math.Pow(point2.y - point1.y, 2));

            //Console.WriteLine($"The distance between the two points is: {distance}");
            #endregion

            #region Q3
            //Person[] persons = new Person[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter details for person {i + 1}:");
            //    Console.Write("Name: ");
            //    string name = Console.ReadLine();
            //    Console.Write("Age: ");
            //    int age = int.Parse(Console.ReadLine());
            //    persons[i] = new Person(name, age);
            //}

            //Person oldest = persons[0];
            //for (int i = 1; i < persons.Length; i++)
            //{
            //    if (persons[i].Age > oldest.Age) oldest = persons[i];
            //}
            //Console.WriteLine($"The oldest person is {oldest.Name} and his age is {oldest.Age} ");
            #endregion

        }
    }
}
