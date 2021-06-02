using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.title="Harry Potter";
            book1.author = "JK Rowling";
            book1.pages=400;
            
            Console.WriteLine(book1.author);
            Console.ReadLine();

            Book book2 = new Book();
            book1.title="Lord of the Rings ";
            book1.author = "Tolkein";
            book1.pages=700;

           
        }
    }
}
//OP:

//Enter a number :7
//Enter another number : 0
//Attempted to divide by 0 
