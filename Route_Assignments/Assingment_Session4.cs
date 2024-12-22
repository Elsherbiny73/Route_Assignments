using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Channels;

namespace Route_Assignments
{
    internal class Assignment_Session4
    {
        static void Main(string[] args)
        {
            #region Q1 print yes or no 
            //int number = int.Parse(Console.ReadLine());
            //if (number % 3 == 0 && number % 4 == 0) Console.WriteLine("Yes");
            //else Console.WriteLine("No");
            #endregion

            #region Q2 Negative Or Positive
            //int number = int.Parse(Console.ReadLine());
            //if (number < 0) Console.WriteLine("negative");
            //else if (number > 0) Console.WriteLine("positive");    
            #endregion

            #region Q3 max and min
            // using max and min function 
            //int n1 = int.Parse(Console.ReadLine());
            //int n2 = int.Parse(Console.ReadLine());
            //int n3 = int.Parse(Console.ReadLine());


            //int maxx = Math.Max(n1, Math.Max(n2, n3));
            //int minn = Math.Min(n1, Math.Min(n2, n3));
            //Console.WriteLine($"Max element = {maxx}");
            //Console.WriteLine($"Min element = {minn}");

            // using if and else if 
            //int n1 = int.Parse(Console.ReadLine());
            //int n2 = int.Parse(Console.ReadLine());
            //int n3 = int.Parse(Console.ReadLine());

            //int maxx, minn;

            //if (n1 >= n2 && n1 >= n3) maxx = n1;
            //else if (n2 >= n1 && n2 >= n3) maxx = n2;
            //else maxx= n3;

            //if (n1 <= n2 && n1 <= n3) minn = n1;
            //else if (n2 <= n1 && n2 <= n3) minn = n2;
            //else minn = n3;

            //Console.WriteLine($"Max element = {maxx}");
            //Console.WriteLine($"Min element = {minn}");
            #endregion

            #region Q4 Even or Odd
            //int number = int.Parse(Console.ReadLine());
            //if (number % 2 == 0) Console.WriteLine("Even");
            //else Console.WriteLine("Odd");
            #endregion

            #region Q5 Vowel Or Consonant
            //char c = char.Parse(Console.ReadLine());
            //if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u') Console.WriteLine("Vowel");
            //else Console.WriteLine("Consonant");
            #endregion

            #region Q6 All numbers between 1 to the given number
            //int number = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= number; i++) Console.Write($"{i} ");
            #endregion

            #region Q7 Multiplication table up to 12
            //int number = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 12; i++) Console.Write($"{i * number} ");
            #endregion

            #region Q8 All even numbers between 1 and the given number
            //int number = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= number; i++)
            //{
            //    if (i % 2 == 0) Console.Write($"{i} ");
            //}
            #endregion

            #region Q9 The power
            //int n1 = int.Parse(Console.ReadLine());
            //int n2 = int.Parse(Console.ReadLine());

            //int power = (int)Math.Pow(n1, n2);
            //Console.WriteLine(power);
            #endregion

            #region Q10 Calculate total , average and percentage
            //Console.Write("Enter Marks of five subjects: ");
            //int marks = 5;
            //int total = 0;
            //for (int i = 1; i <= marks; i++)
            //{
            //    int mark = int.Parse(Console.ReadLine());
            //    total += mark;
            //}
            //int average = total / marks;
            //int percentage = (total / (marks * 100)) * 100;
            //Console.WriteLine($"Total Marks = {total}");
            //Console.WriteLine($"Average Marks = {average}");
            //Console.WriteLine($"Percentage = {percentage}");
            #endregion

            #region Q11 The number of days in the given Month
            //Console.Write($"Month Number: ");
            //int monthNumber = int.Parse(Console.ReadLine());
            //int days = 0;
            //switch (monthNumber)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        days = 31;
            //        break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        days = 30;
            //        break;
            //    case 2:
            //        days = 28;
            //        break;
            //}
            //Console.WriteLine($"Days in Month: {days}");
            #endregion

            #region Q12 Creation A simple calculator
            //Console.WriteLine("Select: ");
            //Console.WriteLine("1. Add");
            //Console.WriteLine("2. Subtract");
            //Console.WriteLine("3. Multiply");
            //Console.WriteLine("4. Divide");

            //Console.Write("Enter the number of the operation: ");
            //int operation = int.Parse(Console.ReadLine());
            //Console.Write("Enter the first number: ");
            //double n1 = double.Parse(Console.ReadLine());
            //Console.Write("Enter the second number: ");
            //double n2 = double.Parse(Console.ReadLine());
            //double res = 0;
            //switch (operation)
            //{
            //    case 1:
            //        res = n1 + n2;
            //        Console.WriteLine($"Result: {res}");
            //        break;
            //    case 2:
            //        res = n1 - n2;
            //        Console.WriteLine($"Result: {res}");
            //        break;
            //    case 3:
            //        res = n1 * n2;
            //        Console.WriteLine($"Result: {res}");
            //        break;
            //    case 4:
            //        res = n1 / n2;
            //        Console.WriteLine($"Result: {res}");
            //        break;
            //}
            #endregion

            #region Q13 print the reverse of string  
            //string s = Console.ReadLine();
            //for (int i = s.Length - 1; i >= 0; i--) Console.Write(s[i]);
            #endregion

            #region Q14 print the reverse of int 
            //int number = int.Parse(Console.ReadLine());
            //int reverse = 0;
            //while (number > 0)
            //{
            //    int digit = number % 10;
            //    reverse *= 10 + digit;
            //    number /= 10;
            //}
            //Console.WriteLine($"Reversed is : {reverse}");

            // we can use the same code of question 13 that we can input the number as string
            #endregion

            #region Q15 IsPrime
            //bool IsPrime(int number)
            //{
            //    if (number < 2) return false;
            //    for (int i=2; i<= Math.Sqrt(number); i++)
            //    {
            //        if (number % i == 0) return false;
            //    }
            //    return true;
            //}
            //Console.Write("Input starting number of range : ");
            //int start = int.Parse(Console.ReadLine());
            //Console.Write("Input ending number of range : ");
            //int end = int.Parse(Console.ReadLine());

            //for (int i = start; i <= end; i++)
            //{
            //    if (IsPrime(i)) Console.Write($"{i} ");
            //}
            #endregion

            #region Q16 convert to brimary
            // iterative 
            //Console.Write("Enter a number to convert : ");
            //int number = int.Parse(Console.ReadLine());

            //string Sbinary = "";
            //while (number > 0) {
            //    int rd = number % 2;
            //    Sbinary = rd.ToString() + Sbinary;
            //    number /= 2;    
            //}
            //Console.WriteLine(Sbinary);

            //using function
            //int number = int.Parse(Console.ReadLine());
            //string s = Convert.ToString(number, 2);
            //Console.WriteLine($"binary is: {s}");
            #endregion

            #region Q17 single straight line 
            //Console.Write("Enter x1 : ");
            //int x1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter y1 : ");
            //int y1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter x2 : ");
            //int x2 = int.Parse(Console.ReadLine());
            //Console.Write("Enter y2 : ");
            //int y2 = int.Parse(Console.ReadLine());
            //Console.Write("Enter x3 : ");
            //int x3 = int.Parse(Console.ReadLine());
            //Console.Write("Enter y3 : ");
            //int y3 = int.Parse(Console.ReadLine());

            //double area = 0.5 * Math.Abs( ( x1 * (y2 - y3) ) + ( x2 * (y3 - y1) ) + ( x3 * (y1 - y2) ) );
            //if (area == 0) Console.WriteLine("The points lie on a straight line");
            //else Console.WriteLine("The points do not lie on a straight line");
            #endregion

            #region Q18 Time to complete the task
            //Console.Write("Enter the time taken to complete the task: ");
            //int Time = int.Parse(Console.ReadLine());

            //if (Time >= 2 && Time <= 3) Console.WriteLine("Highly Efficient.");
            //else if (Time > 3 && Time <= 4) Console.WriteLine("Increase your speed.");
            //else if (Time > 4 && Time <= 5) Console.WriteLine("You need training to enhance your speed.");
            //else if (Time > 5) Console.WriteLine("You are required to leave the company.");
            //else Console.WriteLine("Invalid time entered.");
            #endregion

            #region Q19  identity matrix using for loop
            //Console.Write("Enter the size of the matrix : ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i<n; i++)
            //{
            //    for(int j=0; j<n; j++)
            //    {
            //        if (i == j) Console.Write("1 ");
            //        else Console.Write("0 ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Q20 the sum of all element in the array
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //for (int i = 0; i<n; i++) arr[i] = int.Parse(Console.ReadLine());
            //int sum = 0;
            //for (int i = 0; i<n; i++) sum += arr[i];
            //Console.WriteLine($"The sum is : {sum}");
            #endregion

            #region Q21 Merge the two arrays in one array and sort this array
            //int n = int.Parse(Console.ReadLine());
            //int[] arr1 = new int[n];
            //int[] arr2 = new int[n];
            //for (int i = 0; i < n; i++) arr1[i] = int.Parse(Console.ReadLine());
            //for (int i = 0; i < n; i++) arr2[i] = int.Parse(Console.ReadLine());
            //int[] mergedarr = new int[2 * n];
            //for (int i = 0; i < n; i++)
            //{
            //    mergedarr[i] = arr1[i];
            //    mergedarr[i + n] = arr2[i];
            //}
            //Array.Sort(mergedarr);
            //Console.Write("Sorted merged array is :");
            //for (int i = 0; i < 2 * n; i++) Console.Write($"{mergedarr[i]} ");
            #endregion

            #region Q22 the frequency of each element
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //for (int i = 0; i < n; i++) arr[i] = int.Parse(Console.ReadLine());
            //bool[] flag = new bool[n];
            //Console.WriteLine("Frequency of each element:");
            //for (int i = 0; i < n; i++)
            //{
            //    if (!flag[i])
            //    {
            //        int counter = 1;
            //        for (int j = i + 1; j < n; j++)
            //        {
            //            if (arr[i] == arr[j])
            //            {
            //                counter++;
            //                flag[j] = true;
            //            }
            //        }
            //        Console.WriteLine($"Element {arr[i]} appears {counter} time(s).");
            //    }
            //}
            #endregion

            #region Q23 find the max and min of an array
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //for (int i = 0; i < n; i++) arr[i] = int.Parse(Console.ReadLine());

            //int maxx = arr.Max();
            //int minn = arr.Min();
            //Console.WriteLine($"Maximum element in the array is : {maxx}");
            //Console.WriteLine($"Minimum element in the array is : {minn}");
            #endregion

            #region Q24 The second Max element array in array
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //for (int i = 0; i < n; i++) arr[i] = int.Parse(Console.ReadLine());
            //Array.Sort(arr);
            //int SecondMax = arr[arr.Length - 2];
            //Console.WriteLine(SecondMax);
            #endregion

            #region Q25 the longest distance 
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //for (int i=0; i<n; i++) arr[i] = int.Parse(Console.ReadLine());
            //int maxx = 0;
            //for (int i=0; i<n; i++)
            //{
            //    for (int j=0; j<n; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            int x = j - i; // distance 
            //            maxx = Math.Max(maxx, x);
            //        }
            //    }
            //}
            //Console.WriteLine($"The longest distance is : {maxx}");
            #endregion

            #region Q26 The reverse of a full string 
            //string s = Console.ReadLine();
            //string[] arr = s.Split(' ');
            //Array.Reverse(arr);
            //string s2 = string.Join(" ", arr);
            //Console.WriteLine($"the reversed string is ({s2})");
            #endregion

            #region Q27 copy the first array in second array and print it 
            //int row = int.Parse(Console.ReadLine());
            //int col = int.Parse(Console.ReadLine());

            //int[,] arr1 = new int[row, col];
            //int[,] arr2 = new int[row, col];

            //for (int i = 0; i< row; i++)
            //{
            //    for (int j = 0; j<col; j++)
            //    {
            //        arr1[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < row; i++)
            //{
            //    for (int j = 0; j < col; j++)
            //    {
            //        arr2[i, j] = arr1[i, j];
            //    }
            //}
            //for (int i = 0; i < row; i++)
            //{
            //    for (int j = 0; j < col; j++)
            //    {
            //        Console.WriteLine($"{arr1[i, j]} ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Q28 Reverse the one dimensional array 
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //for (int i = 0; i < n; i++) arr[i] = int.Parse(Console.ReadLine());
            //Array.Reverse(arr);
            //for (int i = 0; i < n; i++) Console.Write($"{arr[i]} ");
            #endregion
        }
    }
}
