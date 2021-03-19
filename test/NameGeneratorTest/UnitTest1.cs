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

            Assert.Equal(96, user.CountBornYear());
        }
    }
}
