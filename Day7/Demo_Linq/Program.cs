using System.Linq;

namespace Demo_Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Deffered and Immediate Execution
            //List<int> marks = new List<int> { 90, 95, 80, 85,10 };
            ////marks greater than 80
            ////var queryResult = marks.Where(m => m > 80);//deffered execution
            ////To List() method forcing the query to execute
            //var queryResult = marks.Where(m => m > 80).ToList();

            ////change the source
            //marks.Add(82);
            //marks.Add(86);
            //foreach(int mark in queryResult)
            //{
            //    Console.WriteLine(mark);
            //}
            #endregion
            List<int> marks = new List<int> { 10, 20, 60, 25, 35 };
            //List<Product> products = new List<Product>
            //{
            //    new Product{Id=1,Name="HeadPhone",Category="Electronics"},
            //    new Product{Id=2,Name="Toy",Category="Gaming"},
            //    new Product{Id=3,Name="Laptop",Category="Electronics"},
            //};
            List<Product> products1 = new List<Product>
            {
                new Product{Id=1,Name="HeadPhone",Price=2000},
                new Product{Id=2,Name="Toy",Price=5000},
                new Product{Id=3,Name="Laptop",Price=50000}
            };
            List<Category> categories = new List<Category>
            {
                new Category {Id=1,CName="Electronics"},
                new Category {Id=2,CName="Groceries"},
                new Category {Id=4,CName="Mobile"}
            };

            #region filtering
            //Query syntax
            //var evenNumbers =
            //                from num in marks
            //                where num % 2 == 0
            //                select num;
            ////method syntax
            //var methodSyntax = marks.Where(m => m % 2 == 0);

            //foreach(int mark in evenNumbers)
            //{
            //    Console.WriteLine(mark);
            //}
            #endregion

            #region select (Projection)
            //var gracemark =
            //               from num in marks
            //               select num + 10;
            //foreach (var mark in gracemark)
            //{
            //    Console.WriteLine(mark);
            //}
            //var graceMarkMethod = marks.Select(m => m + 10);

            //foreach (var mark in gracemark)
            //{
            //    Console.WriteLine(mark);
            //}
            #endregion
            #region OrderBy
            //var orderedResult =
            //                   from num in marks
            //                   orderby num
            //                   select num;
            //foreach(var mark in orderedResult)
            //{
            //    Console.WriteLine(mark);
            //}
            ////var orderedBYMethodsyntax = marks.OrderBy(m=>m);
            //var orderedBYMethodsyntax = marks.OrderByDescending(m => m);//order by descending
            //foreach (var mark in orderedBYMethodsyntax )
            //{
            //    Console.WriteLine(mark);
            //}

            //var orderDesc =
            //               from mark in marks
            //               orderby mark descending
            //               select mark;
            //foreach (var mark in orderDesc)
            //{
            //    Console.WriteLine(mark);
            //}
            #endregion
            #region GroupBy
            //var categoryWiseProducts =
            //                           from product in products
            //                           group product by product.Category;

            //var categoryByMethod = products.GroupBy(p => p.Category);
            ////Iterating each group
            //foreach(var product in categoryWiseProducts)
            //{
            //    Console.WriteLine($"Group by Category::{product.Key}");
            //    //Inner collection of each group
            //    foreach(var item in product)
            //    {
            //        Console.WriteLine($"Name:: {item.Name}");
            //    }

            //}
            //foreach (var product in categoryByMethod)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion
            #region Inner join
            //var ProductWithCategory =
            //                        from product in products1
            //                        join category in categories on product.Id equals category.Id
            //                        select new { product.Name, category.CName };

            //foreach(var item in ProductWithCategory)
            //{
            //    Console.WriteLine(item);
            //}

            //var productCategoryMethodSyntax = products1.Join(categories,
            //                                                p => p.Id,
            //                                                c => c.Id,
            //                                                (p, c) => new { p.Name, c.CName });
            //foreach (var item in productCategoryMethodSyntax)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region left join
            //var leftJoinResult =
            //                   from product in products1
            //                   join category in categories on product.Id equals category.Id into productCategory
            //                   from pc in productCategory.DefaultIfEmpty()
            //                   select new { product.Name, Category = pc?.CName ?? "Nocategory" };
            //foreach(var item in leftJoinResult)
            //{
            //    Console.WriteLine(item);
            //}

            ////Method syntax
            //var leftJoinByMethod = products1.GroupJoin(
            //    categories,
            //    p => p.Id,
            //    c => c.Id,
            //    (p, categoryGroup) => new { p, categoryGroup }).SelectMany(
            //      temp => temp.categoryGroup.DefaultIfEmpty(),
            //      (temp, cat) => new { temp.p.Name, Category = cat?.CName ?? "No Category" }
            //    );
            //foreach(var item in leftJoinByMethod)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Aggregate Functions
            //count
            //var productCount = products1.Count();
            //Console.WriteLine(productCount);
            ////Sum
            //var totalProductAmount = products1.Sum(p => p.Price);
            //Console.WriteLine(totalProductAmount);
            ////Average
            //var AverageProductAmount = products1.Average(p => p.Price);
            //Console.WriteLine(AverageProductAmount);
            //var highestValuedProduct = products1.Max(p => p.Price);
            //Console.WriteLine(highestValuedProduct);
            //var highestValuedProduct1 = products1.MaxBy(p => p.Price);
            //Console.WriteLine($"Name::{highestValuedProduct1.Name}\tPrice::{highestValuedProduct1.Price}");
            ////get top2 highest valued product
            ////var top2HighestValuedProduct = products1.OrderByDescending(p => p.Price).Take(2);
            //var top2HighestValuedProduct = products1.OrderByDescending(p => p.Price).Skip(1).Take(1);
            //foreach (var item in top2HighestValuedProduct)
            //{
            //    Console.WriteLine(item.Name);
            //}
            #endregion
            //First,FirstOrDefault
            //var firstProduct = products1.First();
            //Console.WriteLine($"Name::{firstProduct.Name}\t Price::{firstProduct.Price}");
            var firstProduct = products1.FirstOrDefault();
            Console.WriteLine($"Name::{firstProduct.Name}\t Price::{firstProduct.Price}");

            var uniqueProductNames = products1.Select(p => p.Name).Distinct();

            //Any And All
            bool result = products1.Any(p => p.Price > 5000);//any one entry matches the condition returns true
            Console.WriteLine(result);
            bool result1 = products1.All(p => p.Price > 5000);//every entry should satisfy the condition
            Console.WriteLine(result1);
        }
        internal class Category
        {
            public int Id { get; set; }
            public string CName { get; set; }
        }

        internal class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            // public string  Category { get; set; }
            public decimal Price { get; set; }

        }
    }
}
