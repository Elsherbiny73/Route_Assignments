using System.Collections.Immutable;
using System;
using System.Runtime.Serialization;

namespace Route_Assignments;

class Assingment_Session6
{
    #region FirstProject
    // public class Point3D:ICloneable, IComparable
    // {
    //     public double X { get; set; }
    //     public double Y { get; set; }
    //     public double Z { get; set; }
    //
    //     public Point3D(double x, double y, double z)
    //     {
    //         X = x;
    //         Y = y;
    //         Z = z;
    //     }
    //     public Point3D(double x, double y):this(x,y,0){}
    //     public Point3D() : this(0,0,0){}
    //     public override string ToString()
    //     {
    //        return $"Point Coordinates: ({X}, {Y}, {Z})";
    //     }
    //
    //     public int CompareTo(object? obj)
    //     {
    //         Point3D? others=(Point3D?)obj;
    //         if (others == null) return 1;
    //         if (this.X > others.X && this.Y > others.Y) return 1;
    //         else if (this.X < others.X && this.Y < others.Y) return -1; 
    //         return 0;
    //     }
    //
    //     public object Clone()
    //     {
    //         return new Point3D()
    //         {
    //            X=this.X,
    //            Y=this.Y,
    //            Z=this.Z
    //         };
    //     }
    //
    //     public void ReadPointFromUser()
    //     {
    //         Console.WriteLine("Please Enter the (x,y,z) for the Two point");
    //         Console.Write("Enter x: ");
    //         X = double.Parse(Console.ReadLine());
    //         Console.Write("Enter y: ");
    //         Y = double.Parse(Console.ReadLine());
    //         Console.Write("Enter z: ");
    //         Z = double.Parse(Console.ReadLine());
    //     }
    //     
    // }
    #endregion
    #region SecondProject
    // public abstract class Maths
    // {
    //     public double Add(double num1, double num2)
    //     {
    //         return num1 + num2;
    //     }
    //
    //     public double Substract(double num1, double num2)
    //     {
    //         return num1 - num2;
    //     }
    //
    //     public double Multiply(double num1, double num2)
    //     {
    //         return num1 * num2;
    //     }
    //
    //     public double Divide(double num1, double num2)
    //     {
    //         return num1 / num2;
    //     }
    //
    // }
    #endregion
    #region ThirdProject
    // public class Duration
    // {
    //     public int Minutes { get; set; }
    //     public int Seconds { get; set; }
    //     public int Hours { get; set; }
    //
    //     public Duration(int hours, int minutes, int seconds )
    //     {
    //         Minutes = minutes;
    //         Seconds = seconds;
    //         Hours = hours;
    //     }
    //
    //     public Duration(int NumberInSeconds)
    //     {
    //         Hours = NumberInSeconds / 3600;
    //         Minutes = (NumberInSeconds % 3600) / 60;
    //         Seconds = NumberInSeconds % 60;
    //     
    //         if (Seconds >= 60)
    //         {
    //             Minutes += Seconds / 60;
    //             Seconds %= 60;
    //         }
    //
    //         if (Minutes >= 60)
    //         {
    //             Hours += Minutes / 60;
    //             Minutes %= 60;
    //         }
    //     }
    //
    //     public Duration()
    //     {
    //     
    //     }
    //     public override string ToString()
    //     {
    //         return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
    //     }
    //
    //     public override bool Equals(object? obj)
    //     {
    //         if (obj is Duration other) return Minutes==other.Minutes&&Seconds==other.Seconds&&Hours==other.Hours;
    //         return false;
    //
    //     }
    //
    //     public override int GetHashCode()
    //     {
    //         return HashCode.Combine(Minutes, Seconds, Hours);
    //     }
    // }
    #endregion
    static void Main(string[] args)
    {
        #region FirstProject

        // Point3D p = new Point3D(10, 10, 10);
        // Console.WriteLine(p.ToString());
        // //**************************************
        // Point3D p1 = new Point3D();
        // p1.ReadPointFromUser();
        // Point3D p2 = new Point3D();
        // p2.ReadPointFromUser();
        // Console.WriteLine(p1.ToString()); //(6,6,6)
        // Console.WriteLine(p2.ToString());// (6,6,6)
        // Console.WriteLine(p1==p2 ? "The two point are equal":"the two points are not equal"); // NO, It doesn't work 
        // //********************************************
        // Point3D[] ArrayOfPoints =
        // {
        //     new Point3D(12, 11, 10),
        //     new Point3D(8, 7, 6),
        //     new Point3D(7, 6, 5),
        // };
        // Array.Sort(ArrayOfPoints);
        // foreach (var i in ArrayOfPoints)
        // {
        //     Console.WriteLine(i);
        // }
        //
        // p2 =(Point3D) p1.Clone();
        // Console.WriteLine(p2);
        #endregion
        #region SecondProject
        // Maths maths = new Maths();
        // maths.Add(5, 6);
        // maths.Substract(8, 6);
        // maths.Multiply(8, 6);
        // maths.Divide(8, 6);
        // Modify the program so that you do not have to create an instance of class: the solution is to make it abstract class 

        #endregion
        #region ThirdProject

        // Duration duration = new Duration();
        // Console.WriteLine($"Duration = {duration}");
        // Console.WriteLine($"Equal: {duration.Equals(new Duration())}");
        // Console.WriteLine($"HashCode: {duration.GetHashCode()}");
        // Duration D1 =new  Duration (1,10,15);
        // Console.WriteLine(D1.ToString());
        // Duration D1 =new Duration (3600);
        // Console.WriteLine(D1.ToString()); 
        // Duration D2 =new Duration (7800);
        // Console.WriteLine(D2.ToString());
        // Duration D3 =new Duration (666);
        // Console.WriteLine(D3.ToString());


        #endregion
    }
}