using System;

namespace MyApp
{
    internal class Program
    {
        static void Main()
        {
           //creat an array of books with diffrent types
           Book[] Librarycatalog = new Book[]
           {
            new FictionBook("The Great Gatsby " , "F.scott Fitzgerald" , 180 , "Classic"),
            new FictionBook("Dune " , "Frank Herbert" , 412 , "Science Fiction"),
            new NonFictionBook("Spaiens " , "Yuval Noah Harari" , 512 , "History"),
            new NonFictionBook("Atomic Habit " , "James Clear" , 320 , "Self-Help"),
           };
           //Display information about all the books in the library
        library.DisplayBooks(Librarycatalog);
        }
    }
}