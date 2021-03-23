using System;
using System.Threading;   

namespace NameGeneratorLib
{
    public class GenerateRandom : BaseGenerator
    {
        protected override string result{get; set; }
        protected override int length { get; set; }

        public override void ShowResult()
        {
            Console.Clear();
            System.Console.WriteLine("Project in progress \n \n Option not yet ready");
            Thread.Sleep(2000);
            Console.Clear();
            MessagesHelper.AnimProcess(3);
            MessagesHelper.GoodBye(); 
        }

    }
}