using static Assignment.ListGenerator;
namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Aggregate Operators Linq 1
            #region Q1
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Count(p => p % 2 == 1);
            #endregion
            #region Q2
            //var result = CustomersList.Select(c => new {name=c.CustomerName,orders=c.Orders.Count()}) ;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q3
            //var result = ProductsList.GroupBy(p=>p.Category).Select(p=>new { Category =p.Key,product = p.Count() });
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Category} => {item.product}");
            //}
            #endregion
            #region Q4
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Sum();
            #endregion
            #region Q5
            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //var result = words.Sum(w=>w.Length);
            #endregion
            #region Q6
            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //var result =words.Min(w => w.Length);
            #endregion
            #region Q7
            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //var result = words.Max(w => w.Length);
            #endregion
            #region Q8
            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //var result = words.Average(w => w.Length);
            #endregion
            //Console.WriteLine(result);
            #endregion
            #region LINQ - Aggregate Operators
            #region Q1
            //var result = ProductsList.Where(p => p.UnitsInStock > 0).GroupBy(p=>p.Category).Select(p => new { Category = p.Key, product = p.Count() });

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Category} => {item.product}");
            //}
            #endregion
            #region Q2
            //var result = ProductsList.GroupBy(p => p.Category).Select(p => new { Category = p.Key, MinPrice = p.Min(p=>p.UnitPrice)});
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Category} => {item.MinPrice}");
            //}
            #endregion
            #region Q4
            //var result = ProductsList.GroupBy(p => p.Category).Select(p => new { Category = p.Key, MinPrice = p.Max(p => p.UnitPrice) });
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Category} => {item.MinPrice}");
            //}
            #endregion
            #region Q6
            //var result = ProductsList.GroupBy(p => p.Category).Select(p => new { Category = p.Key, MinPrice = p.Average(p => p.UnitPrice) });
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Category} => {item.MinPrice}");
            //}
            #endregion
            #endregion
            #region LINQ - Set Operators
            #region Q1
            //var result = ProductsList.Select(p => p.Category).Distinct();
            #endregion
            #region Q2
            //var result = ProductsList.Select(p => p.ProductName[0]).Union(CustomersList.Select(c => c.CustomerName[0]));
            #endregion
            #region Q3
            //var result = ProductsList.Select(p => p.ProductName[0]).Intersect(CustomersList.Select(c => c.CustomerName[0])).Distinct();
            #endregion
            #region Q4
            //var result = ProductsList.Select(p =>p.ProductName[0]).Except(CustomersList.Select(c => c.CustomerName[0])).Distinct();
            #endregion
            #region Q5
            //var result = ProductsList.Select(p => p.ProductName.Substring(p.ProductName.Length - 3))
            //    .Concat(CustomersList.Select(c => c.CustomerName.Substring(c.CustomerName.Length - 3)));
            #endregion
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region LINQ - Partitioning Operators
            #region Q1
            //var result = CustomersList.Where(c => c.Country == "Washington").SelectMany(c=>c.Orders).Take(3);

            #endregion
            #region Q2

            #endregion
            #region Q3
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.TakeWhile((num, index) => num >= index);
            #endregion
            #region Q4
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.SkipWhile(num => num % 3 != 0);
            #endregion
            #region Q5
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.SkipWhile((num, index) => num > index);
            #endregion
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region LINQ - Quantifiers
            #region Q1
            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //var result = words.Any(w => w.Contains("ei"));
            //Console.WriteLine(result);
            #endregion
            #region Q2
            //var result = ProductsList.GroupBy(p => p.Category).Where(p=>p.Any(p=>p.UnitsInStock==0))
            //    .Select(p=> new {category=p.Key, products=p.ToList() });
            #endregion
            #region Q3
            //var result = ProductsList.GroupBy(p => p.Category).Where(p => p.All(p => p.UnitsInStock > 0))
            //.Select(p => new{ category = p.Key, products = p.ToList() });
            #endregion
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Category: {item.category}");
            //    foreach (var item1 in item.products)
            //    {
            //        Console.WriteLine($"{item1.ProductName}=>{item1.UnitsInStock}");
            //    }
            //}
            #endregion
            #region LINQ – Grouping Operators
            #region Q1
            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //var result = numbers.GroupBy(n => n % 5);
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"numbers with a remainder {item.Key} when divided by 5:");
            //    foreach (var item1 in item)
            //    {
            //        Console.WriteLine(item1);
            //    }
            //}
            #endregion
            #region Q2
            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //var result = words.GroupBy(w => w.FirstOrDefault());
            //foreach (var item in result)
            //{
            //    Console.WriteLine($" word start with {item.Key}");
            //    foreach (var item1 in item)
            //    {
            //        Console.WriteLine(item1);
            //    }
            //}
            #endregion
            #endregion
        }
    }
}
