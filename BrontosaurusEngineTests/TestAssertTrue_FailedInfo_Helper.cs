using System;
using System.Collections.Generic;
using Xunit;
using BrontosaurusEngine;

namespace BrontosaurusEngineTests
{
    public class TestAssertTrue_FailedInfo_Helper : TheoryData<List<bool>, List<string>, List<string>>
    {
        public TestAssertTrue_FailedInfo_Helper()
        {
            Add(new List<bool> { true }, new List<string> { "TestName" }, new List<string> {  });
            Add(new List<bool> { false }, new List<string> { "TestName" }, 
                new List<string> { "TestName" + Environment.NewLine + "Test Failed: True != False" });
            Add(new List<bool> { false, true, false }, new List<string> { "A", "B", "C" },
                new List<string>
                {
                    "A" + Environment.NewLine + "Test Failed: True != False",
                    "C" + Environment.NewLine + "Test Failed: True != False"
                });
        }
    }
}