﻿using Sender;
using System;
using Xunit;

namespace Sender.Tests
{
    public class PathCheckerTests
    {
        [Fact]
        public void TestForValidExistingPath()
        {
            string path = @"D:\a\ReviewOfReviews-S21B1\ReviewOfReviews-S21B1\Sample3.csv";
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
