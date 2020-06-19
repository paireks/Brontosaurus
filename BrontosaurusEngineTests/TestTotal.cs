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
    }
}
