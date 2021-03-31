using System;

namespace NameGeneratorLib
{
    public class User
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        private int _Age;
        public int Age { 
            get { return _Age; } 
            set { 
                if(value < 0){
                    System.Console.WriteLine("I guess You mean You are newly born. Wow...");
                    _Age = 0;
                }
                if(value > 120){
                    System.Console.WriteLine("I do belive You are old. But not more than 120.");
                    _Age =120;
                }
                else _Age = value;
                } 
            }

        public int CountBornYear()
        {
            return DateTime.Now.Year - _Age;
        }

        public int CountShortBornYear()
        {
            return int.Parse(CountBornYear().ToString().Substring(2));
        }
    }
}
