using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Channels;
using System.Collections;
using System.Numerics;

namespace Route_Assignments
{
    #region Part1Delegates
    public delegate int StringFuncDelegate(string s);
    public delegate bool CompareFuncDelegate(int x, int y);
    public delegate TResult CompareFuncDelegateGenraic<in TE, out TResult>(TE x, TE y);
    #endregion

    #region Part2Delegates
    public delegate TResult FuncDelegetGenaric<in T, out TResult>(T book);
    #endregion

    internal class Program
    {
        public class LibraryEngine
        {
            public static void Processboks<T>(List<T> books, FuncDelegetGenaric<T, string> fptr)
            {
                foreach (T i in books)
                {
                    Console.WriteLine(fptr(i));
                }
            }
        }
        public class SortingAlgorithms<T>
        {
            #region Example1 part1
            // public static void Bubblesort(int[] array, CompareFuncDelegate compare)
            // {
            //     for (int i = 0; i < array.Length; i++)
            //     {
            //         for (int j = 0; j < array.Length - i - 1; j++)
            //         {
            //             if (compare.Invoke(array[j],array[j+1]))
            //                 swap(ref array[j],ref array[j + 1]);
            //         }
            //     }
            // }
            //
            // static void swap(ref int j1, ref int j2)
            // {
            //     int temp = j1;
            //     j1 = j2;
            //     j2 = temp;
            // }
            #endregion

            #region Example2 part1
            public static void Bubblesort(T[] array, CompareFuncDelegateGenraic<T, bool> compare)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length - i - 1; j++)
                    {
                        if (compare.Invoke(array[j], array[j + 1]))
                            swap(ref array[j], ref array[j + 1]);
                    }
                }
            }

            static void swap(ref T j1, ref T j2)
            {
                T temp = j1;
                j1 = j2;
                j2 = temp;
            }

            public static bool CompareGreaterThan(int x, int y)
            {
                return x > y;
            }
            public static bool CompareLowerThan(int x, int y)
            {
                return x < y;
            }
            public static bool CompareStringGreater(string x, string y)
            {
                return x?.Length > y?.Length;
            }
            public static bool CompareStringLower(string x, string y)
            {
                return x?.Length < y?.Length;
            }
            #endregion
        }

        #region class Book
        public class Book
        {
            public string ISBN { get; set; }
            public string Title { get; set; }
            public string[] Author { get; set; }
            public DateTime PublicationDate { get; set; }
            public decimal Price { get; set; }

            public Book(string _isbn, string _title, string[] _author, DateTime _publicationDate, decimal _price)
            {
                ISBN = _isbn;
                Title = _title;
                Author = _author;
                PublicationDate = _publicationDate;
                Price = _price;
            }

            public override string ToString()
            {
                return $"ISBN: {ISBN}, Title: {Title}, Author: {string.Join(", ", Author)}, PublicationDate: {PublicationDate}, Price: {Price}";
            }
        }
        #endregion

        #region BookFunction
        public static class BookFunctions
        {
            public static string GetTitle(Book book)
            {
                return book.Title;
            }

            public static string GetAuthors(Book book)
            {
                return string.Join(", ", book.Author);
            }
            public static string GetPrice(Book book)
            {
                return book.Price.ToString();
            }
        }
        #endregion

        #region class for Q2 part02
        public static class FunctionForPart03
        {
            public static bool CheckExistElementInt(int num1, int num2) => num1 == num2;
            public static bool CheckExistElementString(string num1, string num2) => num1 == num2;
            public static bool CompareElementIntGreater(int num1, int num2) => num1 > num2;
            public static bool CompareElementStringGreater(string num1, string num2) => num1.Length > num2.Length;
            public static bool TrueForAll(int num1, int num2) => num1 == num2;
            public static bool TrueForAll(string num1, string num2) => num1 == num2;
        }
        #endregion

        static void Main(string[] args)
        { 
            #region Example1 part1

            // int[] arr = { 5, 1, 3, 2, 4 };
            // SortingAlgorithms.Bubblesort(arr,SortingAlgorithms.CompareLowerThan);
            // foreach (var i in arr) Console.WriteLine(i);

            #endregion

            #region Example2 part2
            string[] arr = { "youssef", "uo", "dfe", "mohamed" };
            // SortingAlgorithms<string>.Bubblesort(arr,SortingAlgorithms<string>.CompareStringGreater);
            // SortingAlgorithms<string>.Bubblesort(arr,SortingAlgorithms<string>.CompareStringLower);
            //foreach (string  i in arr) Console.WriteLine(i);
            //CompareFuncDelegateGenraic<string, bool> compareFuncDelegateGenraic = SortingAlgorithms<string>.CompareStringGreater;
            //SortingAlgorithms<string>.Bubblesort(arr, compareFuncDelegateGenraic);
            //foreach (string  i in arr) Console.WriteLine(i);
            //int[] arr2 = { 2, 5, 1, 3 };
            //<int>.Bubblesort(arr2, SortingAlgorithms<int>.CompareGreaterThan);
            //foreach (int  i in arr2) Console.WriteLine(i);
            #endregion

            #region Q2 part02

            List<Book> books = new List<Book>()
        {
            new("1","Walter White",new string[]{"Youssef","mahmoud","ElSherbiny"},new DateTime(2004,6,1),1000m),
            new("2","Sciler",new string[]{"Elsherbiny","Youssef","mahmoud"},new DateTime(2004,6,1),12000m)
        };
            // LibraryEngine.Processboks(books,BookFunctions.GetTitle);
            // LibraryEngine.Processboks(books,BookFunctions.GetAuthors);
            // LibraryEngine.Processboks(books,BookFunctions.GetPrice);
            // Func<Book,string> funcdelegate= delegate ( Book book){return book.ISBN;};
            // Console.WriteLine(funcdelegate(books[0]));
            // Func<Book,DateTime> funcdelegate2 = book=> book.PublicationDate;
            // Console.WriteLine(funcdelegate2(books[0]));
            #endregion

            #region Q3
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 5, 5, 8, 9, 10 };
            List<string> list2 = new List<string>() { "youssef", "mahmoud", "elsherbiny", "mohamed" };
            Console.WriteLine(Exist(FunctionForPart03.CheckExistElementInt, 5, list));
            Console.WriteLine(Exist(FunctionForPart03.CheckExistElementString, "youssef", list2));
            Console.WriteLine(Find(FunctionForPart03.CheckExistElementInt, 4, list));
            Console.WriteLine(string.Join(", ", FindAll(FunctionForPart03.CheckExistElementString, "mahmoud", list2)));
            Console.WriteLine(FindIndex(FunctionForPart03.CheckExistElementString, "elsherbiny", list2));
            Console.WriteLine(FindLast(FunctionForPart03.CompareElementIntGreater, 5, list));
            Console.WriteLine(FindLast(FunctionForPart03.CompareElementStringGreater, "youssef", list2));
            Console.WriteLine(FindLastIndex(FunctionForPart03.CheckExistElementInt, 5, list));

            Console.WriteLine(TrueForAll(FunctionForPart03.TrueForAll, 2, list));
            Console.WriteLine(TrueForAll(FunctionForPart03.TrueForAll, "youssef", list2));
            #region Exist

            bool Exist<T>(Func<T, T, bool> predelegate, T num, List<T> list)
            {
                for (int i = 0; i < list.Count; i++)
                    if (predelegate(list[i], num)) return true;
                return false;
            }
            #endregion

            #region Find
            T Find<T>(Func<T, T, bool> funcdelegate, T num, List<T> list)
            {
                for (int i = 0; i < list.Count; i++)
                    if (funcdelegate(list[i], num)) return list[i];
                return default;
            }

            #endregion

            #region FindAll

            List<T> FindAll<T>(Func<T, T, bool> funcdelegate, T num, List<T> list)
            {
                List<T> List = new List<T>();
                for (int i = 0; i < list.Count; i++)
                    if (funcdelegate(list[i], num)) List.Add(list[i]);
                return List;
            }

            #endregion

            #region FindIndex
            int FindIndex<T>(Func<T, T, bool> funcdelegate, T num, List<T> list)
            {
                for (int i = 0; i < list.Count; i++)
                    if (funcdelegate(list[i], num)) return i;
                return -1;
            }


            #endregion

            #region FindLast
            T FindLast<T>(Func<T, T, bool> funcdelegate, T num, List<T> list)
            {
                T last = default;
                for (int i = 0; i < list.Count; i++)
                    if (funcdelegate(list[i], num)) last = list[i];
                return last;
            }
            #endregion

            #region FindLastIndex

            int FindLastIndex<T>(Func<T, T, bool> funcdelegate, T num, List<T> list)
            {
                int lastindex = -1;
                for (int i = 0; i < list.Count; i++)
                    if (funcdelegate(list[i], num)) lastindex = i;
                return lastindex;
            }

            #endregion

            #region Foreach
            // my information about foreach that you should be implement interface IEnumerable to deal with it 
            // and i will wait for the workshop to see how can i handle it 

            #endregion

            #region TrueForAll

            bool TrueForAll<T>(Func<T, T, bool> funcedelegate, T num, List<T> list)
            {
                bool lastindex = true;
                for (int i = 0; i < list.Count; i++)
                    if (!funcedelegate(list[i], num))
                    {
                        lastindex = false;
                        break;
                    }
                return lastindex;
            }

            #endregion
            #endregion
        }
    }
}
