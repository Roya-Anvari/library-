using System;
using System.Collections.Concurrent;

namespace MyApp
{
   public  class library
    {
       public static void DisplayBooks(Book[] books)
        {
            Console.WriteLine("Hello World!");
            var Fiction = typeof(FictionBook);
            for (int i = 0; i < books.Length; i++)
            {
               var item = books[i].GetType();
               Console.WriteLine("-----------------------"); 
               Console.WriteLine("Titel:" + books[i].Titel); 
               Console.WriteLine("Auther:" +books[i].Auther); 
               Console.WriteLine("Pages:" + books[i].Pages); 
                if (item == Fiction)
                {
                       
                  Console.WriteLine("Genre:" + books[i].Genre); 
                    
                } 
                else
                {
                     Console.WriteLine("Topic:" + books[i].Topic); 
                }
               Console.WriteLine("-----------------------"); 
          
            }
        }
    }
}