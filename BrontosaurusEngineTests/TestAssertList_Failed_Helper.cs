using System;
using System.Collections.Generic;
using Xunit;
using BrontosaurusEngine;

namespace BrontosaurusEngineTests
{
    public class TestAssertList_Failed_Helper : TheoryData<List<string>, List<string>, string, bool>
    {
        public TestAssertList_Failed_Helper()
        {
            Add(new List<string> { "5" }, new List<string> { "5" }, "TestName", false);
            Add(new List<string> { "5" }, new List<string> { "4" }, "TestName", true);
            Add(new List<string> { "4", "Aha" }, new List<string> { "4", "Aha" }, "TestName", false);
            Add(new List<string> { "4", "Fail" }, new List<string> { "4", "Aha" }, "TestName", true);
            Add(new List<string> { "4" }, new List<string> { "4", "Aha" }, "TestName", true);
            Add(new List<string> { "4", "Aha" }, new List<string> { "4" }, "TestName", true);
        }
    }
}