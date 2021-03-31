using System;
using NameGeneratorLib;
using Xunit;

namespace NameGeneratorTest
{
    public class UnitTest1
    {
        [Fact]
        public void CheckIfUsers1stMethodCounts()
        {
            var user = new User()
            {
                FirstName = "Jon",
                SecondName = "Bary",
                LastName = "Flower",
                Age = 25
            };

            Assert.Equal(1996, user.CountBornYear());
        }
        [Fact]
        public void CheckIfUsers2ndMethodCounts()
        {
            var user = new User()
            {
                FirstName = "Jon",
                SecondName = "Bary",
                LastName = "Flower",
                Age = 25
            };

            Assert.Equal(96, user.CountShortBornYear());
        }
        [Fact]
        public void CheckIfUGenearatesLentghOf2()
        {
            var tempGenerator = new GenerateRandom();
            var x = tempGenerator.GetSequenceOf2();
            Console.WriteLine(x);

            Assert.Equal(2, x.Length);
        }
    }
}