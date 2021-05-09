using System;
using System.Threading;   
using System.Collections.Generic;


namespace NameGeneratorLib
{
    public class GenerateRandom : BaseGenerator
    {
        protected override string result{get; set; }
        protected override int length { get; set; }
        public readonly List<char> Vowels = new List<char>{'a','e','i','o','u','y'};
        public readonly List<char> softCons = new List<char>{'c','f','h','m','p','s','w'};
        public readonly List<char> medCons = new List<char>{'b','k','l','m','n','t','x'};
        public readonly List<char> harshCons = new List<char>{'b','g','j','q','r','v','z'};

        public override void ShowResult()
        {
            Console.Clear();
            System.Console.WriteLine("How about: \n \n ");
            System.Console.WriteLine( GenerateSequences() );

            SubMenu();
        }

        public override void SubMenu()
        {
            System.Console.WriteLine("\n \n We've got this. What now? \n");    
            System.Console.WriteLine("#1 <- Reapet");
            System.Console.WriteLine("#2 <- Quit to main menu");    
            int choice = int.Parse(Console.ReadLine());
            MessagesHelper.AnimProcess(3); 

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

        private string GenerateSequences()
        {
            string result = string.Empty;

            int limit = GetRandomNumber(2, 6); 

            for(int cnt = 0; cnt<limit;cnt++)
            {
               int option = GetRandomNumber(2, 4); 

                result += GenerateSequence(option);
            }
            return FirstToUpper(result);
        }

        private string GenerateSequence(int HowLong)
        {
            string result;

            if(HowLong == 2)
            {
                result = GetSequenceOf2();
                // System.Console.WriteLine(result);
            }
            else if(HowLong == 3)
            {
                result = GetSequenceOf3();
                // System.Console.WriteLine(result);
            } 
            else result = "";

            return result;
        }
        public char GetRandom(List<char> listofchar)
        {
            Random RND = new Random();
            int num = RND.Next(0, listofchar.Count);
            return listofchar[num];
        }

        public char ToUpper(char x)
        {
            return x.ToString().ToUpper().ToCharArray()[0];
        }

        public string FirstToUpper(string x)
        {
            char[] Arrx = x.ToCharArray();            
            Arrx[0].ToString().ToUpper();
            
            return Arrx[0].ToString().ToUpper() + x.Substring(1);
;
        }

        public string GetSequenceOf2()
        {
            int num = GetRandomNumber(0, 5);
            char[] result = new char[2];

            switch (num)
            {
                case 0:
                    result[0] = (GetRandom(Vowels));
                    result[1] = (GetRandom(Vowels));
                    break;
                case 1:
                    result[0] = (GetRandom(Vowels));
                    result[1] = (GetRandom(medCons));
                    break;
                case 2:
                    result[0] = (GetRandom(softCons));
                    result[1] = (GetRandom(Vowels));
                    break;
                case 3:
                    result[0] = (GetRandom(harshCons));
                    result[1] = (GetRandom(Vowels));
                    break;
                case 4:
                    result[0] = (GetRandom(softCons));
                    result[1] = (GetRandom(harshCons));
                    break;
                case 5:
                    result[0] = (GetRandom(medCons));
                    result[1] = (GetRandom(softCons));
                    break;
                default:
                    result[0] = (GetRandom(softCons));
                    result[1] = (GetRandom(softCons));
                    break;
            }
            return new string(result);
        }

        public string GetSequenceOf3()
        {
            int num = GetRandomNumber(0, 5);
            char[] result = new char[3];

            switch (num)
            {
                case 0:
                    result[0] = (GetRandom(Vowels));
                    result[1] = (GetRandom(Vowels));
                    result[2] = (GetRandom(softCons));
                    break;
                case 1:
                    result[0] = (GetRandom(Vowels));
                    result[1] = (GetRandom(medCons));
                    result[2] = (GetRandom(Vowels));

                    break;
                case 2:
                    result[0] = (GetRandom(softCons));
                    result[1] = (GetRandom(softCons));
                    result[2] = (GetRandom(Vowels));
                    break;
                case 3:
                    result[0] = (GetRandom(harshCons));
                    result[1] = (GetRandom(harshCons));
                    result[2] = (GetRandom(Vowels));
                    break;
                case 4:
                    result[0] = (GetRandom(softCons));
                    result[1] = (GetRandom(harshCons));
                    result[2] = (GetRandom(softCons));
                    break;
                case 5:
                    result[0] = (GetRandom(Vowels));
                    result[1] = (GetRandom(medCons));
                    result[2] = (GetRandom(softCons));
                    break;
                default:
                    result[0] = (GetRandom(softCons));
                    result[1] = (GetRandom(softCons));
                    result[0] = (GetRandom(softCons));
                    break;
            }
            return new string(result);
        }

        private static int GetRandomNumber(int downThres, int upThres)
        {
            Random RND = new Random();
            return RND.Next(downThres, upThres);
        }
    }
}