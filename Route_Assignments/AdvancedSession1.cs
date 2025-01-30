using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Channels;
using System.Collections;
using System.Numerics;

namespace Route_Assignments
{
    internal class Program
    {
        #region Q1 Bubble sort function 
        /* 
          1- If no swaps occur during a pass, the array is already sorted, and the algorithm can terminate early
          2- Reducing the Range: After each pass, the largest unsorted element is placed in its correct position. So, the range of comparisons can be reduced in subsequent passes.
         */

        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                bool flag = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        flag = true;
                    }
                }
                if (!flag)
                    break;
            }
        }
        #endregion

        #region Q2 Range class
        public class Range<T> where T : IComparable<T>, INumber<T>
        {
            public T Minn { get; set; }
            public T Maxx { get; set; }

            // constructor
            public Range(T minimum, T maximum)
            {
                if (minimum.CompareTo(maximum) > 0)
                {
                    throw new ArgumentException("Minimum value cannot be greater than maximum value.");
                }

                Minn = minimum;
                Maxx = maximum;
            }

            // IsInRange method
            public bool IsInRange(T value)
            {
                return value.CompareTo(Minn) >= 0 && value.CompareTo(Maxx) <= 0;
            }

            // length method -> i use interface INumber<T> to solve the subtraction error 
            public T Length()
            {
                return Maxx - Minn;
            }
        }
        #endregion

        #region Q3 Reverse function
        static void ReverseArrayList(ArrayList arr)
        {
            int l = 0;
            int r = arr.Count-1;
            while (l < r) { 
                int temp = (int)arr[l];
                arr[l] = arr[r];
                arr[r] = temp;
                l++;
                r--;
            }
        }
        #endregion

        #region Q4 EvenNumberList function
        static List<int> EvenNumbers(List<int> numbers)
        {
            List<int> Even = new List<int>();

            foreach (int i in numbers)
            {
                if (i % 2 == 0)
                {
                    Even.Add(i);
                }
            }
            return Even;
        }

        #endregion

        #region Q5 FixedSizeList class
        public class FixedSizeList<T>
        {
            T[] list;
            int counter = 0;
            
            //constructor 
            public FixedSizeList(int capacity)
            {
                if (capacity <= 0)
                    throw new ArgumentException("Capacity must be greater than zero.");

                list = new T[capacity];
            }

            // Method to add an element to the list
            public void Add(T item)
            {
                if (counter >= list.Length)
                    throw new InvalidOperationException("List is full. Cannot add more elements.");

                list[counter++] = item;
            }

            // Method to get an element at a specific index
            public T Get(int index)
            {
                if (index < 0 || index >= counter)
                    throw new IndexOutOfRangeException("Invalid index. Out of range.");

                return list[index];
            }
        }
        #endregion

        #region Q6 String
        public int FirstUniqueChar(string s)
        {
            Dictionary<char, int> freq = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (freq.ContainsKey(c))
                {
                    freq[c]++;
                }
                else
                {
                    freq[c] = 1;
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (freq[s[i]] == 1)
                {
                    return i;
                }
            }
            return -1;
        }
        #endregion
        static void Main(string[] args)
        {
            #region Q1 implement Bubble sort 
            //int[] arr = { 1, 3, 6, 2, 5 };

            //Console.Write("Original array -> ");
            //foreach (int num in arr)
            //{
            //    Console.Write(num + " ");
            //}
            //Console.WriteLine();

            //BubbleSort(arr);

            //Console.Write("Sorted array -> ");
            //foreach (int num in arr)
            //{
            //    Console.Write(num + " ");
            //}
            //Console.WriteLine();
            #endregion

            #region Q2 Range
            //Range<int> intRange = new Range<int>(10, 20);
            //Console.WriteLine("Range -> [10, 20]");
            //Console.WriteLine(intRange.IsInRange(15)); // True
            //Console.WriteLine(intRange.IsInRange(25)); // False
            //Console.WriteLine("Length of range -> " + intRange.Length()); // 10
            #endregion

            #region Q3 Reverse
            //ArrayList arr = new ArrayList {1, 2, 3, 4};
            //Console.Write("Original ArrayList -> ");
            //foreach (var i in arr)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();

            //ReverseArrayList(arr);

            //Console.Write("Reversed ArrayList -> ");
            //foreach (var i in arr)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();
            #endregion

            #region Q4 EvenNumberList
            //List<int> input = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //List<int> evenNumbers = EvenNumbers(input);

            //Console.Write("Even Numbers -> ");
            //foreach (int i in evenNumbers)
            //{
            //    Console.Write(i + " ");
            //}
            #endregion

            #region Q5 FixedSizeList 
            //FixedSizeList<int> list = new FixedSizeList<int>(3); 

            //list.Add(1);
            //list.Add(2);
            //list.Add(3);

            //Console.WriteLine("Element at index 0: " + list.Get(0)); 
            //Console.WriteLine("Element at index 1: " + list.Get(1)); 
            //Console.WriteLine("Element at index 2: " + list.Get(2)); 

            //try
            //{
            //    list.Add(4); // Should throw an exception: List is full
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error: " + ex.Message);
            //}

            //try
            //{
            //    Console.WriteLine(list.Get(5)); // Should throw an exception: Invalid index
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error: " + ex.Message);
            //}
            #endregion

            #region Q6 String
            //Program program = new Program();
            //string s1 = "youssefelsherbiny";
            //Console.WriteLine(program.FirstUniqueChar(s1));  // Output: 1

            //string s2 = "aabb";
            //Console.WriteLine(program.FirstUniqueChar(s2));  // Output: -1
            #endregion



        }
    }
}
