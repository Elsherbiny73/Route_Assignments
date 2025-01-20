using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Channels;

namespace Route_Assignments
{
    internal class OOP_Session4
    {
        #region part02 Q1
        //public interface IShape
        //{
        //    double Area { get; } 
        //    void DisplayShapeInfo(); 
        //}
        //public interface ICircle : IShape
        //{
        //    double Radius { get; } 
        //}
        //public interface IRectangle : IShape
        //{
        //    double Length { get; } 
        //    double Width { get; } 
        //}
        //public class Circle : ICircle
        //{
        //    public double Radius { get; set; }

        //    public Circle(double radius)
        //    {
        //        Radius = radius;
        //    }
        //    public double Area => Math.PI * Radius * Radius;

        //    public void DisplayShapeInfo()
        //    {
        //        Console.WriteLine($"Circle: Radius = {Radius}, Area = {Area}");
        //    }
        //}
        //public class Rectangle : IRectangle
        //{
        //    public double Length { get; set; }
        //    public double Width { get; set; }

        //    public Rectangle(double length, double width)
        //    {
        //        Length = length;
        //        Width = width;
        //    }
        //    public double Area => Length * Width;
        //    public void DisplayShapeInfo()
        //    {
        //        Console.WriteLine($"Rectangle: Length = {Length}, Width = {Width}, Area = {Area}");
        //    }
        //}
        #endregion

        #region part02 Q2
        //public interface IAuthenticationService
        //{
        //    bool AuthenticateUser(string username, string password);
        //    bool AuthorizeUser(string username, string role);
        //}

        //public class BasicAuthenticationService : IAuthenticationService
        //{
        //    public bool AuthenticateUser(string username, string password)
        //    {
        //        if (username == "user1" && password == "password1")
        //        {
        //            return true;
        //        }
        //        if (username == "user2" && password == "password2")
        //        {
        //            return true;
        //        }
        //        return false;
        //    }

        //    public bool AuthorizeUser(string username, string role)
        //    {
        //        if (username == "user1" && (role == "Admin" || role == "User"))
        //        {
        //            return true;
        //        }
        //        if (username == "user2" && role == "User")
        //        {
        //            return true;
        //        }
        //        return false;
        //    }
        //}
        #endregion

        #region part02 Q3
        //public interface INotificationService
        //{
        //    void SendNotification(string recipient, string message);
        //}

        //public class EmailNotificationService : INotificationService
        //{
        //    public void SendNotification(string recipient, string message)
        //    {
        //        Console.WriteLine($"Sending email to {recipient}: {message}");
        //    }
        //}
        //public class SmsNotificationService : INotificationService
        //{
        //    public void SendNotification(string recipient, string message)
        //    {
        //        Console.WriteLine($"Sending SMS to {recipient}: {message}");
        //    }
        //}
        //public class PushNotificationService : INotificationService
        //{
        //    public void SendNotification(string recipient, string message)
        //    {
        //        Console.WriteLine($"Sending push notification to {recipient}: {message}");
        //    }
        //}
        #endregion
        static void Main(string[] args)
        {
            #region part01 MCQ
            /*
             1 -> a
             2 -> a
             3 -> b
             4 -> b
             5 -> c
             6 -> a
             7 -> a
             8 -> c
             9 -> b
             10 -> c
             */
            #endregion

            #region part02 Q1
            //ICircle circle = new Circle(3);
            //circle.DisplayShapeInfo();

            //IRectangle rectangle = new Rectangle(12, 5);
            //rectangle.DisplayShapeInfo();
            #endregion

            #region part02 Q2
            //IAuthenticationService authService = new BasicAuthenticationService();

            //Console.WriteLine("Authenticating user1...");
            //bool isAuthenticated = authService.AuthenticateUser("user1", "password1");
            //Console.WriteLine(isAuthenticated ? "Authentication successful!" : "Authentication failed!");

            //Console.WriteLine("Authorizing user1 for role 'Admin'...");
            //bool isAuthorized = authService.AuthorizeUser("user1", "Admin");
            //Console.WriteLine(isAuthorized ? "Authorization successful!" : "Authorization failed!");

            //Console.WriteLine("Authenticating user2 with invalid password...");
            //bool isAuthFailed = authService.AuthenticateUser("user2", "wrongpassword");
            //Console.WriteLine(isAuthFailed ? "Authentication successful!" : "Authentication failed!");

            //Console.WriteLine("Authorizing user2 for role 'Admin'...");
            //bool isAuthzFailed = authService.AuthorizeUser("user2", "Admin");
            //Console.WriteLine(isAuthzFailed ? "Authorization successful!" : "Authorization failed!");
            #endregion

            #region part02 Q3
            //INotificationService emailService = new EmailNotificationService();
            //INotificationService smsService = new SmsNotificationService();
            //INotificationService pushService = new PushNotificationService();

            //string recipient = "user@example.com";
            //string message = "Hello! This is a notification.";

            //emailService.SendNotification(recipient, message);
            //smsService.SendNotification(recipient, message);
            //pushService.SendNotification(recipient, message);
            #endregion
        }
    }
}
