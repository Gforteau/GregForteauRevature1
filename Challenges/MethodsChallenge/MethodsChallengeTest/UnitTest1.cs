using System;
using Xunit;
using _4_MethodsChallenge;

namespace MethodsChallengeTest
{
    public class UnitTest1
    {
        [Fact]
        public void GetName()
        {
            //Arrange
            string s1 = "This is a test";

            //Act
            string result = Program.GetName(s1);
            string expected = "THIS IS A TEST";

            //Assert
            Assert.Equal(expected, result);
        }
    }
}
