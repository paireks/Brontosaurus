using System;
using System.Collections.Generic;
using Xunit;
using BrontosaurusEngine;

namespace BrontosaurusEngineTests
{
    public class TestAssert_InputProperties_Helper : TheoryData<List<string>, List<string>, List<string>>
    {
        public TestAssert_InputProperties_Helper()
        {
            Add(new List<string> { "5" }, new List<string> { "4" }, new List<string> { "TestName" });
            Add(new List<string> { "" }, new List<string> { "4" }, new List<string> { "TestName" });
            Add(new List<string> { "" }, new List<string> { "" }, new List<string> { "TestName" });
            Add(new List<string> { "5" }, new List<string> { "4" }, new List<string> { "" });
            Add(new List<string> { "4" }, new List<string> { "4" }, new List<string> { "TestName" });
            Add(new List<string> { "Lorem ipsum", "Blabla" },
                new List<string> { "Lorem ipsum", "Blabla" },
                new List<string> { "TestName1", "TestName2" });
            Add(new List<string> { "Lorem ipsum", "Blabla" },
                new List<string> { "Lorem ipsum", "Noblabla" },
                new List<string> { "TestName1", "TestName2" });
        }
    }
}
