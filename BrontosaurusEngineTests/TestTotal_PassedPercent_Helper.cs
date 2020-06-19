using System;
using System.Collections.Generic;
using Xunit;
using BrontosaurusEngine;

namespace BrontosaurusEngineTests
{
    public class TestTotal_PassedPercent_Helper : TheoryData<List<string>, float>
    {
        public TestTotal_PassedPercent_Helper()
        {
            Add(new List<string> { "TestName;OK" }, 100);
            Add(new List<string> { "TestName1;OK", "TestName2;OK" }, 100);
            Add(new List<string> { "TestName;FAILED" }, 0);
            Add(new List<string> { "TestName1;FAILED", "TestName2;FAILED" }, 0);
            Add(new List<string> { "TestName1;OK", "TestName2;FAILED" }, 50);
            Add(new List<string> { "TestName1;OK", "TestName2;FAILED", "TestName3;FAILED" }, 1/3f*100);
        }
    }
}