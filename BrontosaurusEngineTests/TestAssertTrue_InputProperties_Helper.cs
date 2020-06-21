using System;
using System.Collections.Generic;
using Xunit;
using BrontosaurusEngine;

namespace BrontosaurusEngineTests
{
    public class TestAssertTrue_InputProperties_Helper : TheoryData<List<bool>, List<string>>
    {
        public TestAssertTrue_InputProperties_Helper()
        {
            Add(new List<bool> { true }, new List<string> { "TestName" });
            Add(new List<bool> { false }, new List<string> { "TestName" });
            Add(new List<bool> { true, false }, new List<string> { "TestName1", "TestName2" });
        }
    }
}
