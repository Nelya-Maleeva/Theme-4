using System;

namespace ConsoleApp481
{
    class Car
    {
        protected int quantity;
        protected bool warranty;

        public Car(int quantity, bool warranty)
        {
            this.quantity = quantity;
            this.warranty = warranty;
        }

        public virtual void GetQuantity()
        {
            Console.WriteLine($"Quantity of cars ready for use: {quantity}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
