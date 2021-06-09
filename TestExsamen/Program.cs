using System;
using System.Collections.Generic;
using System.Linq;

namespace TestExsamen
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Category> categories = new List<Category>
            //{
            //    new Category{Id=1, Name="Телевизоры"},
            //    new Category{Id=2, Name="Машины"},
            //    new Category{Id=3, Name="Одежда"},
            //    new Category{Id=4, Name="Продукты"}
            //};
            //List<Product> products = new List<Product>
            //{
            //    new Product{Id=1, Name="LG",CategoryId=1,Cost=100},
            //    new Product{Id=2, Name="BMW",CategoryId=2,Cost=200},
            //    new Product{Id=3, Name="Gucci",CategoryId=3,Cost=300},
            //    new Product{Id=4, Name="Milk",CategoryId=4,Cost=400}
            //};

            //var innerJoinQuery =
            //    from cat in categories
            //    join prod in products
            //    on cat.Id equals prod.CategoryId
            //    select new { ProductName = prod.Name, CategoryName = cat.Name };

            //foreach (var inner in innerJoinQuery)
            //{
            //    Console.WriteLine(inner.CategoryName + ": " + inner.ProductName);
            //}

            //Console.WriteLine("------------------------------");

            //var productQueryLamda =""
            //    products.Select(prod => new { Name = prod.Name, Price = prod.Cost });

            //foreach (var prod in productQueryLamda)
            //{
            //    Console.WriteLine(prod.Name + ": " + prod.Price);
            //}

            //int Count = 10;
            //double Size = 99.99;
            //decimal Price = 1000;

            //string MyString = string.Format("Мне {0} штук диаметром {2} по цене {2:C5}", Count, Size, Price);
            //Console.WriteLine(MyString);


            //Console.WriteLine("\n-\nВывод четных чисел из массива с использованием linq-запроса \n-\n");
            //int[] mass = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //IEnumerable<int> numQuer = from num in mass
            //                          where (num % 2 == 0)
            //                          select num;
            //foreach (var element in numQuer)
            //{
            //    Console.Write(element + " | ");
            //}

            //Console.WriteLine("\n----------------------------------\n");


            //string[] strings = { "один", "два", null, "три" };
            //Console.WriteLine(strings[0]);
            //IEnumerable<string> stringQuery = strings.Where(s => s.Length > 3);

            //foreach(var elem in stringQuery)
            //{
            //    Console.Write(elem + " | ");
            //}

            //List<int> myList = new List<int> { -55,-34,1, 3, 5, 2, 5, 7,-133, 4,-7, 8,0, 22, 32 };
            //IEnumerable<int> queryList = from num in myList
            //                             where (num > 0)
            //                             orderby num
            //                             select num;
            //Console.WriteLine("\n----------------------------------\n");

            //foreach (var elem in queryList)
            //{
            //    Console.Write(elem + " | ");
            //}




            //List<Student> students = new List<Student>
            //{
            //    new Student {Name="Иванов",GroupName="ИСЭбд"},
            //    new Student {Name="Петров",GroupName="ПИбд"},
            //    new Student {Name="Семенов",GroupName="ПИбд"},
            //    new Student {Name="Кривошеев",GroupName="ИСЭбд"},
            //    new Student {Name="Антипов",GroupName="ПИбд"}
            //};

            //var studentGroups = from student in students
            //                    group student by student.GroupName;
   
                
            //foreach (IGrouping<string, Student> g in studentGroups)
            //{
            //    Console.WriteLine(g.Key);
            //    foreach(var t in g )
            //    {
            //        Console.WriteLine(t.Name);
            //    }
            //    Console.WriteLine();
            //}


            //List<int> myList = new List<int> { -55,-34,1, 3, 5, 2, 5, 7,-133, 4,-7, 8,0, 22, 32 };

            //var queryLambda = myList.Where(num => num % 2 != 0);
            //int sum = queryLambda.Count();
            //Console.WriteLine(sum);
            //foreach (var elem in queryLambda)
            //{
            //    Console.Write(elem + " | ");

            //}





            Console.ReadKey();
        }
    }
}
