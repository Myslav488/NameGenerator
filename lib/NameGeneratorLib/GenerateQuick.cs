using System;


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

        public override void ShowResult()
        {
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
            
        }

    }
}