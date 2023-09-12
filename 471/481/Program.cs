using System;

namespace _481
{
    class Car
    {
        protected int quantity;
        protected int warranty;

        public Car(int quantity, int warranty)
        {
            this.quantity = quantity;
            this.warranty = warranty;
        }

        public virtual void GetQuantity()
        {
            Console.WriteLine($"Quantity of cars ready for use: {quantity}");
        }
        public virtual void GetFullInfo()
        {
            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine($"Warranty: {warranty} month");
        }
        public void SetWarranty(int newWarranty)
        {
            warranty = newWarranty;
        }
    }
    class WV : Car
    {
        public WV(int quantity, int warranty) : base(quantity, warranty)
        {
        }
        public override void GetQuantity()
        {
            Console.WriteLine($"WV Cars Ready: {quantity}");
        }

        public override void GetFullInfo()
        {
            Console.WriteLine($"WV Cars: {quantity}, Warranty: {warranty} months");
        }
    }
    class Toyota : Car
    {
        public Toyota(int quantity, int warranty) : base(quantity, warranty)
        {
        }
        public override void GetQuantity()
        {
            Console.WriteLine($"Toyota Cars Ready: {quantity}");
        }
        public override void GetFullInfo()
        {
            Console.WriteLine($"Toyota Cars: {quantity}, Warranty: {warranty} months");
        }
    }
    class Audi : WV
    {
        public Audi(int quantity, int warranty) : base(quantity, warranty)
        {
        }
        public override void GetQuantity()
        {
            Console.WriteLine($"Audi Cars Ready: {quantity}");
        }
        public override void GetFullInfo()
        {
            Console.WriteLine($"Audi Cars: {quantity}, Warranty: {warranty} months");
        }

    }
    class Program
    {
        static void Main()
        {
            Car car = new Car(100, 12);
            car.GetQuantity();
            car.GetFullInfo();
            car.SetWarranty(36);
            car.GetFullInfo();
            Console.WriteLine();

            WV wv = new WV(50, 24);
            wv.GetQuantity();
            wv.GetFullInfo();
            wv.SetWarranty(36);
            wv.GetFullInfo();
            Console.WriteLine();

            Toyota toyota = new Toyota(30, 18);
            toyota.GetQuantity();
            toyota.GetFullInfo();
            toyota.SetWarranty(30);
            toyota.GetFullInfo();
            Console.WriteLine();

            Audi audi = new Audi(20, 18);
            audi.GetQuantity();
            audi.GetFullInfo();
            audi.SetWarranty(36);
            audi.GetFullInfo();
        }
    }
}