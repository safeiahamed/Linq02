using LINQ.DataSources;

namespace LINQ_Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            //var result = Source.ProductList.OrderByDescending(p => p.UnitPrice).Take(3);

            #endregion

            #region Q2

            //var result = Source.ProductList.Skip(5).Take(5);

            #endregion

            #region Q3

            //var result = Source.ProductList.OrderBy(p => p.UnitPrice).TakeWhile(p => p.UnitPrice < 25);

            #endregion

            #region Q4

            //var result = Source.ProductList.Where(p => p.Category == "Seafood").All(p => p.UnitsInStock > 0);
            //Console.WriteLine(result);

            #endregion

            #region Q5

            //int[] ids = { 3, 9, 13, 18 };
            //var result = ids.Contains(9);
            //Console.WriteLine(result);

            #endregion

            #region Q6

            //var result = Source.ProductList.GroupBy(p => p.Category);


            //foreach (var item in result)
            //{
            //    Console.WriteLine($" Category : {item.Key}");
            //    Console.WriteLine($" Category Count :{item.Count()}");
            //    foreach (var value in item)
            //    {
            //        Console.WriteLine(value.ProductName);

            //    }

            //}


            #endregion

            #region Q7

            //var result = Source.ProductList.GroupBy(p => p.Category);

            //foreach (var item in result)
            //{
            //    Console.WriteLine($" Category : {item.Key}");
            //    foreach (var value in item)
            //    {
            //        Console.WriteLine(value.ProductName);

            //    }

            //}
            #endregion

            #region Q8

            //var result =from p in Source.ProductList
            //            group p by p.Category
            //            into Categories
            //            where Categories.Count()>3
            //            select Categories;

            //foreach (var item in result)
            //{
            //    Console.WriteLine($" Category : {item.Key}");
            //    Console.WriteLine($" Category Count :{item.Count()}");
            //    foreach (var value in item)
            //    {
            //        Console.WriteLine(value.ProductName);

            //    }

            //}
            #endregion

            #region Q9
            //var result = from c in Source.CustomerList
            //             group c by c.Country
            //           into G
            //             select new
            //             {
            //                 CountryName = G.Key,
            //                 CountOfCustomers = G.Count(),
            //                 TotalOrderValue = G.Sum(c => c.Orders.Sum(o => o.Total))
            //             };


            #endregion

            #region Q10

            //var result = Source.ProductList.Sum(p => p.UnitsInStock);
            //Console.WriteLine(result);

            #endregion

            #region Q11

            //var result1 = Source.ProductList.Min(p => p.UnitPrice);
            //var result2 = Source.ProductList.Max(p => p.UnitPrice);

            //Console.WriteLine(result1);
            //Console.WriteLine(result2);

            #endregion

            #region Q12

            //var result = Source.ProductList
            //       .Select(p => p.Category)
            //       .Distinct();

            #endregion

            #region Q13

            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };

            //var result = setA.Except(setB);

            #endregion

            #region Q14

            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };

            //var result = list1.Select(c => c.ToLower())
            //                  .Except(list2.Select(c => c.ToLower()));

            #endregion

            #region Q15

            //var result = Source.ProductList.ToDictionary(p => p.ProductID).Where(p => p.Key == 18);

            #endregion

            #region Q16

            //var result = Source.ProductList.First(p => p.UnitPrice > 50);
            //Console.WriteLine(result);

            #endregion

            #region Q17

            //var result = Source.ProductList.FirstOrDefault(p => p.UnitPrice > 500);
            //Console.WriteLine(result);

            #endregion

            #region Q18

            //var result = Enumerable.Range(1, 12)
            //           .Select(n => $"{7} x {n} = {7 * n}");

            #endregion

            #region Q19

            //var result = Enumerable.Range(1, 30).Where(n => n % 2 == 0);

            #endregion

            #region Q20
            //var result = Source.ProductList.Select(p => p.ProductName).Take(3)
            //                   .Concat(
            //                       Source.CustomerList.Select(c => c.Country).Take(3)
            //                   );

            #endregion

            #region Q21
            //var result = Source.ProductList
            //       .Zip(Source.CustomerList,
            //           (p, c) => $"{p.ProductName} sold to {c.CustomerName}");
            #endregion

            #region Session Search

            ////Distinct-->no repeated values / Except ->exist in first but not in second
            //// Union-->all values / interset-->common values


            //var result = Source.ProductList
            //       .Select(p => p.Category)
            //       .Distinct();

            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };
            //var result = setA.Except(setB);

            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };
            //var result = setA.Union(setB);

            int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            int[] setB = { 3, 6, 9, 12, 15, 13 };
            var result = setA.Intersect(setB);
            #endregion


            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }
    }
}
