namespace Route_Assignments
{
    internal class Program
    {
        class obj { public int x = 10; } // for Q6
        static void Main(string[] args)
        {
            #region Q1 Read and print a number 
            Console.Write("Enter the number : ");
            int.TryParse(Console.ReadLine(), out int number);
            Console.WriteLine("The number is => " + number);
            #endregion

            #region Q2 Convert string to int

            you can't convert string that contain non-numeric to int  
            int s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(s);


            #endregion

            #region Q3 make sum of two float number
            Console.Write("Enter the first number: ");
            float num1 = float.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            float num2 = float.Parse(Console.ReadLine());
            float sum = num1 + num2;
            Console.WriteLine($"The sum of {num1} and {num2} is => {sum}");
            #endregion

            #region Q4 Extract substring from string
            Console.Write("Enter the string : ");
            string s = Console.ReadLine();
            Console.Write("Enter you start position : ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Enter the length of substring : ");
            int len = int.Parse(Console.ReadLine());

            string sub = s.Substring(start, len);
            Console.WriteLine($"The substring is => {sub}");

            #endregion

            #region Q5 Assign one value type variable to another 

            when we assign a number to another that the second number become 10
             when we change the first number then when we print we show that the first number has been changed but the second no change
            int num1 = 10;
            int num2 = num1;
            num1 = 5;
            Console.WriteLine($"The first number is => {num1}");
            Console.WriteLine($"the second number is => {num2}");
            #endregion

            #region Q6 Assign reference type to another
            object y = new obj();
            Console.WriteLine();
            int x = 20;
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");
            #endregion 

            #region Q7 Take two string and print it into one string
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            string res = s1 + s2;
            Console.WriteLine($"the result of concat the two string is => {res}");

            #endregion

            #region Q8 Calc the simple interest
            Console.Write("Enter the principal amount: ");
            double principal = double.Parse(Console.ReadLine());

            Console.Write("Enter the rate of interest: ");
            double rate = double.Parse(Console.ReadLine());

            Console.Write("Enter the time in years: ");
            double time = double.Parse(Console.ReadLine());

            double interest = (principal * rate * time) / 100;
            Console.WriteLine($"The simple interest is: {interest}");
            #endregion

            #region Q9 Calc the Body Mass Index
            double Weight = double.Parse(Console.ReadLine());
            double Height = double.Parse(Console.ReadLine());
            double BMI = Weight / (Height * Height);
            Console.WriteLine($"The Body Mass Index is => {BMI}");
            #endregion

            #region Q10 Check The temperature 
            Console.Write("Enter the temperature : ");
            int temperature = int.Parse(Console.ReadLine());
            string result;
            if (temperature < 10) result = "Just Cold";
            else if (temperature > 30) result = "Just Hot";
            else result = "Just Good";
            Console.WriteLine($"The temperature is: {result}");
            #endregion

            #region Q11 various formats for date
            Console.Write("Enter the date : ");
            string userInput = Console.ReadLine();

            DateTime date = Convert.ToDateTime(userInput);

            Console.WriteLine($"Today’s date: {date:dd, MM, yyyy}");
            Console.WriteLine($"Today’s date: {date:dd / MM / yyyy}");
            Console.WriteLine($"Today’s date: {date:dd – MM – yyyy}");
            #endregion

            #region Q12 choose 
            the answer is => C(The event is on 06/14/2024)
            #endregion

            #region Q13 choose
             the answer is => f (A value 1 will be assigned to d)
            #endregion

            #region Q14 choose 
             the answer is => d(6 1)
            #endregion

            #region Q15 choose
             the answer is => d(7 7)
            #endregion
        }
    }
}﻿
