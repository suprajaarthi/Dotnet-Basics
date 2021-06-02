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



// other way 


using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry Potter","JK Rowling",400);

            Book book2 = new Book("Lord of Rings","Tolkein",700);
            book2.title="The hobbit";
            
            Console.WriteLine(book2.title);
           
        }
    }
}
