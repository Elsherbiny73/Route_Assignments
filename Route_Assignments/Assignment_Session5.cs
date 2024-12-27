using System;
using System.ComponentModel;

namespace Route_Assignments
{
    internal class Route_Assignments
    {
        static void Main(string[] args)
        {
            #region Q1
            // Passing by value vs passing by reference
            // //passing by value: mean that we send a copy of values
            // //passing by reference: mean we send values itself
            //  by value
            // int sum(int x, int y)
            // {
            //     return x + y;
            // }
            // int a = 6, b = 7;
            // Console.WriteLine(sum(a, b));
            //  by reference
            // int sum2(ref int x, ref int y)
            // {
            //     return x + y;
            // }
            // Console.WriteLine(sum2(ref a, ref b));

            #endregion
            #region Q2
            //passing reference type by value: if i suppose that i pass an array this mean the array in the funcion
            //                                 point on the same location in heap and any change will happen, main array will change also and if i make new array in the function the main array not affected
            // passing reference type by reference: this mean is end the array itself and the array in the function not created a new stack fram
            //                                      because it is the same of main array and if i make new array the main array will affeted and change the location of it 
            //EX reference by value
            // int sum(int[] arr) // {1,2,3}
            // {
            //     arr[0] = 100;
            //     arr=new int[] {100,200,300}; // this mean main array not change 
            //     int result = 0;
            //     for(int i = 0; i < arr.Length; i++)result+= arr[i];
            //     return result; // will be 105
            // }
            //if i get the sum of the main array it still 105 after all changes 
            //EX reference by reference
            // int sum2(ref int[] arr) // {1,2,3}
            // {
            //     arr[0] = 100;
            //     arr=new int[] {100,200,300}; // this mean main array will be change 
            //     int result = 0;
            //     for(int i = 0; i < arr.Length; i++)result+= arr[i];
            //     return result; // will be 105 
            // }
            // if i get the sum of the main array it will be 600 after all changes 
            #endregion
            #region Q3
            //
            // (int,int) summation(int n1, int n2, int n3, int n4)
            // {
            //     return ((n1 + n2), (n3 + n4));
            //   
            // }
            #endregion
            #region Q4

            // int sumdigits(int n)
            // {
            //     int sum = 0;
            //     while (n > 0)
            //     {
            //          sum+=n % 10;
            //         n = n / 10;
            //     }
            //
            //     return sum;
            // }
            //
            // Console.WriteLine(sumdigits(25));
            #endregion
            #region Q5

            // bool IsPrime(int n)
            // {
            //     if (n < 2) return false;
            //     for (int i = 2; i <= Math.Sqrt(n); i++)
            //     {
            //         if (n % i == 0) return false;
            //     }
            //     return true;
            // }
            // Console.WriteLine(IsPrime(2));
            #endregion
            #region Q6

            // (int, int) MinAndMax(ref int[] arr)
            // {
            //     int mine=Int32.MaxValue;
            //     int maxe=Int32.MinValue;
            //     for (int i = 0; i < arr.Length; i++)
            //     {
            //         if(arr[i]<mine)mine=arr[i];
            //         if(arr[i]>maxe)maxe=arr[i];
            //     }
            //     return (mine, maxe);
            // }
            #endregion
            #region Q7

            // int factorial(int n)
            // {
            //     int temp = 1;
            //     for (int i = 1; i <= n; i++)
            //     {
            //         temp *= i;
            //     }
            //
            //     return temp;
            // }
            //
            // Console.WriteLine(factorial(5));
            #endregion
            #region Q8

            // void ChangChar(int index, char c)
            // {
            //     string s = "adel";
            //     char[] charArray = s.ToCharArray();
            //     charArray[index] = c;             
            //     s = new string(charArray);
            //     Console.WriteLine(s);
            // }
            // ChangChar(1,'o');
            #endregion
            
        }
    }
}
