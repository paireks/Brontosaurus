using System;
using System.Collections.Generic;
using Xunit;
using BrontosaurusEngine;

namespace BrontosaurusEngineTests
{
    public class TestAssertList_Result : TheoryData<List<string>, List<string>, string, string>
    {
        public TestAssertList_Result()
        {
            Add(new List<string> { "5" }, new List<string> { "5" }, "TestName", "TestName;OK");
            Add(new List<string> { "5" }, new List<string> { "4" }, "TestName", "TestName;FAILED");
            Add(new List<string> { "4", "Aha" }, new List<string> { "4", "Aha" }, "TestName", "TestName;OK");
            Add(new List<string> { "4", "Fail" }, new List<string> { "4", "Aha" }, "TestName", "TestName;FAILED");
            Add(new List<string> { "4" }, new List<string> { "4", "Aha" }, "TestName", "TestName;FAILED");
            Add(new List<string> { "4", "Aha" }, new List<string> { "4" }, "TestName", "TestName;FAILED");
        }
    }
}