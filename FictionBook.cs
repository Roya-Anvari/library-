using System;

namespace MyApp
{
    public  class FictionBook : Book
    {
       public FictionBook(string titel , string auther , int pages , string genre)
       {
        Titel = titel;
        Auther = auther;
        Pages = pages;
        Genre = genre;
       } 
    }
}
