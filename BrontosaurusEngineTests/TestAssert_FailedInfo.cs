using System;
using System.Collections.Generic;
using Xunit;
using BrontosaurusEngine;

namespace BrontosaurusEngineTests
{
    public class TestAssert_FailedInfo : TheoryData<List<string>, List<string>, List<string>, List<string>>
    {
        public TestAssert_FailedInfo()
        {
            Add(new List<string> { "5" }, new List<string> { "4" },
                new List<string> { "TestName" }, 
                new List<string> { "TestName" + Environment.NewLine + "Test Failed: Expected != Actual" + Environment.NewLine + "5" + " != " + "4" });
            Add(new List<string> { "5" }, new List<string> { "5" },
                new List<string> { "TestName" },
                new List<string> {  });
            Add(new List<string> { "5", "4" }, new List<string> { "5", "5" },
                new List<string> { "TestName", "FailedTestName" },
                new List<string> { "FailedTestName" + Environment.NewLine + "Test Failed: Expected != Actual" + Environment.NewLine + "4" + " != " + "5" });
            Add(new List<string> { "3", "4" }, new List<string> { "5", "5" },
                new List<string> { "FailedTestName1", "FailedTestName2" },
                new List<string>
                {
                    "FailedTestName1" + Environment.NewLine + "Test Failed: Expected != Actual" + Environment.NewLine + "3" + " != " + "5",
                    "FailedTestName2" + Environment.NewLine + "Test Failed: Expected != Actual" + Environment.NewLine + "4" + " != " + "5"
                });
        }
    }
}
