using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Mercedes mer = new Mercedes();
            mer.DisplayInfo();
        }
    }

    class Cars
    {
        private decimal price;
        protected int maxSpeed;
        public string color;

        protected decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public virtual void DisplayInfo()
        {
            price = 10000;
            maxSpeed = 300;
            color = "Black";

            Console.WriteLine($"Default values : price is {price}, max speed is {maxSpeed} and the color is {color}");
        }
    }

    class Mercedes : Cars
    {
        public override void DisplayInfo()
        {
            base.DisplayInfo();

            base.Price = 15000;
            base.color = "blue";
            base.maxSpeed = 200;

            Console.WriteLine($"Overriden values : price is {Price}, max speed is {maxSpeed} and the color is {color}");
        }
    }
}
