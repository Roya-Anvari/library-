using System;

namespace MyApp
{
   public class NonFictionBook : Book
    {
       public NonFictionBook(string titel , string auther , int pages , string topic)
       {
        Titel = titel;
        Auther = auther;
        Pages = pages;
        Topic = topic;
       } 
    }
}