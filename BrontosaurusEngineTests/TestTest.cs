using System;
using System.Collections.Generic;
using Xunit;
using BrontosaurusEngine;

namespace BrontosaurusEngineTests
{
    public class TestTest
    {
        [Fact]
        public void TestFailingAssert()
        {
            List<string> exp = new List<string>{"5"};
            List<string> act = new List<string>{"4"};
            List<string> names = new List<string>{"TestName"};

            Test testObject = new Test(exp, act, names);

            Assert.Equal(true, testObject.Failed);
        }

        [Fact]
        public void TestFailingAssertTrue()
        {
            List<bool> act = new List<bool> { false };
            List<string> names = new List<string> { "TestName" };

            Test testObject = new Test(act, names);

            Assert.Equal(true, testObject.Failed);
        }
    }
}
