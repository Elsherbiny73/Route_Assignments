using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Channels;
using System;

namespace Route_Assignments
{
    internal class OOP_Session3
    {
        #region part01 class
        // public class Car
        // {
        //     public int Id { get; set; }
        //     public string? Model { get; set; }
        //     public decimal speed { get; set; }
        // }
        #endregion

        #region part02 class Q1
        //public enum SecurityPrivileges
        //{
        //    Guest,
        //    Developer,
        //    Secretary,
        //    DBA
        //}
        //public class Employee
        //{
        //    public int ID { get; set; }
        //    public string Name { get; set; }
        //    public SecurityPrivileges SecurityLevel { get; set; }
        //    public decimal Salary { get; set; }
        //    public DateTime HireDate { get; set; }

        //    private string gender;
        //    public string Gender
        //    {
        //        get { return gender; }
        //        set
        //        {
        //            if (value == "M" || value == "F") gender = value;
        //            else Console.WriteLine("invalid! try again.");
        //        }

        //    }
        //    public Employee(int id, string name, SecurityPrivileges securityLevel, decimal salary, DateTime hireDate, string gender)
        //    {
        //        ID = id;
        //        Name = name;
        //        SecurityLevel = securityLevel;
        //        Salary = salary;
        //        HireDate = hireDate;
        //        Gender = gender;
        //    }
        //    public override string ToString()
        //    {
        //        return $"ID = {ID} \nName = {Name} \nSecurityLevel = {SecurityLevel} \nSalary = {Salary} \nHireDate = {HireDate} \nGender = {Gender}";
        //    }
        //}
        #endregion

        #region part02 class Q2
        //public class HiringDate
        //{
        //    public int Day { get; set; }
        //    public int Month { get; set; }
        //    public int Year { get; set; }
        //    public HiringDate(int day, int month, int year)
        //    {
        //        Day = day;
        //        Month = month;
        //        Year = year;
        //    }
        //    public override string ToString()
        //    {
        //        return $"Day is {Day} \nMonth is {Month} \nYear is {Year}";
        //    }
        //}
        #endregion

        #region part02 class Q3
        //public enum SecurityPrivileges
        //{
        //    Guest,
        //    Developer,
        //    Secretary,
        //    DBA,
        //    SecurityOfficer
        //}
        //public class Employee
        //{
        //    public int ID { get; set; }
        //    public string Name { get; set; }
        //    public SecurityPrivileges SecurityLevel { get; set; }
        //    public decimal Salary { get; set; }
        //    public DateTime HireDate { get; set; }

        //    private string gender;
        //    public string Gender
        //    {
        //        get { return gender; }
        //        set
        //        {
        //            if (value == "M" || value == "F") gender = value;
        //            else Console.WriteLine("invalid! try again.");
        //        }

        //    }
        //    public Employee(int id, string name, SecurityPrivileges securityLevel, decimal salary, DateTime hireDate, string gender)
        //    {
        //        ID = id;
        //        Name = name;
        //        SecurityLevel = securityLevel;
        //        Salary = salary;
        //        HireDate = hireDate;
        //        Gender = gender;
        //    }
        //    public override string ToString()
        //    {
        //        return $"ID = {ID} \nName = {Name} \nSecurityLevel = {SecurityLevel} \nSalary = {Salary} \nHireDate = {HireDate} \nGender = {Gender}";
        //    }
        //}
        #endregion

        #region part02 class Q4 
        // public enum SecurityPrivileges
        // {
        //     Guest,
        //     Developer,
        //     Secretary,
        //     DBA,
        //     SecurityOfficer
        // }
        // public class Employee
        // {
        //     public int ID { get; set; }
        //     public string Name { get; set; }
        //     public SecurityPrivileges SecurityLevel { get; set; }
        //     public decimal Salary { get; set; }
        //     public DateTime HireDate { get; set; }

        //     private string gender;
        //     public string Gender
        //     {
        //         get { return gender; }
        //         set
        //         {
        //             if (value == "M" || value == "F") gender = value;
        //             else Console.WriteLine("invalid! try again.");
        //         }

        //     }
        //     public Employee(int id, string name, SecurityPrivileges securityLevel, decimal salary, DateTime hireDate, string gender)
        //     {
        //         ID = id;
        //         Name = name;
        //         SecurityLevel = securityLevel;
        //         Salary = salary;
        //         HireDate = hireDate;
        //         Gender = gender;
        //     }
        //     public override string ToString()
        //     {
        //         return $"ID = {ID} \nName = {Name} \nSecurityLevel = {SecurityLevel} \nSalary = {Salary} \nHireDate = {HireDate} \nGender = {Gender}";
        //     }
        // }
        #endregion
        static void Main(string[] args)
        {
            #region part01
            //Car car = new Car();
            //Console.WriteLine(car.Id);
            #endregion

            #region part02 Q1
            //Employee employee = new Employee(1, "Youssef elsherbiny", SecurityPrivileges.DBA, 5000, new DateTime(2004, 6, 1),"M");
            //Console.WriteLine(employee);
            #endregion

            #region part02 Q2
            //HiringDate date = new HiringDate(1, 6, 2004);
            //Console.WriteLine(date);
            #endregion

            #region part02 Q3
            //Employee[] EmpArr = new Employee[3];
            //EmpArr[0] = new Employee(1, "Youssef elsherbiny", SecurityPrivileges.DBA, 5000, new DateTime(2004, 6, 1), "M");
            //EmpArr[1] = new Employee(2, "Adel Kassem", SecurityPrivileges.Guest, 4000, new DateTime(2004, 6, 15), "M");
            //EmpArr[2] = new Employee(3, "Mona Mohamed", SecurityPrivileges.SecurityOfficer, 6000, new DateTime(2000, 10, 11), "F");

            //foreach (var i in EmpArr)
            //{
            //    Console.WriteLine(i);
            //    Console.WriteLine();
            //}
            #endregion

            #region part02 Q4
            //Employee[] EmpArr = new Employee[3];
            //EmpArr[0] = new Employee(1, "Youssef elsherbiny", SecurityPrivileges.DBA, 5000, new DateTime(2004, 6, 1), "M");
            //EmpArr[1] = new Employee(2, "Adel Kassem", SecurityPrivileges.Guest, 4000, new DateTime(2004, 6, 15), "M");
            //EmpArr[2] = new Employee(3, "Mona Mohamed", SecurityPrivileges.SecurityOfficer, 6000, new DateTime(2000, 10, 11), "F");

            //int boxingCount = 0;
            //int unboxingCount = 0;

            //for (int i = 0; i < EmpArr.Length - 1; i++)
            //{
            //    for (int j = 0; j < EmpArr.Length - i - 1; j++)
            //    {
            //        boxingCount++;
            //        if (EmpArr[j].HireDate > EmpArr[j + 1].HireDate)
            //        {
            //            Employee temp = EmpArr[j];
            //            EmpArr[j] = EmpArr[j + 1];
            //            EmpArr[j + 1] = temp;
            //        }
            //    }
            //}

            //Console.WriteLine("Employees sorted by Hire Date:");
            //foreach (var i in EmpArr)
            //{
            //    Console.WriteLine(i);
            //    Console.WriteLine();
            //}

            //Console.WriteLine($"Number of Boxing operations: {boxingCount}");
            //Console.WriteLine($"Number of Unboxing operations: {unboxingCount}");
            #endregion
        }
    }
}
