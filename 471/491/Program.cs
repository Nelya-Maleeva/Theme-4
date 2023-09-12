using System;

namespace _491
{
    public abstract class Animal
    {
        public abstract void Sound();
    }
    public class Dog : Animal, IAnimal
    {
        public override void Sound()
        {
            Console.WriteLine("Dog barks.");
        }
        public void Run()
        {
            Console.WriteLine("Dog is running.");
        }
        public void Eat()
        {
            Console.WriteLine("Dog is eating.");
        }

        public void Sleep()
        {
            Console.WriteLine("Dog is sleeping.");
        }
    }
    public class Cat : Animal, IAnimal
    {
        public override void Sound()
        {
            Console.WriteLine("Cat meows.");
        }
        public void Run()
        {
            Console.WriteLine("Cat is running.");
        }
        public void Eat()
        {
            Console.WriteLine("Cat is eating.");
        }

        public void Sleep()
        {
            Console.WriteLine("Cat is sleeping.");
        }
    }
    public interface IAnimal : IRunable, IEatable, ISleepable
    {
    }
    public interface IRunable
    {
        void Run();
    }

    public interface IEatable
    {
        void Eat();
    }

    public interface ISleepable
    {
        void Sleep();
    }
    class Program
    {
        static void Main()
        {
            Dog dog = new Dog();
            Cat cat = new Cat();
                       
            dog.Sound();
            dog.Run();
            dog.Eat();
            dog.Sleep();

            cat.Sound();
            cat.Run();
            cat.Eat();
            cat.Sleep();
        }
    }
}

