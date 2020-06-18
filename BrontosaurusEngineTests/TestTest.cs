using System;
using System.Collections.Generic;
using Xunit;
using BrontosaurusEngine;

namespace BrontosaurusEngineTests
{
    public class TestTest
    {
        [Theory]
        [ClassData(typeof(TestAssert_InputProperties_Helper))]
        public void TestAssert_InputProperties_Helper(List<string> exp, List<string> act, List<string> names)
        {
            Test testObject = new Test(exp, act, names);

            Assert.Equal(exp, testObject.Expected);
            Assert.Equal(act, testObject.Actual);
            Assert.Equal(names, testObject.Names);
        }

        [Theory]
        [ClassData(typeof(TestAssertTrue_InputProperties_Helper))]
        public void TestAssertTrue_InputProperties_Helper(List<bool> act, List<string> names)
        {
            Test testObject = new Test(act, names);

            Assert.Equal(act, testObject.ActualBoolean);
            Assert.Equal(names, testObject.Names);
        }

        [Theory]
        [ClassData(typeof(TestAssertTrue_Result_Helper))]
        public void TestAssertTrue_Result_Helper(List<bool> act, List<string> names, List<string> result)
        {
            Test testObject = new Test(act, names);
            Assert.Equal(result, testObject.Result);
        }

        [Theory]
        [ClassData(typeof(TestAssertTrue_Failed_Helper))]
        public void TestAssertTrue_Failed_Helper(List<bool> act, List<string> names, bool failed)
        {
            Test testObject = new Test(act, names);
            Assert.Equal(failed, testObject.Failed);
        }

        [Theory]
        [ClassData(typeof(TestAssertTrue_FailedInfo_Helper))]
        public void TestAssertTrue_FailedInfo_Helper(List<bool> act, List<string> names, List<string> failedInfo)
        {
            Test testObject = new Test(act, names);
            Assert.Equal(failedInfo, testObject.FailedInfo);
        }

        [Theory]
        [ClassData(typeof(TestAssert_InputProperties_Exception_Helper))]
        public void TestAssert_InputProperties_Exception_Helper(List<string> exp, List<string> act, List<string> names, string message)
        {
            var exception = Assert.Throws<ArgumentException>(() => new Test(exp, act, names));
            Assert.Equal(message, exception.Message);
        }

        [Theory]
        [ClassData(typeof(TestAssertTrue_InputProperties_Exception_Helper))]
        public void TestAssertTrue_InputProperties_Exception_Helper(List<bool> act, List<string> names, string message)
        {
            var exception = Assert.Throws<ArgumentException>(() => new Test(act, names));
            Assert.Equal(message, exception.Message);
        }

        [Theory]
        [ClassData(typeof(TestAssert_Result_Helper))]
        public void TestAssert_Result_Helper(List<string> exp, List<string> act, List<string> names, List<string> result)
        {
            Test testObject = new Test(exp, act, names);
            Assert.Equal(result, testObject.Result);
        }

        [Theory]
        [ClassData(typeof(TestAssert_FailedInfo_Helper))]
        public void TestAssert_FailedInfo_Helper(List<string> exp, List<string> act, List<string> names, List<string> failedInfo)
        {
            Test testObject = new Test(exp, act, names);
            Assert.Equal(failedInfo, testObject.FailedInfo);
        }

        [Theory]
        [ClassData(typeof(TestAssert_Failed_Helper))]
        public void TestAssert_Failed_Helper(List<string> exp, List<string> act, List<string> names, bool failed)
        {
            Test testObject = new Test(exp, act, names);
            Assert.Equal(failed, testObject.Failed);
        }
    }
}
