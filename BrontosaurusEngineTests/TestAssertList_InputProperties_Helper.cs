using System;
using System.Collections.Generic;
using Xunit;
using BrontosaurusEngine;

namespace BrontosaurusEngineTests
{
    public class TestAssertList_InputProperties_Helper : TheoryData<List<string>, List<string>, string>
    {
        public TestAssertList_InputProperties_Helper()
        {
            Add(new List<string> { "5" }, new List<string> { "4" }, "TestName");
            Add(new List<string> { "5", "Aha" }, new List<string> { "4", "Aha" }, "TestName");
        }
    }
}
