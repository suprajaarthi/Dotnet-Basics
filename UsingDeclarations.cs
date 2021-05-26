using System;

namespace UsingDeclarationsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // first step
            //var resource = new Resource();
            //resource.Use();
            //Console.WriteLine("-------");
            //Console.WriteLine("This app is awesome!");

            // second step
            using var resource = new Resource();
            resource.Use();
            Console.WriteLine("-------");
            Console.WriteLine("This app is awesome!");


            //using (var resource = new Resource())
            //{
            //    resource.Use();
            //}
            //// r.Dipose is called
            //Console.WriteLine("-------");
            //Console.WriteLine("This app is awesome!");
        }
    }

    public class Resource : IDisposable
    {
        public void Use() => Console.WriteLine($"Using resource...");
        public void Dispose() => Console.WriteLine($"Disposing resource...");
    }

    // The primary use of this interface is to release unmanaged resources.
    // The garbage collector automatically releases the memory allocated to a managed object when that object is no longer used

}
