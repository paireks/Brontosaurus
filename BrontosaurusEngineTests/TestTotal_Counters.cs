using System;
using System.Collections.Generic;
using Xunit;
using BrontosaurusEngine;

namespace BrontosaurusEngineTests
{
    public class TestTotal_Counters : TheoryData<List<string>, int, int>
    {
        public TestTotal_Counters()
        {
            Add(new List<string> {  }, 0, 0);
            Add(new List<string> { "TestName;OK" }, 0, 1);
            Add(new List<string> { "TestName;FAILED" }, 1, 0);
            Add(new List<string> { "TestName1;OK", "TestName2;FAILED" }, 1, 1);
            Add(new List<string> { "TestName1;FAILED", "TestName2;FAILED" }, 2, 0);
            Add(new List<string> { "TestName1;OK", "TestName2;OK" }, 0, 2);
            Add(new List<string> { "TestName1;OK", "TestName2;OK", "TestName3;FAILED" }, 1, 2);
        }
    }
}