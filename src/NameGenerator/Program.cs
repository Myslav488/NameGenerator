using System;
using System.Threading;
using NameGeneratorLib;

namespace NameGenerator
{
    class Program
    {
        public static User user1 = new User();
        static void Main(string[] args)
        {
            Console.Clear();
            MessagesHelper.Invitations();
            
            // var user1 = new User();
            MessagesHelper.GetUserData(ref user1);
            
            System.Console.WriteLine($"OK {user1.FirstName} so You are born in '{user1.CountShortBornYear()} \n \n");
            System.Console.WriteLine("Aren't You? \n \n");
            
            
            while(true)
            {
                MainMenu();
                Console.Clear();
            }
        }

        public static void MainMenu()
        {
            System.Console.WriteLine("Great, so what would You like to do now? \n");
            System.Console.WriteLine("#1 <- Generate quick nickname accoding to Your personalities");
            System.Console.WriteLine("#2 <- Generate random nickname");
            System.Console.WriteLine("#3 <- Generate some password");
            System.Console.WriteLine("#4 <- Exit \n");
            System.Console.WriteLine("What is Your choice: ");
            int choice = int.Parse(Console.ReadLine());
            MessagesHelper.AnimProcess(3); 

            PerformAction(choice);

        }

        private static void PerformAction(int num)
        {
            switch(num)
            {
                case 1:
                    var rest1 = new GenerateQuick(Program.user1);
                    rest1.PerformAction(1);
                    break;
                case 2:
                    var rest2 = new GenerateRandom();
                    rest2.ShowResult();
                    break;
                case 3:
                    var rest3 = new GeneratePassword();
                    rest3.ShowResult();
                    break;                                      
                case 4:
                    ExitApp();
                    break;                
                default:
                    Thread.Sleep(2000);
                    System.Console.WriteLine("You've given wrong number...");
                    break;
            }
        }  

        private static void ExitApp()
        {
            MessagesHelper.GoodBye(); 
            Environment.Exit(0);
        }
    }
   
}
