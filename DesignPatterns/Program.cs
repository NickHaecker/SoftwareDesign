using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            UserFactory userFactory = new UserFactory();

            IUser user1 = userFactory.getUser("registereduser");

            user1.playVideo();

            Console.WriteLine("Ende");
        }
    }
}
