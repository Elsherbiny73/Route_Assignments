using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Channels;
using System.Collections;
using System.Numerics;

namespace Route_Assignments
{
    internal class Program
          {

        static void Main(string[] args)
        {
            #region Q1 Number that greater than X
            //int N = int.Parse(Console.ReadLine());
            //int Q = int.Parse(Console.ReadLine());

            //string[] arrInput = Console.ReadLine().Split();
            //int[] arr = new int[N];

            //for (int i = 0; i < N; i++)
            //{
            //    arr[i] = int.Parse(arrInput[i]);
            //}

            //for (int i = 0; i < Q; i++)
            //{
            //    int X = int.Parse(Console.ReadLine());
            //    int counter = 0;

            //    foreach (int it in arr)
            //    {
            //        if (it > X)
            //        {
            //            counter++;
            //        }
            //    }
            //    Console.WriteLine(counter);
            //}

            #endregion

            #region Q2 IsPalindrome
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            //bool flag = true;
            //for (int i = 0; i < n / 2; i++)
            //{
            //    if (arr[i] != arr[n - i - 1])
            //    {
            //        flag = false;
            //        break;
            //    }
            //}

            //Console.WriteLine(flag ? "YES" : "NO");
            #endregion

            #region Q3 Reverse Queue
            //Queue<int> queue = new Queue<int>();
            //Stack<int> stack = new Stack<int>();

            //int n = int.Parse(Console.ReadLine());
            //string[] elements = Console.ReadLine().Split();

            //foreach (var element in elements)
            //{
            //    queue.Enqueue(int.Parse(element));
            //}

            //while (queue.Count > 0)
            //{
            //    stack.Push(queue.Dequeue());
            //}

            //while (stack.Count > 0)
            //{
            //    queue.Enqueue(stack.Pop());
            //}

            //Console.WriteLine(string.Join(" ", queue));
            #endregion

            #region Q4 IsBalanced 
            //string s = Console.ReadLine();
            //Stack<char> stack = new Stack<char>();
            //bool isBalanced = true;

            //foreach (char c in s)
            //{
            //    if (c == '(' || c == '{' || c == '[')
            //    {
            //        stack.Push(c);
            //    }
            //    else if (c == ')' || c == '}' || c == ']')
            //    {
            //        if (stack.Count == 0)
            //        {
            //            isBalanced = false;
            //            break;
            //        }

            //        char top = stack.Pop();
            //        if ((c == ')' && top != '(') ||
            //            (c == '}' && top != '{') ||
            //            (c == ']' && top != '['))
            //        {
            //            isBalanced = false;
            //            break;
            //        }
            //    }
            //}

            //if (isBalanced && stack.Count == 0)
            //    Console.WriteLine("Balanced");
            //else
            //    Console.WriteLine("Not Balanced");
            #endregion

            #region Q5 Remove Dublication
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            //HashSet<int> IsExist = new HashSet<int>();
            //List<int> list = new List<int>();

            //foreach (int i in arr)
            //{
            //    if (!IsExist.Contains(i))
            //    {
            //        IsExist.Add(i);
            //        list.Add(i);
            //    }
            //}

            //Console.WriteLine(string.Join(" ", list));
            #endregion

            #region Q6 Remove Odd Numbers from array list
            //int n = int.Parse(Console.ReadLine());
            //ArrayList arrayList = new ArrayList();
            //string[] s = Console.ReadLine().Split();

            //foreach (var i in s)
            //{
            //    arrayList.Add(int.Parse(i));
            //}

            //// Remove odd numbers
            //for (int i = 0;  i < arrayList.Count - 1; i++)
            //{
            //    if ((int)arrayList[i] % 2 != 0)
            //    {
            //        arrayList.RemoveAt(i);
            //    }
            //}
            //Console.WriteLine(string.Join(" ", arrayList.ToArray()));
            #endregion

            #region Q7 Different Data types
            //Queue queue = new Queue();

            //queue.Enqueue(1);        
            //queue.Enqueue("Apple");   
            //queue.Enqueue(5.28);     
            //while (queue.Count > 0)
            //{
            //    Console.WriteLine(queue.Dequeue());
            //}
            #endregion

            #region Q8 found element
            //Stack<int> stack = new Stack<int>();

            //int n = int.Parse(Console.ReadLine());
            //string[] s = Console.ReadLine().Split();

            //foreach (var i in s)
            //{
            //    stack.Push(int.Parse(i));
            //}

            //int target = int.Parse(Console.ReadLine());

            //int counter = 0;
            //bool flag = false;

            //Stack<int> tempStack = new Stack<int>();

            //while (stack.Count > 0)
            //{
            //    int current = stack.Pop();
            //    counter++;

            //    if (current == target)
            //    {
            //        flag = true;
            //        break;
            //    }

            //    tempStack.Push(current);
            //}

            //while (tempStack.Count > 0)
            //{
            //    stack.Push(tempStack.Pop());
            //}

            //if (flag)
            //{
            //    Console.WriteLine($"Target was found successfully and the count = {counter}");
            //}
            //else
            //{
            //    Console.WriteLine("Target was not found");
            //}
            #endregion

            // -> i can't input the numbers as array 
            #region Q9 intersect

            //HashSet<int> nums1 = new HashSet<int>() {1, 2, 4, 5 };
            //HashSet<int> nums2 = new HashSet<int>() {8, 7, 4, 5 };
            //nums1.IntersectWith(nums2);
            //foreach (int i in nums1) Console.Write($"{i} ");
            #endregion

            #region Q10 CurrentSum
            //string input = Console.ReadLine();
            //List<int> arr = new List<int>();
            //foreach (string num in input.Split(' '))
            //{
            //    arr.Add(int.Parse(num));
            //}
            //int target = int.Parse(Console.ReadLine());

            //int currentSum = 0;
            //int start = 0;
            //List<int> result = new List<int>();

            //for (int end = 0; end < arr.Count; end++)
            //{
            //    currentSum += arr[end];

            //    while (currentSum > target && start < end)
            //    {
            //        currentSum -= arr[start];
            //        start++;
            //    }

            //    if (currentSum == target)
            //    {
            //        result.Clear();
            //        for (int i = start; i <= end; i++)
            //        {
            //            result.Add(arr[i]);
            //        }
            //        break;
            //    }
            //}
            //if (result.Count > 0)
            //{
            //    Console.WriteLine(string.Join(", ", result));
            //}
            //else
            //{
            //    Console.WriteLine("No sublist found with the target sum.");
            //}
            #endregion

            #region Q11 reverse if found K
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //Console.Write("Enter the number k -> ");
            //int k = int.Parse(Console.ReadLine());

            //int index = Array.IndexOf(arr, k);

            //if (index != -1)
            //{
            //    Array.Reverse(arr, 0, index+1);
            //}

            //Console.WriteLine("The New Array: " + string.Join(", ", arr));
            #endregion
        }
    }  
}
