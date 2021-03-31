using System;
using System.Collections.Generic;

namespace NameGeneratorLib
{
    class LetterContainer
    {
        public List<char> container { get; set; }
        public int Count {get; set; }

        public LetterContainer(char[] arr)
        {
            Count = 0;

            foreach(var x in arr)
            {
                container.Add(x);
                Count++;
            }
        }
         
        public char GetRandom()
        {
            Random LetterIndex = new Random();
            int TheIndex = LetterIndex.Next(0, Count );

            return container[TheIndex];   
        }
    }
}