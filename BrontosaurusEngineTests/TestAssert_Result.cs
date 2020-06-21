using System;
using System.Collections.Generic;
using Xunit;
using BrontosaurusEngine;

namespace BrontosaurusEngineTests
{
    public class TestAssert_Result : TheoryData<List<string>, List<string>, List<string>, List<string>>
    {
        public TestAssert_Result()
        {
            Add(new List<string> { "5" }, new List<string> { "4" },
                new List<string> { "TestName" }, new List<string> { "TestName;FAILED" });
            Add(new List<string> { "5" }, new List<string> { "5" },
                new List<string> { "TestName" }, new List<string> { "TestName;OK" });
            Add(new List<string> { "5", "5" }, new List<string> { "4", "5" },
                new List<string> { "TestName1", "TestName2" }, new List<string> { "TestName1;FAILED", "TestName2;OK" });
            Add(new List<string> { "5", "5" }, new List<string> { "5", "4" },
                new List<string> { "TestName1", "TestName2" }, new List<string> { "TestName1;OK", "TestName2;FAILED" });
            Add(new List<string> { "4", "4" }, new List<string> { "4", "4" },
                new List<string> { "TestName1", "TestName2" }, new List<string> { "TestName1;OK", "TestName2;OK" });
            Add(new List<string> { "4", "7" }, new List<string> { "7", "4" },
                new List<string> { "TestName1", "TestName2" }, new List<string> { "TestName1;FAILED", "TestName2;FAILED" });
            Add(new List<string> { "4", "7", "3" }, new List<string> { "4", "4", "3" },
                new List<string> { "TestName1", "TestName2", "TestName3" },
                new List<string> { "TestName1;OK", "TestName2;FAILED", "TestName3;OK" });
            Add(new List<string> { "7", "4", "7" }, new List<string> { "4", "4", "4" },
                new List<string> { "TestName1", "TestName2", "TestName3" },
                new List<string> { "TestName1;FAILED", "TestName2;OK", "TestName3;FAILED" });
            Add(new List<string> { "" }, new List<string> { "" }, new List<string> { "TestName" },
                new List<string> { "TestName;OK" });
            Add(new List<string> { "" }, new List<string> { "A" }, new List<string> { "TestName" },
                new List<string> { "TestName;FAILED" });
            Add(new List<string> { "A" }, new List<string> { "A" }, new List<string> { "" },
                new List<string> { ";OK" });
        }
    }
}
