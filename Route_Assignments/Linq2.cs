using System.Collections;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace Assignments
{
    internal class Program
    {
        #region ListGenerator
        class Product
        {
            public long ProductID { get; set; }
            public string ProductName { get; set; }
            public string Category { get; set; }
            public decimal UnitPrice { get; set; }
            public int UnitsInStock { get; set; }


            public override string ToString()
                => $"ProductID: {ProductID}, ProductName: {ProductName}, Category: {Category}, UnitPrice: {UnitPrice:c}, UnitsInStock: {UnitsInStock}";

        }
        class Customer
        {
            public string CustomerID { get; set; }
            public string CustomerName { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string Region { get; set; }
            public string PostalCode { get; set; }
            public string Country { get; set; }
            public string Phone { get; set; }
            public string Fax { get; set; }
            public Order[] Orders { get; set; }
            public Customer(string customerID, string customerName)
            {
                CustomerID = customerID;
                CustomerName = customerName;
                Orders = new Order[10];
            }
            public Customer()
            {

            }
            public override string ToString()
                => $"{CustomerID}, {CustomerName}, {Address}, {City}, {Region}, {PostalCode}, {Country}, {Phone}, {Fax}";
        }
        class Order
        {

            public int OrderID { get; set; }
            public DateTime OrderDate { get; set; }
            public decimal Total { get; set; }

            public Order(int orderID, DateTime orderDate, decimal total)
            {
                OrderID = orderID;
                OrderDate = orderDate;
                Total = total;
            }
            public Order()
            {

            }

            public override string ToString()
                => $"Order Id: {OrderID}, Date: {OrderDate.ToShortDateString()}, Total: {Total}";
        }
        internal static class ListGenerator
        {
            public static List<Product> ProductList { get; set; }
            public static List<Customer> CustomerList { get; }

            static ListGenerator()
            {
                ProductList = new List<Product>()
                {
                      new Product() {ProductID = 1, ProductName = "Chai", Category = "Beverages",
                            UnitPrice = 18.00M, UnitsInStock = 100},
                      new Product{ ProductID = 2, ProductName = "Chang", Category = "Beverages",
                        UnitPrice = 19.0000M, UnitsInStock = 17 },
                      new Product{ ProductID = 3, ProductName = "Aniseed Syrup", Category = "Condiments",
                        UnitPrice = 10.0000M, UnitsInStock = 13 },
                      new Product{ ProductID = 4, ProductName = "Chef Anton's Cajun Seasoning", Category = "Condiments",
                        UnitPrice = 22.0000M, UnitsInStock = 53 },
                      new Product{ ProductID = 5, ProductName = "Chef Anton's Gumbo Mix", Category = "Condiments",
                        UnitPrice = 21.3500M, UnitsInStock = 0 },
                      new Product{ ProductID = 6, ProductName = "Grandma's Boysenberry Spread", Category = "Condiments",
                        UnitPrice = 25.0000M, UnitsInStock = 120 },
                      new Product{ ProductID = 7, ProductName = "Uncle Bob's Organic Dried Pears", Category = "Produce",
                        UnitPrice = 30.0000M, UnitsInStock = 15 },
                      new Product{ ProductID = 8, ProductName = "Northwoods Cranberry Sauce", Category = "Condiments",
                        UnitPrice = 40.0000M, UnitsInStock = 6 },
                      new Product{ ProductID = 9, ProductName = "Mishi Kobe Niku", Category = "Meat/Poultry",
                        UnitPrice = 97.0000M, UnitsInStock = 29 },
                      new Product{ ProductID = 10, ProductName = "Ikura", Category = "Seafood",
                        UnitPrice = 31.0000M, UnitsInStock = 31 },
                      new Product{ ProductID = 11, ProductName = "Queso Cabrales", Category = "Dairy Products",
                        UnitPrice = 21.0000M, UnitsInStock = 22 },
                      new Product{ ProductID = 12, ProductName = "Queso Manchego La Pastora", Category = "Dairy Products",
                        UnitPrice = 38.0000M, UnitsInStock = 86 },
                      new Product() { ProductID = 13, ProductName = "Konbu", Category = "Seafood",
                        UnitPrice = 6.0000M, UnitsInStock = 24 },
                      new Product() { ProductID = 14, ProductName = "Tofu", Category = "Produce",
                        UnitPrice = 23.2500M, UnitsInStock = 35 },
                      new Product() { ProductID = 15, ProductName = "Genen Shouyu", Category = "Condiments",
                        UnitPrice = 15.5000M, UnitsInStock = 39 },
                      new Product() { ProductID = 16, ProductName = "Pavlova", Category = "Confections",
                        UnitPrice = 17.4500M, UnitsInStock = 29 },
                      new Product() { ProductID = 17, ProductName = "Alice Mutton", Category = "Meat/Poultry",
                        UnitPrice = 39.0000M, UnitsInStock = 0 },
                      new Product() { ProductID = 18, ProductName = "Carnarvon Tigers", Category = "Seafood",
                        UnitPrice = 62.5000M, UnitsInStock = 42 },
                      new Product() { ProductID = 19, ProductName = "Teatime Chocolate Biscuits", Category = "Confections",
                        UnitPrice = 9.2000M, UnitsInStock = 25 },
                      new Product() { ProductID = 20, ProductName = "Sir Rodney's Marmalade", Category = "Confections",
                        UnitPrice = 81.0000M, UnitsInStock = 40 },
                      new Product() { ProductID = 21, ProductName = "Sir Rodney's Scones", Category = "Confections",
                        UnitPrice = 10.0000M, UnitsInStock = 3 },
                      new Product() { ProductID = 22, ProductName = "Gustaf's Knäckebröd", Category = "Grains/Cereals",
                        UnitPrice = 21.0000M, UnitsInStock = 104 },
                      new Product() { ProductID = 23, ProductName = "Tunnbröd", Category = "Grains/Cereals",
                        UnitPrice = 9.0000M, UnitsInStock = 61 },
                      new Product() { ProductID = 24, ProductName = "Guaraná Fantástica", Category = "Beverages",
                        UnitPrice = 4.5000M, UnitsInStock = 20 },
                      new Product() { ProductID = 25, ProductName = "NuNuCa Nuß-Nougat-Creme", Category = "Confections",
                        UnitPrice = 14.0000M, UnitsInStock = 76 },
                      new Product() { ProductID = 26, ProductName = "Gumbär Gummibärchen", Category = "Confections",
                        UnitPrice = 31.2300M, UnitsInStock = 15 },
                      new Product() { ProductID = 27, ProductName = "Schoggi Schokolade", Category = "Confections",
                        UnitPrice = 43.9000M, UnitsInStock = 49 },
                      new Product() { ProductID = 28, ProductName = "Rössle Sauerkraut", Category = "Produce",
                        UnitPrice = 45.6000M, UnitsInStock = 26 },
                      new Product() { ProductID = 29, ProductName = "Thüringer Rostbratwurst", Category = "Meat/Poultry",
                        UnitPrice = 123.7900M, UnitsInStock = 0 },
                      new Product() { ProductID = 30, ProductName = "Nord-Ost Matjeshering", Category = "Seafood",
                        UnitPrice = 25.8900M, UnitsInStock = 10 },
                      new Product() { ProductID = 31, ProductName = "Gorgonzola Telino", Category = "Dairy Products",
                        UnitPrice = 12.5000M, UnitsInStock = 0 },
                      new Product() { ProductID = 32, ProductName = "Mascarpone Fabioli", Category = "Dairy Products",
                        UnitPrice = 32.0000M, UnitsInStock = 9 },
                      new Product() { ProductID = 33, ProductName = "Geitost", Category = "Dairy Products",
                        UnitPrice = 2.5000M, UnitsInStock = 112 },
                      new Product() { ProductID = 34, ProductName = "Sasquatch Ale", Category = "Beverages",
                        UnitPrice = 14.0000M, UnitsInStock = 111 },
                      new Product() { ProductID = 35, ProductName = "Steeleye Stout", Category = "Beverages",
                        UnitPrice = 18.0000M, UnitsInStock = 20 },
                      new Product() { ProductID = 36, ProductName = "Inlagd Sill", Category = "Seafood",
                        UnitPrice = 19.0000M, UnitsInStock = 112 },
                      new Product() { ProductID = 37, ProductName = "Gravad lax", Category = "Seafood",
                        UnitPrice = 26.0000M, UnitsInStock = 11 },
                      new Product() { ProductID = 38, ProductName = "Côte de Blaye", Category = "Beverages",
                        UnitPrice = 263.5000M, UnitsInStock = 17 },
                      new Product() { ProductID = 39, ProductName = "Chartreuse verte", Category = "Beverages",
                        UnitPrice = 18.0000M, UnitsInStock = 69 },
                      new Product() { ProductID = 40, ProductName = "Boston Crab Meat", Category = "Seafood",
                        UnitPrice = 18.4000M, UnitsInStock = 123 },
                      new Product() { ProductID = 41, ProductName = "Jack's New England Clam Chowder", Category = "Seafood",
                        UnitPrice = 9.6500M, UnitsInStock = 85 },
                      new Product() { ProductID = 42, ProductName = "Singaporean Hokkien Fried Mee", Category = "Grains/Cereals",
                        UnitPrice = 14.0000M, UnitsInStock = 26 },
                      new Product() { ProductID = 43, ProductName = "Ipoh Coffee", Category = "Beverages",
                        UnitPrice = 46.0000M, UnitsInStock = 17 },
                      new Product() { ProductID = 44, ProductName = "Gula Malacca", Category = "Condiments",
                        UnitPrice = 19.4500M, UnitsInStock = 27 },
                      new Product() { ProductID = 45, ProductName = "Rogede sild", Category = "Seafood",
                        UnitPrice = 9.5000M, UnitsInStock = 5 },
                      new Product() { ProductID = 46, ProductName = "Spegesild", Category = "Seafood",
                        UnitPrice = 12.0000M, UnitsInStock = 95 },
                      new Product() { ProductID = 47, ProductName = "Zaanse koeken", Category = "Confections",
                        UnitPrice = 9.5000M, UnitsInStock = 36 },
                      new Product() { ProductID = 48, ProductName = "Chocolade", Category = "Confections",
                        UnitPrice = 12.7500M, UnitsInStock = 15 },
                      new Product() { ProductID = 49, ProductName = "Maxilaku", Category = "Confections",
                        UnitPrice = 20.0000M, UnitsInStock = 10 },
                      new Product() { ProductID = 50, ProductName = "Valkoinen suklaa", Category = "Confections",
                        UnitPrice = 16.2500M, UnitsInStock = 65 },
                      new Product() { ProductID = 51, ProductName = "Manjimup Dried Apples", Category = "Produce",
                        UnitPrice = 53.0000M, UnitsInStock = 20 },
                      new Product() { ProductID = 52, ProductName = "Filo Mix", Category = "Grains/Cereals",
                        UnitPrice = 7.0000M, UnitsInStock = 38 },
                      new Product() { ProductID = 53, ProductName = "Perth Pasties", Category = "Meat/Poultry",
                        UnitPrice = 32.8000M, UnitsInStock = 0 },
                      new Product() { ProductID = 54, ProductName = "Tourtière", Category = "Meat/Poultry",
                        UnitPrice = 7.4500M, UnitsInStock = 21 },
                      new Product() { ProductID = 55, ProductName = "Pâté chinois", Category = "Meat/Poultry",
                        UnitPrice = 24.0000M, UnitsInStock = 115 },
                      new Product() { ProductID = 56, ProductName = "Gnocchi di nonna Alice", Category = "Grains/Cereals",
                        UnitPrice = 38.0000M, UnitsInStock = 21 },
                      new Product() { ProductID = 57, ProductName = "Ravioli Angelo", Category = "Grains/Cereals",
                        UnitPrice = 19.5000M, UnitsInStock = 36 },
                      new Product() { ProductID = 58, ProductName = "Escargots de Bourgogne", Category = "Seafood",
                        UnitPrice = 13.2500M, UnitsInStock = 62 },
                      new Product() { ProductID = 59, ProductName = "Raclette Courdavault", Category = "Dairy Products",
                        UnitPrice = 55.0000M, UnitsInStock = 79 },
                      new Product() { ProductID = 60, ProductName = "Camembert Pierrot", Category = "Dairy Products",
                        UnitPrice = 34.0000M, UnitsInStock = 19 },
                      new Product() { ProductID = 61, ProductName = "Sirop d'érable", Category = "Condiments",
                        UnitPrice = 28.5000M, UnitsInStock = 113 },
                      new Product() { ProductID = 62, ProductName = "Tarte au sucre", Category = "Confections",
                        UnitPrice = 49.3000M, UnitsInStock = 17 },
                      new Product() { ProductID = 63, ProductName = "Vegie-spread", Category = "Condiments",
                        UnitPrice = 43.9000M, UnitsInStock = 24 },
                      new Product() { ProductID = 64, ProductName = "Wimmers gute Semmelknödel", Category = "Grains/Cereals",
                        UnitPrice = 33.2500M, UnitsInStock = 22 },
                      new Product() { ProductID = 65, ProductName = "Louisiana Fiery Hot Pepper Sauce", Category = "Condiments",
                        UnitPrice = 21.0500M, UnitsInStock = 76 },
                      new Product() { ProductID = 66, ProductName = "Louisiana Hot Spiced Okra", Category = "Condiments",
                        UnitPrice = 17.0000M, UnitsInStock = 4 },
                      new Product() { ProductID = 67, ProductName = "Laughing Lumberjack Lager", Category = "Beverages",
                        UnitPrice = 14.0000M, UnitsInStock = 52 },
                      new Product() { ProductID = 68, ProductName = "Scottish Longbreads", Category = "Confections",
                        UnitPrice = 12.5000M, UnitsInStock = 6 },
                      new Product() { ProductID = 69, ProductName = "Gudbrandsdalsost", Category = "Dairy Products",
                        UnitPrice = 36.0000M, UnitsInStock = 26 },
                      new Product() { ProductID = 70, ProductName = "Outback Lager", Category = "Beverages",
                        UnitPrice = 15.0000M, UnitsInStock = 15 },
                      new Product() { ProductID = 71, ProductName = "Flotemysost", Category = "Dairy Products",
                        UnitPrice = 21.5000M, UnitsInStock = 26 },
                      new Product() { ProductID = 72, ProductName = "Mozzarella di Giovanni", Category = "Dairy Products",
                        UnitPrice = 34.8000M, UnitsInStock = 14 },
                      new Product() { ProductID = 73, ProductName = "Röd Kaviar", Category = "Seafood",
                        UnitPrice = 15.0000M, UnitsInStock = 101 },
                      new Product() { ProductID = 74, ProductName = "Longlife Tofu", Category = "Produce",
                        UnitPrice = 10.0000M, UnitsInStock = 4 },
                      new Product() { ProductID = 75, ProductName = "Rhönbräu Klosterbier", Category = "Beverages",
                        UnitPrice = 7.7500M, UnitsInStock = 125 },
                      new Product() { ProductID = 76, ProductName = "Lakkalikööri", Category = "Beverages",
                        UnitPrice = 18.0000M, UnitsInStock = 57 },
                      new Product() { ProductID = 77, ProductName = "Original Frankfurter grüne Soße", Category = "Condiments",
                        UnitPrice = 13.0000M, UnitsInStock = 32 }
                };
                CustomerList = (from e in XDocument.Load("Customers.xml").Root.Elements("customer")
                                select new Customer()
                                {

                                    CustomerID = (string)e.Element("id"),
                                    CustomerName = (string)e.Element("name"),
                                    Address = (string)e.Element("address"),
                                    City = (string)e.Element("city"),
                                    Region = (string)e.Element("region"),
                                    PostalCode = (string)e.Element("postalcode"),
                                    Country = (string)e.Element("country"),
                                    Phone = (string)e.Element("phone"),
                                    Fax = (string)e.Element("fax"),
                                    Orders = (
                                         from o in e.Elements("orders").Elements("order")
                                         select new Order
                                         {
                                             OrderID = (int)o.Element("id"),
                                             OrderDate = (DateTime)o.Element("orderdate"),
                                             Total = (decimal)o.Element("total")
                                         }).ToArray()
                                }).ToList();
            }
        }
        #endregion
        static void Main(string[] args)
        {
            #region ElementOperators

            #region Q1

            // var Result = ProductList.First(p => p.UnitsInStock == 0);
            // Console.WriteLine(Result);

            #endregion

            #region Q2

            // var Result = ProductList.FirstOrDefault(p => p.UnitPrice > 1000);
            // Console.WriteLine(Result);

            #endregion

            #region Q3
            // int [] Arr = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            // var Result = Arr.Where(p => p > 5).ElementAt(1);
            // Console.WriteLine(Result);
            #endregion
            #endregion

            #region AggregateOperators
            #region Q1
            // int [] Arr = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            // var Result=Arr.Count(a=>a%2!=0);
            // Console.WriteLine(Result);
            #endregion

            #region Q2

            // var Result = CustomerList.Select(a=>new{a.CustomerName,a.CustomerID,OrderCount=a.Orders.Count()});
            // foreach(var c in Result) Console.WriteLine(c);

            #endregion

            #region Q3
            // var Result=ProductList.Select(p=>new{p.Category,count=ProductList.Count(c=>c.Category==p.Category)}).Distinct();
            // foreach(var p in Result) Console.WriteLine($"Category:{p.Category} Count:{p.count}");
            #endregion

            #region Q4
            // int [] Arr = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            // var Result = Arr.Sum();
            // Console.WriteLine(Result);
            #endregion

            #region Q5

            // string[] Arr = File.ReadAllLines("dictionary_english.txt");
            // var Result = Arr.Select(a=>a.Length).Sum();
            // Console.WriteLine(Result);
            #endregion

            #region Q6
            // string[] Arr = File.ReadAllLines("dictionary_english.txt");
            // var Result=Arr.Min(a=>a.Length);
            // Console.WriteLine(Result);
            #endregion

            #region Q7
            // string[] Arr = File.ReadAllLines("dictionary_english.txt");
            // var Result=Arr.Max(a=>a.Length);
            // Console.WriteLine(Result);
            #endregion

            #region Q8
            // string[] Arr = File.ReadAllLines("dictionary_english.txt");
            // var Result = Arr.Select(a => a.Length).Average();
            // Console.WriteLine(Result);

            #endregion

            #region Q9

            // var Result = ProductList.Select(p => new 
            //     { p.Category, Total = ProductList.Where(p2 => p.Category == p2.Category).Sum(p2=>p2.UnitsInStock) }).Distinct();
            // foreach(var p in Result) Console.WriteLine($"Category: {p.Category}, Total: {p.Total}");


            #endregion

            #region Q10

            // var Resutl = ProductList.Select(p => new
            //     { p.Category, CheapestPrice=ProductList.Where(p2 => p2.Category == p.Category).Min(price => price.UnitPrice) }).Distinct();
            // foreach(var p in Resutl) Console.WriteLine(p);
            #endregion

            #region Q11 
            //  لسة البشمهندس مشرحهاش 
            #endregion

            #region Q12

            // var Resutl = ProductList.Select(p => new
            //     { p.Category, ExpensivePrice=ProductList.Where(p2 => p2.Category == p.Category).Max(price => price.UnitPrice) }).Distinct();
            // foreach(var p in Resutl) Console.WriteLine(p);

            #endregion

            #region Q13
            // var Resutl = ProductList.GroupBy(p =>p.Category).Select(p2=> new
            //     { p2.Key, MostExpensivePrice=p2.Where(p3=>p3.UnitPrice==p2.Max(p4 => p4.UnitPrice)) });
            // foreach (var p in Resutl)
            // {
            //     Console.WriteLine($"CategoryName: {p.Key}");
            //     foreach (var product in p.MostExpensivePrice) Console.WriteLine($"ProductName: {product.ProductName} UnitPrice: {product.UnitPrice}");
            // }
            #endregion

            #region Q14
            // var Resutl = ProductList.Select(p => new
            //     { p.Category, AveragePrice=ProductList.Where(p2 => p2.Category == p.Category).Average(price => price.UnitPrice) }).Distinct();
            // foreach(var p in Resutl) Console.WriteLine(p);
            #endregion

            #endregion

            #region SetOperators
            #region Q1

            // var Result = ProductList.Select(p=>p.Category).Distinct();
            // foreach(var category in Result) Console.WriteLine(category);

            #endregion

            #region Q2

            // var Result = ProductList.Select(p => p.ProductName[0]).Union(CustomerList.Select(c => c.CustomerName[0]))
            //     .Distinct();
            // foreach(var letter in Result) Console.WriteLine(letter);

            #endregion

            #region Q3

            // var Result = ProductList.Select(p => p.ProductName[0]).Intersect(CustomerList.Select(c => c.CustomerName[0]));
            // foreach(var letter in Result) Console.WriteLine(letter);
            #endregion

            #region Q4

            // var Result = ProductList.Select(p => p.ProductName[0]).Except(CustomerList.Select(c => c.CustomerName[0]));
            // foreach(var letter in Result) Console.WriteLine(letter);
            #endregion

            #region Q5
            // var Result = ProductList.Select(p => p.ProductName.Substring(p.ProductName.Length-3))
            //     .Concat(CustomerList.Select(c => c.CustomerName.Substring(c.CustomerName.Length-3)));
            // foreach(var letter in Result) Console.Write($"{letter} ");
            #endregion

            #endregion

            #region PartitioningOperators
            #region Q1

            // var Result = CustomerList.Where(c => c.City == "Washington").SelectMany(o => o.Orders).Take(3);
            // foreach(var c in Result) Console.WriteLine(c);
            #endregion

            #region Q2
            // var Result = CustomerList.Where(c => c.City == "Washington").SelectMany(o => o.Orders).Take(2);
            // foreach(var c in Result) Console.WriteLine(c);
            #endregion

            #region Q3
            // int [] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            // var Result = numbers.TakeWhile((num, i) => num > i);
            // foreach(var num in Result) Console.WriteLine(num);

            #endregion

            #region Q4
            // int [] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            // var Result = numbers.SkipWhile(num => num % 3 != 0);
            // foreach(var num in Result) Console.WriteLine(num);

            #endregion

            #region Q5
            // int [] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            // var Result = numbers.SkipWhile((num, i) => num > i);
            // foreach(var number in Result) Console.WriteLine(number);

            #endregion

            #endregion

            #region QuantifiersOperators
            #region Q1
            // string[] Arr = File.ReadAllLines("dictionary_english.txt");
            // var Result = Arr.Any(a => a == "ei");
            // Console.WriteLine(Result);

            #endregion

            #region Q2
            // var Resutl = ProductList.GroupBy(p => p.Category).Where(p2 => p2.Any(p => p.UnitsInStock == 0))
            //     .Select(p3=>new{p3.Key,Products=p3} );
            // foreach (var p in Resutl)
            // {
            //     Console.WriteLine(p.Key);
            //     foreach(var product in p.Products) Console.WriteLine(product);
            // }
            #endregion

            #region Q3
            // var Resutl = ProductList.GroupBy(p => p.Category).Where(p2 => p2.All(p => p.UnitsInStock > 0))
            //     .Select(p3=>new{p3.Key,Products=p3} );
            // foreach (var p in Resutl)
            // {
            //     Console.WriteLine(p.Key);
            //     foreach(var product in p.Products) Console.WriteLine(product);
            // }
            #endregion
            #endregion
        }
    }
}
