using System;
using library_demo;

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book();
        book1.SetTitle("El rey leon");
        book1.SetAuthor("Chespirito");

        Console.WriteLine(book1.GetBookInfo());
    }
}