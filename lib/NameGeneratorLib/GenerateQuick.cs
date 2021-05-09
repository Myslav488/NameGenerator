using System;
// using NameGenerator;

namespace NameGeneratorLib
{
    public class GenerateQuick : BaseGenerator
    {
        protected override string result{get; set; }
        protected override int length { get; set; }
        private User userro { get; set; }

        public GenerateQuick (User user)
        {
            userro = user;
        }

        public override void SubMenu()
        {
            System.Console.WriteLine("\n \n We've got this. What now? \n");    
            System.Console.WriteLine("#1 <- Reapet");
            System.Console.WriteLine("#2 <- Quit to main menu");    
            int choice = int.Parse(Console.ReadLine());
            MessagesHelper.AnimProcess(5); 

            PerformAction(choice);
        
        }
        public override void PerformAction(int choice)
        {
            switch(choice)
            {
                case 1:
                    ShowResult();
                    break;
                case 2:
                    System.Console.WriteLine("Not yet supported");
                    break;
                    
                default:
                    System.Console.WriteLine("You've given wrong number...");
                    break;
            }

        }

        public override void ShowResult()
        {
            Console.Clear();
            System.Console.WriteLine("So then, should it be rather long or not really? (y/n)");
            var recived = Console.ReadLine().ToLower();

            if(recived == "y" || recived == "yeap" || recived =="yes")
            {
                Console.Clear();
                System.Console.WriteLine("How about: \n \n");
                System.Console.WriteLine($"{userro.FirstName}_{userro.SecondName}_{userro.LastName}_19{121-userro.Age}");

            }else{
               Console.Clear();
                System.Console.WriteLine("How about: \n \n");
                System.Console.WriteLine($"{userro.FirstName}_{121-userro.Age}");

            }
            SubMenu();
        }


    }
}