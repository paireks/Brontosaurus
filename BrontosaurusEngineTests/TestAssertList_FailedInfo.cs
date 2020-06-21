using System;
using System.Collections.Generic;
using Xunit;
using BrontosaurusEngine;


namespace BrontosaurusEngineTests
{
    public class TestAssertList_FailedInfo : TheoryData<List<string>, List<string>, string, List<string>>
    {
        public TestAssertList_FailedInfo()
        {
            Add(new List<string> { "5" }, new List<string> { "5" }, "TestName",
                new List<string> {  });
            Add(new List<string> { "5" }, new List<string> { "4" }, "TestName",
                new List<string> { "Check element " + 0 + Environment.NewLine + 5 + " != " + 4 });
            Add(new List<string> { "4", "Aha" }, new List<string> { "4", "Aha" }, "TestName",
                new List<string> { });
            Add(new List<string> { "4", "Fail" }, new List<string> { "4", "Aha" }, "TestName",
                new List<string> { "Check element " + 1 + Environment.NewLine + "Fail" + " != " + "Aha" });
            Add(new List<string> { "4", "Fail", "Fail2" }, new List<string> { "4", "Aha", "Aha" }, "TestName",
                new List<string>
                {
                    "Check element " + 1 + Environment.NewLine + "Fail" + " != " + "Aha",
                    "Check element " + 2 + Environment.NewLine + "Fail2" + " != " + "Aha"
                });
            Add(new List<string> { "4" }, new List<string> { "4", "Aha" }, "TestName",
                new List<string> { "There is a difference between number of elements for both lists"
                                   + Environment.NewLine + "Expected list length: " + 1
                                   + Environment.NewLine + "Actual list length: " + 2
                                   + Environment.NewLine });
            Add(new List<string> { "4", "Aha" }, new List<string> { "4" }, "TestName",
                new List<string> {"There is a difference between number of elements for both lists"
                                  + Environment.NewLine + "Expected list length: " + 2
                                  + Environment.NewLine + "Actual list length: " + 1
                                  + Environment.NewLine });
        }
    }
}