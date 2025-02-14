using System.Collections;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace Route_Assignments
{
    internal class Program
    {
        #region Employee class
        public enum LayOffCause
        {
            VocationStockIsNegative,
            AgeGreaterThan60,
            FailedToAchieveTarget,
            Resigned
        }
        public class EmployeeLayOffEventArgs : EventArgs
        {
            public LayOffCause Cause { get; set; }
        }

        public class Employee
        {
            public event EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;

            protected virtual void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
            {
                EmployeeLayOff(this, e);
            }
            public int EmployeeID { get; set; }
            private DateTime birthDate;
            public DateTime BirthDate
            {
                get { return birthDate; }
                set
                { birthDate = value; }
            }

            private int vacationStock;
            public int VacationStock
            {
                get { return vacationStock; }
                set { vacationStock = value; }
            }
            public bool RequestVacation(DateTime From, DateTime To)
            {
                int days = (To - From).Days;
                if (days < VacationStock)
                {
                    VacationStock -= days;
                    return true;
                }
                return false;
            }
            public virtual void EndOfYearOperation()
            {
                if (VacationStock < 0)
                {
                    OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.VocationStockIsNegative });
                }
                int age = DateTime.Now.Year - BirthDate.Year;
                if (age > 60) OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.AgeGreaterThan60 });
            }

            public override string ToString()
            {
                return $"Id:{EmployeeID} | BirthDate:{BirthDate} | VacationStock:{VacationStock}";
            }
        }
        #endregion

        #region Club class
        public class Club
        {
            public int ClubID { get; set; }
            public String ClubName { get; set; }
            List<Employee> Members = new List<Employee>();
            public void AddMember(Employee E)
            {
                Members.Add(E);
                if (E.VacationStock < 0) E.EmployeeLayOff += RemoveMember;
            }
            public void RemoveMember(object sender, EmployeeLayOffEventArgs e)
            {
                Employee? employee = sender as Employee;
                Members.Remove(employee);
                Console.WriteLine($"EmployeeId: {employee.EmployeeID} ClubId:{ClubID} ClumbName:{ClubName} And The Cause Is: {e.Cause}");
            }
        }
        #endregion

        #region Department Class
        public class Department
        {
            public int DeptID { get; set; }
            public string DeptName { get; set; }
            List<Employee> Staff = new List<Employee>();
            public void AddStaff(Employee E)
            {
                Staff.Add(E);
                E.EmployeeLayOff += RemoveStaff;
            }
            public void RemoveStaff(object sender, EmployeeLayOffEventArgs e)
            {
                Employee? employee = sender as Employee;
                Staff.Remove(employee);
                Console.WriteLine($"EmployeeId: {employee} And The Cause Is: {e.Cause}");
            }
        }
        #endregion

        #region salesPerson class
        public class SalesPerson : Employee
        {
            public int AchievedTarget { get; set; }
            public bool CheckTarget(int Quota)
            {
                return AchievedTarget >= Quota;
            }

            public override void EndOfYearOperation()
            {
                if (!CheckTarget(100))
                {
                    OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.FailedToAchieveTarget });
                }
            }
        }
        #endregion

        #region BroadMember class
        public class BoardMember : Employee
        {
            public void Resign()
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.Resigned });
            }
        }
        #endregion
        static void Main(string[] args)
        {
            Employee emp1 = new Employee()
            {
                EmployeeID = 10,
                BirthDate = new DateTime(1000, 6, 15),
                VacationStock = 8,
            };
            Employee emp2 = new Employee()
            {
                EmployeeID = 10,
                BirthDate = new DateTime(2004, 6, 15),
                VacationStock = -8
            };
            Department d1 = new Department()
            {
                DeptID = 1,
                DeptName = "IT"
            };
            d1.AddStaff(emp1);
            d1.AddStaff(emp2);
            Club c = new Club();
            c.AddMember(emp1);
            c.AddMember(emp2);
            emp1.EndOfYearOperation();
            Console.WriteLine("=======================================");
            emp2.EndOfYearOperation();
            Console.WriteLine("=====================================");
            SalesPerson p1 = new SalesPerson()
            {
                EmployeeID = 20,
                BirthDate = new DateTime(1000, 6, 15),
                VacationStock = 8,
                AchievedTarget = 80
            };
            d1.AddStaff(p1);
            p1.EndOfYearOperation();
            Console.WriteLine("=====================================");
            BoardMember bm = new BoardMember()
            {
                EmployeeID = 30,
                BirthDate = new DateTime(2000, 6, 15),
                VacationStock = 8,
            };
            d1.AddStaff(bm);
            bm.Resign();
        }
    }
}
