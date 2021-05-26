using System;

namespace DisposableRefStructsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var book = new Book())
            {
                Console.WriteLine("Hello World!");
            }

            using var book1 = new Book();
        }
    }

    //ref struct Book : IDisposable
    //{
    //    public void Dispose()
    //    {
    //    }
    //}

    ref struct Book
    {
        public void Dispose()
        {
        }
    }
}
