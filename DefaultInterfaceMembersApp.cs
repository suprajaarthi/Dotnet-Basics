using System;

namespace DefaultInterfaceMembersApp
{
    class Program
    {
        class InterfaceModifierDemo : IInterfaceModifiers
        {
            public void AbstractDefaultMethod() => Console.WriteLine("Abstract virtual method");
        }
            static void Main(string[] args)
        {
            ICar F1 = new Ferrari();
            F1.Run(200);

            Ferrari ferrari = new Ferrari();
            ((ICar)ferrari).Run(200);


            IInterfaceModifiers i = new InterfaceModifierDemo();
            i.AbstractDefaultMethod();
            i.DefaultMethod();
            i.PublicDefaultMethod();
            i.VirtualDefaultMethod();
        }
    }


    class Ferrari : ICar
    {
        public void Run() => Console.WriteLine("Car is running");
    }
    interface ICar
    {
        void Start() => Console.WriteLine("Car started!");
        void Run();
        public void Run(double carSpeed) => Console.WriteLine($"Car is running at {carSpeed} MPH");

    }

    interface IInterfaceModifiers
    {
        //By Default default method is private  
        virtual void DefaultMethod() => Console.WriteLine("Default method");

        //Private Default Method  
        private void PrivateDefaultMethod() => Console.WriteLine("Private default method");

        //Protected Default Method  
        protected void ProtectedDefaultMethod() => Console.WriteLine("Protected default method");

        // Public Default Method  
        public void PublicDefaultMethod() => Console.WriteLine(" public Default method");

        virtual void VirtualDefaultMethod() => Console.WriteLine("Virtual Default method");

        abstract void AbstractDefaultMethod();
    }
}
