using System;
using System.Collections.Generic;
using Xunit;
using BrontosaurusEngine;
using Rhino.Geometry;

namespace BrontosaurusEngineTests
{
    public class TestTotal
    {
        [Theory]
        [ClassData(typeof(TestTotal_InputProperties))]
        public void TestTotal_InputProperties(List<string> exp)
        {
            Total testObject = new Total(exp);

            Assert.Equal(exp, testObject.Results);
        }
        [Theory]
        [ClassData(typeof(TestTotal_Counters))]
        public void TestTotal_Counters(List<string> results, int failedCounter, int passedCounter)
        {
            Total testObject = new Total(results);

            Assert.Equal(failedCounter, testObject.FailedCounter);
            Assert.Equal(passedCounter, testObject.PassedCounter);
        }
        [Theory]
        [ClassData(typeof(TestTotal_PassedPercent))]
        public void TestTotal_PassedPercent(List<string> results, float passedPercent)
        {
            Total testObject = new Total(results);

            Assert.Equal(passedPercent, testObject.PassedPercent);
        }
        [Theory]
        [ClassData(typeof(TestTotal_AllTestsPassed))]
        public void TestTotal_AllTestsPassed(List<string> results, bool allTestPassed)
        {
            Total testObject = new Total(results);

            Assert.Equal(allTestPassed, testObject.AllTestsPassed);
        }
        [Theory]
        [ClassData(typeof(TestTotal_TotalResult))]
        public void TestTotal_TotalResult(List<string> results, string totalResult)
        {
            Total testObject = new Total(results);

            Assert.Equal(totalResult, testObject.TotalResult);
        }
        [Theory]
        [ClassData(typeof(TestTotal_ReportPart))]
        public void TestTotal_ReportPart(List<string> results, string reportPart)
        {
            Total testObject = new Total(results);

            Assert.Equal(reportPart, testObject.ReportPart);
        }
    }
}
