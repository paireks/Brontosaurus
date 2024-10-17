using System.Collections.Generic;
using Xunit;

namespace BrontosaurusEngineTests
{
    public class TestAssert_InputProperties_Exception : TheoryData<List<string>, List<string>, List<string>, string>
    {
        public TestAssert_InputProperties_Exception()
        {
            Add(new List<string> { "5", "7" }, new List<string> { "4" }, new List<string> { "TestName" },
                "Expected list should match actual and names - check if all three lists have the same number of elements");
            Add(new List<string> { "5" }, new List<string> { "4", "7" }, new List<string> { "TestName" },
                "Expected list should match actual and names - check if all three lists have the same number of elements");
            Add(new List<string> { "5" }, new List<string> { "4", "7" }, new List<string> { "TestName1", "TestName2" },
                "Expected list should match actual and names - check if all three lists have the same number of elements");
            Add(new List<string> { "5" }, new List<string> { "4" }, new List<string> { "TestName1", "TestName2" },
                "Expected list should match actual and names - check if all three lists have the same number of elements");
            Add(new List<string> { "5", "7" }, new List<string> { "4", "7" }, new List<string> { "TestName1", "TestName2;" },
                "Test name cannot contain a \";\" char");
            Add(new List<string> { "5", "7" }, new List<string> { "4", "7" }, new List<string> { "Test;Name1", "TestName2" },
                "Test name cannot contain a \";\" char");
            Add(new List<string> { "5", "7" }, new List<string> { "4", "7" }, new List<string> { ";TestName1", "TestName2" },
                "Test name cannot contain a \";\" char");
            Add(new List<string> { "5", "7" }, new List<string> { "4", "7" }, new List<string> { "TestName1", "TestName;;2" },
                "Test name cannot contain a \";\" char");
            Add(new List<string> { "5", "7" }, new List<string> { "4", "7" }, new List<string> { "TestName1;", "TestName2;" },
                "Test name cannot contain a \";\" char");
        }
    }
}