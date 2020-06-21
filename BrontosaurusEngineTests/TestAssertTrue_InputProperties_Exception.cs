using System;
using System.Collections.Generic;
using Xunit;
using BrontosaurusEngine;

namespace BrontosaurusEngineTests
{
    public class TestAssertTrue_InputProperties_Exception : TheoryData<List<bool>, List<string>, string>
    {
        public TestAssertTrue_InputProperties_Exception()
        {
            Add(new List<bool> { false, true }, new List<string> { "TestName" },
                "Actual list should match names list - check if both lists have the same number of elements");
            Add(new List<bool> { true }, new List<string> { "TestName1", "TestName2" },
                "Actual list should match names list - check if both lists have the same number of elements");
        }
    }
}
