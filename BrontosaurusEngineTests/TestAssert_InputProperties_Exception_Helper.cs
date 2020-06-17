using System;
using System.Collections.Generic;
using Xunit;
using BrontosaurusEngine;

namespace BrontosaurusEngineTests
{
    public class TestAssert_InputProperties_Exception_Helper : TheoryData<List<string>, List<string>, List<string>, string>
    {
        public TestAssert_InputProperties_Exception_Helper()
        {
            Add(new List<string> { "5", "7" }, new List<string> { "4" }, new List<string> { "TestName" },
                "Expected list should match actual and names - check if all three lists have the same number of elements");
            Add(new List<string> { "5" }, new List<string> { "4", "7" }, new List<string> { "TestName" },
                "Expected list should match actual and names - check if all three lists have the same number of elements");
            Add(new List<string> { "5" }, new List<string> { "4", "7" }, new List<string> { "TestName1", "TestName2" },
                "Expected list should match actual and names - check if all three lists have the same number of elements");
            Add(new List<string> { "5" }, new List<string> { "4" }, new List<string> { "TestName1", "TestName2" },
                "Expected list should match actual and names - check if all three lists have the same number of elements");
        }
    }
}
