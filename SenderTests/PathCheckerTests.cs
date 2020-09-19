using Sender;
using System;
using Xunit;

namespace Sender.Tests
{
    public class PathCheckerTests
    {
        [Fact]
        public void TestForValidExistingPath()
        {
            string path = "C:/Users/Ajay kumar/Desktop/Sample2.csv";
            Assert.True(PathChecker.DoesPathExists(path));
        }
        [Fact]
        public void TestForNonExistingPath()
        {
            string path = "C:/Users/Ajay kumar/Desktop/xyz.csv";
            Assert.False(PathChecker.DoesPathExists(path));
        }
    }
}