using System.Collections;
using System.Security.Cryptography;
using static Demo.ListGenerator;
using System.Text.RegularExpressions;
namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Aggregate Operators  - Immediate Execution
            #region Count
            //var result = ProductsList.Count();// List property 
            //var result = ProductsList.Count(p=>p.UnitsInStock==0);// Linq Operator
            #endregion
            #region Min-Max
            //var result = ProductsList.Min();
            //System.ArgumentException: At least one object must implement IComparable.
            //var MinLength = ProductsList.Min(p => p.ProductName.Length);
            //Hybird syntax
            //var result =(from p in ProductsList
            //            where p.ProductName.Length == MinLength
            //            select p).FirstOrDefault();
            #endregion
            #region Sum-Average
            //var result = ProductsList.Sum(p => p.UnitPrice);
            //var result = ProductsList.Average(p => p.UnitPrice);
            #endregion
            #region aggeragte
            //string[] Names = { "aya", "omer", "yousef" };
            //var result =Names.Aggregate((str1,str2)=>$"{str1} {str2}");
            //str1=> aya ,str2=> omer
            //str1=> aya omer , str2=> yousef
            //str1=>aya omer yousef
            #endregion
            //Console.WriteLine(result);
            #endregion
            #region Casting [Conversion] Operators - Immediate Execution
            //List<Product> result = ProductsList.Where(p => p.UnitsInStock == 0).ToList();
            //Product[] result = ProductsList.Where(p => p.UnitsInStock == 0).ToArray();
            //Dictionary<long,Product>result=ProductsList.Where(p=>p.UnitsInStock == 0).ToDictionary(p=>p.ProductID);
            //Dictionary<long,string>result=ProductsList.Where(p=>p.UnitsInStock == 0).ToDictionary(p=>p.ProductID,p=>p.ProductName);
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Key : {item.Key},value : {item.Value}");
            //}
            //HashSet<Product>result =ProductsList.Where(p=>p.UnitsInStock==0).ToHashSet();
            //ArrayList list = new ArrayList() { "yousef","aya",1,2,3,'a'};
            //var result =list.OfType<string>();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Generation Operators - Deferred Execution
            //valid in fluent syntax only // we call it as static method only
            //var result = Enumerable.Range(0, 100); Return New Sequence within Range 
            //var result = Enumerable.Repeat(2, 100); Return IEnumerable of 100 Element each one value = 2
            //var result = Enumerable.Empty<Product>().ToArray(); Return Empty  IEnumerable
            //Generate an empty array of product
            //foreach (var item in result)
            //{
            //    Console.Write($"{item}\t");
            //}
            #endregion
            #region Set Operators [Union Family] - Deferred Execution
            //var Seq1 = Enumerable.Range(0, 100);
            //var Seq2 = Enumerable.Range(50, 100);
            //var result =Seq1.Union(Seq2);
            //var result =Seq1.Concat(Seq2);
            //var result =Seq1.Concat(Seq2).Distinct();
            //var result =Seq1.Intersect(Seq2);
            //var result =Seq1.Except(Seq2);
            //foreach (var item in result)
            //{
            //    Console.Write($"{item}\t");
            //}
            #endregion
            #region Quantifier Operator - Return boolean
            //var result = ProductsList.Any();//if sequence Contains At Least one element => true
            //result = ProductsList.Any(p => p.UnitsInStock == 0);//if sequence contains at least one elemet match the condition => true
            //result = ProductsList.Any(p => p.UnitsInStock == 1000);
            //var result =ProductsList.All(p=>p.UnitsInStock==0);//If All Elements in Sequence Match Condition Will Return True 
            //var Seq1=Enumerable.Range(0, 10);
            //var Seq2=Enumerable.Range(5, 10);
            //var result = Seq1.SequenceEqual(Seq2);//If Two Sequences are Equal Will Return True
            //Console.WriteLine(result);
            #endregion
            #region Zipping Operator - ZIP
            //string[] names = { "aya", "yousef", "mohamed" };
            //int[] numbers = Enumerable.Range(0, 5).ToArray();
            //char[] chars = { 'A', 'Y' };
            //var result =names.Zip(numbers,chars);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Grouping Operators
            #region Get Products Grouped by Category
            //Query syntax
            //var result = from p in ProductsList
            //             group p by p.Category;
            //fluent syntax
            //var result = ProductsList.GroupBy(p => p.Category);
            #endregion
            #region Get Product In Stock Grouped By Category
            //var result = ProductsList.Where(p => p.UnitsInStock > 0).GroupBy(p => p.Category);

            #endregion
            #region Get Products in Stock Grouped by Category That Contains More Than 10 Product
            //Query Syntax
            //var result =from p in ProductsList
            //            where p.UnitsInStock>0
            //            group p by p.Category
            //            into g
            //            where g.Count() > 10
            //            select g;
            //Fluent Syntax
            //var result = ProductsList.Where(p=>p.UnitsInStock > 0).GroupBy(p => p.Category).Where(p=>p.Count()>10);
            #endregion
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var item1 in item)
            //    {
            //        Console.WriteLine(item1);
            //    }
            //}
            #endregion
            #region Partitioning Operators
            //var result = ProductsList.Take(10);//Take 10 of Elements From First Only 
            //result =ProductsList.Where(p=>p.UnitsInStock>0).Take(5);
            //result =ProductsList.Where(p=>p.UnitsInStock>0).TakeLast(5);// Take 5 of Elements From Last Only
            //var result = ProductsList.Skip(10);//Skip 10 of Elements From First Only 
            //result = ProductsList.Where(p => p.UnitsInStock > 0).Skip(5);
            //result = ProductsList.Where(p => p.UnitsInStock > 0).SkipLast(5);// Skip 5 of Elements From Last Only
            //int[] numbers = { 1, 0, 3, 4, 2, 6, 7, 5 };
            //var result = numbers.TakeWhile((number, index) => number > index);
            //var result = numbers.SkipWhile((number, index) => number > index);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Let and Into 
            //[Valid With Query Syntax Only]
            //List<string> list = new List<string>() { "yousef", "aya", "mohamed" };
            //var result = from n in list
            //             select Regex.Replace(n, "[AEIOUaeiou]", string.Empty)
            //             into noVowelName
            //             where noVowelName.Length > 3
            //             select noVowelName;//Restart Query With Introducing A new Range

            //var result = from n in list
            //             let noVowelName = Regex.Replace(n, "[AEIOUaeiou]", string.Empty)
            //             where noVowelName.Length > 3
            //             select noVowelName;//Continue Query With Added A new Range
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
        }
    }
}
