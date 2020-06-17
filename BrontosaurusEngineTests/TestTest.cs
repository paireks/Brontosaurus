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
            List<string> exp = new List<string>{ "5" };
            List<string> act = new List<string>{ "4" };
            List<string> names = new List<string>{"TestName"};

            Test testObject = new Test(exp, act, names);

            Assert.True(testObject.Failed);
            Assert.Equal(exp, testObject.Expected);
            Assert.Equal(act, testObject.Actual);
            Assert.Equal(names, testObject.Names);
        }

        [Fact]
        public void TestPassingAssert()
        {
            List<string> exp = new List<string> { "4" };
            List<string> act = new List<string> { "4" };
            List<string> names = new List<string> { "TestName" };

            Test testObject = new Test(exp, act, names);

            Assert.False(testObject.Failed);
            Assert.Equal(exp, testObject.Expected);
            Assert.Equal(act, testObject.Actual);
            Assert.Equal(names, testObject.Names);
        }






        [Fact]
        public void TestFailingAssertTrue()
        {
            List<bool> act = new List<bool> { false };
            List<string> names = new List<string> { "TestName" };

            Test testObject = new Test(act, names);

            Assert.True(testObject.Failed);
            Assert.Equal(act, testObject.ActualBoolean);
            Assert.Equal(names, testObject.Names);
        }

        [Fact]
        public void TestPassingAssertTrue()
        {
            List<bool> act = new List<bool> { true };
            List<string> names = new List<string> { "TestName" };

            Test testObject = new Test(act, names);

            Assert.False(testObject.Failed);
            Assert.Equal(act, testObject.ActualBoolean);
            Assert.Equal(names, testObject.Names);
        }
    }
}
