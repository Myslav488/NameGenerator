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
            System.Console.WriteLine("Project in progress \n \n Option not yet ready");
            Thread.Sleep(2000);
            Console.Clear();
            MessagesHelper.AnimProcess(3);
            MessagesHelper.GoodBye(); 
        }

        public override void SubMenu()
        {
            throw new NotImplementedException();
        }
        public override void PerformAction(int choice)
        {
            throw new NotImplementedException();
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

        public string GetSequenceOf2()
        {
            Random RND = new Random();
            int num = RND.Next(0, 5);
            List<char> result = new List<char>();

            switch(num)
            {
                case 0:
                    result.Add(GetRandom(Vowels));
                    result.Add(GetRandom(Vowels));
                    break;
                case 1:
                    result.Add(GetRandom(Vowels));
                    result.Add(GetRandom(medCons));
                    break;
                case 2:
                    result.Add(GetRandom(softCons));
                    result.Add(GetRandom(Vowels));
                    break;
                case 3:
                    result.Add(GetRandom(harshCons));
                    result.Add(GetRandom(Vowels));
                    break;
                case 4:
                    result.Add(GetRandom(softCons));
                    result.Add(GetRandom(harshCons));
                    break;
                case 5:
                    result.Add(GetRandom(medCons));
                    result.Add(GetRandom(softCons));
                    break;                                
                default:
                    result.Add(GetRandom(softCons));
                    result.Add(GetRandom(softCons));
                    break;
            }
            return result.ToString();
        } 



    }
}