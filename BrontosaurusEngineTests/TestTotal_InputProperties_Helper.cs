using System;
using System.Collections.Generic;
using Xunit;
using BrontosaurusEngine;

namespace BrontosaurusEngineTests
{
    public class TestTotal_InputProperties_Helper : TheoryData<List<string>>
    {
        public TestTotal_InputProperties_Helper()
        {
            Add(new List<string> { "TestName;OK" });
            Add(new List<string> { "TestName1;OK", "TestName2;FAILED" });
        }
    }
}
