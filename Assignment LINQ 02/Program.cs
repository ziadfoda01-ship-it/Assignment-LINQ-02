using LINQ.DataSources;

namespace Assignment_LINQ_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //var result = Source.ProductList.OrderByDescending(p => p.UnitPrice)
            //      .Take(3);

            #endregion
            #region Q2
            //var result = Source.ProductList.Skip(5)
            //    .Take(5);
            #endregion
            #region Q3
            //var result = Source.ProductList .OrderBy(p=>p.UnitPrice)
            //    .TakeWhile(p => p.UnitPrice < 25);
            #endregion
            #region Q4
            //var result = Source.ProductList.Where(p => p.Category == "Seafood")
            //                               .All(p => p.UnitsInStock == 0);
            //Console.WriteLine(result);
            #endregion
            #region  Q5
            //int[] ids = { 3, 9, 13, 18 };
            //var result = ids.Contains(9);
            //Console.WriteLine(result);
            #endregion
            #region Q6
            //var result = Source.ProductList.GroupBy(p => p.Category);
            //foreach (var item in result)

            //    Console.WriteLine(item.Key,item.Count());
            #endregion
            #region Q7
            //var result = Source.ProductList.GroupBy(p => p.Category, p => p.ProductName);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var productName in item)
            //    {
            //        Console.WriteLine(productName);
            //    }
            //}
            #endregion
            #region Q8
            //var result = Source.ProductList.GroupBy(p => p.Category)
            //                   .Where(g => g.Count() > 3)
            //                   .Select(g => new
            //                   {
            //                       CategoryName = g.Key,
            //                       Count= g.Count()
            //                   });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.CategoryName,item.Count);
            //}
            #endregion
            #region Q9
            //var result = from c in Source.CustomerList
            //             group c by c.Country into g
            //             select new
            //             {
            //                 country = g.Key,
            //                 count = g.Count(),
            //                 totalOrderValue = g.Sum(c => c.Orders.Sum(o => o.Total))
            //             };
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{ item.country},{ item.count},{ item.totalOrderValue} ");
            //}
            #endregion
            #region Q10
            //int result = Source.ProductList.Sum(p => p.UnitsInStock);
            //Console.WriteLine(result);
            #endregion
            #region Q11
            //var CheapestPrice = Source.ProductList.Min(p => p.UnitPrice);
            //var MostExpensivePrice = Source.ProductList.Max(p => p.UnitPrice);
            //Console.WriteLine(CheapestPrice);
            //Console.WriteLine(MostExpensivePrice);
            #endregion
            #region Q12
            //var result = Source.ProductList.Select(p => p.Category)
            //                               .Distinct();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q13
            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };
            //var result = setA.Except(setB);
            #endregion
            #region Q14
            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };
            //var result = list1.Except(list2, StringComparer.OrdinalIgnoreCase);
            #endregion
            #region Q15
            //var result = Source.ProductList.ToDictionary(p => p.ProductID);
            //Console.WriteLine(result[18]);

            #endregion
            #region Q16
            //var result = Source.ProductList.First(p => p.UnitPrice > 50);
            //Console.WriteLine(result);
            #endregion
            #region Q17 
            //var rseult = Source.ProductList.FirstOrDefault(p => p.UnitPrice > 500);
            //Console.WriteLine(rseult);
            #endregion
            #region Q18
            //var result = Enumerable.Range(1, 12).Select(n => 7* n);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q19
            //var result = Enumerable.Range(1, 30).Where(n => n % 2 == 0);
            #endregion
            #region Q20
            //var result = Source.ProductList.Take(3).Select(p => p.ProductName)
            //.Concat(Source.CustomerList.Take(3).Select(c => c.CustomerName));


            #endregion
            #region Q21
            //var result = Source.ProductList.Zip(Source.CustomerList, (p, c)
            //    => $"{p.ProductName} Sold To {c.CustomerName}");
            #endregion



            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
