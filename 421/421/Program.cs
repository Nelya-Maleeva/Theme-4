using System;

namespace _421
{
    class User
    {
        public int Age { get; set; }
        public int UserID { get; set; }
        public string Name { get; set; }

        public User(int userID, string name, int age)
        {
            UserID = userID;
            Name = name;
            Age = age;
        }
        public void PrintInfo()
        {
            Console.WriteLine("User ID:" + UserID);
            Console.WriteLine("User name:" + Name);
            Console.WriteLine("Age:" + Age);
        }
        public static void ChangeUserAge(User user, int NewAge)
        {
            user.Age = NewAge;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User(1, "Nelya", 35);
            user.PrintInfo();
            User.ChangeUserAge(user, 25);
            user.PrintInfo();
            Console.ReadLine();
        }

    }
}
