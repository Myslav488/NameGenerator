using System;

namespace NameGeneratorLib
{
    public class User
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public int CountBornYear()
        {
            return 121 - Age;
        }
    }
}
