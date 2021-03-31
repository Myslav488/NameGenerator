using System;
using System.Threading;

namespace NameGeneratorLib
{
    public class MessagesHelper
    {
        public static void Invitations()
        {
            Console.WriteLine("############### \n \n");
            Console.WriteLine("Hello World! \n \n");
            Console.WriteLine("###############");
            
            Thread.Sleep(2000);
            Console.Clear();
        }

        public static void GetUserData(ref User user_x)
        {
            System.Console.WriteLine("I want to know something about You");
            System.Console.WriteLine("What's your name?");
            user_x.FirstName = (Console.ReadLine());

            System.Console.WriteLine("What's your second name?");
            user_x.SecondName = (Console.ReadLine());
            
            System.Console.WriteLine("What's your last name?");
            user_x.LastName = (Console.ReadLine());

            System.Console.WriteLine("What's your age?");
            user_x.Age = int.Parse(Console.ReadLine());
            AnimProcess(5);
            Console.Clear();
            
        }
        public static void AnimProcess(int cnt)
        {
            while(cnt>0)
            {   
                Console.Clear();
                System.Console.WriteLine("Processing... /");
                Thread.Sleep(250);
                Console.Clear();
                System.Console.WriteLine("Processing... -");
                Thread.Sleep(250);
                Console.Clear();
                System.Console.WriteLine("Processing... \\");
                Thread.Sleep(250);
                Console.Clear();
                System.Console.WriteLine("Processing... |");
                Thread.Sleep(250);
                cnt--;
            }
        }

        public static void GoodBye()
        {
            Console.Clear();
            Console.WriteLine("############### \n \n");
            System.Console.WriteLine("Thanks for your attention \n \n");
            System.Console.WriteLine("We hope You appreciate our work \n \n");
            Console.WriteLine("###############");
            
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}