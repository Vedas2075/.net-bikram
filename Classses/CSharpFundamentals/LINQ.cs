//Language Integrated Query (LINQ)
using  System.Linq;
using System.collection.Generic;

public class Query
{
    byte[] ages = {22,43,56,72,12,32,22,33,44,55,77,65};
     
     list<person> people new()
     {
         new Person { Name = "Ram",Address = "ktm", Gen ="m"}
         new Person { Name = "haiRam",Address = "ktm", Gen ="m"}
         new Person { Name = "hariRam",Address = "Drn", Gen ="m"}
         new Person { Name = "Ramesh",Address = "ktm", Gen ="m"}
         new Person { Name = "Ramsey",Address = "Drn", Gen ="m"}
         new Person { Name = "Ramkumar",Address = "ktm", Gen ="m"}
        };



     public void Test()
     {
         //list the odd numbers
         var oddNumbers = numbers.where(number => number %2 ! = 0);


         //List all number greater than 50
         var numbersGreaterThan50 = numbers.where(x => x > 50 && x % 2 == 0);
         numbersGreaterThan50 = from num in numbers
                         where num > 50 && num % 2 == 0
                         select num;
         
         //Get square of all elements
         var squares = numbers.select(y => y * y);

         //check if collections have number greater than 100
         var x = numbers.Any(x => x > 100);
         var y = numbers.All(x => x > 100);

         //skip and take
         var z =numbers.Skip(5).Take(4);

         //ordering
         var orderedNumbers = numbers.OrderBy(x => x).select(x => x);
         
         //Expression Syntax
         var oddNumbers1 = from number in numbers
                        orderby x
                        select x;

         //list all persons who lives in kathmandu
         var ktmNiwasi = people.where(x => x.Address =="ktm");


         //list the name start with alphabet H







     }

     


}