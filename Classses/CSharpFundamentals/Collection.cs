using system.collections.Generic;

public calss collection
{
    //Simple array
     byte[] ages = {22,43,56,72,12,32,22,33,44,55,77,65};

     //List
     List<string> names = new();
     
     //stack
     Stack<decimal> marks = new();
     //QUEUE
     Queue<short> tokens = new();
     
     Dictionary<string,double> nameMarks = new()
         {
             ["Bikram"] = 45,
             ["Bikram1"] = 58, //key must be unique
             ["Bikram2"] = 23,
         };
    


     void Test()
     {

          names.Add("Bikram");
          names.Remove("Bikram");
          var x = names.contains("Ram");
          
          marks.Push(45.67m); //m for decimal
          var y = marks.Pop();
          
          nameMarks.Add("Ram",12);
          
          Print<int>(56);
          
          //var r = new Guid();
             
     }
     
     void Print<V>(V parameter)
         {
             console.WriteLine(parameter);
         }

         

         

     
}