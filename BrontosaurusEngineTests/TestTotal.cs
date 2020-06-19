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
        [ClassData(typeof(TestTotal_InputProperties_Helper))]
        public void TestTotal_InputProperties_Helper(List<string> exp)
        {
            Total testObject = new Total(exp);

            Assert.Equal(exp, testObject.Results);
        }
        [Theory]
        [ClassData(typeof(TestTotal_Counters_Helper))]
        public void TestTotal_Counters_Helper(List<string> results, int failedCounter, int passedCounter)
        {
            Total testObject = new Total(results);

            Assert.Equal(failedCounter, testObject.FailedCounter);
            Assert.Equal(passedCounter, testObject.PassedCounter);
        }
        [Theory]
        [ClassData(typeof(TestTotal_PassedPercent_Helper))]
        public void TestTotal_PassedPercent_Helper(List<string> results, float passedPercent)
        {
            Total testObject = new Total(results);

            Assert.Equal(passedPercent, testObject.PassedPercent);
        }
        [Theory]
        [ClassData(typeof(TestTotal_AllTestsPassed_Helper))]
        public void TestTotal_AllTestsPassed_Helper(List<string> results, bool allTestPassed)
        {
            Total testObject = new Total(results);

            Assert.Equal(allTestPassed, testObject.AllTestsPassed);
        }
        [Theory]
        [ClassData(typeof(TestTotal_TotalResult_Helper))]
        public void TestTotal_TotalResult_Helper(List<string> results, string totalResult)
        {
            Total testObject = new Total(results);

            Assert.Equal(totalResult, testObject.TotalResult);
        }
        [Theory]
        [ClassData(typeof(TestTotal_ReportPart_Helper))]
        public void TestTotal_ReportPart_Helper(List<string> results, string reportPart)
        {
            Total testObject = new Total(results);

            Assert.Equal(reportPart, testObject.ReportPart);
        }
    }
}
