using System;
using System.Collections.Generic;
using Xunit;
using BrontosaurusEngine;

namespace BrontosaurusEngineTests
{
    public class TestAssert_Failed_Helper : TheoryData<List<string>, List<string>, List<string>, bool>
    {
        public TestAssert_Failed_Helper()
        {
            Add(new List<string> { "5" }, new List<string> { "4" }, new List<string> { "TestName" }, true);
            Add(new List<string> { "5", "5" }, new List<string> { "4", "4" }, new List<string> { "TestName1", "TestName2" }, true);
            Add(new List<string> { "5", "5" }, new List<string> { "5", "5" }, new List<string> { "TestName1", "TestName2" }, false);
            Add(new List<string> { "5" }, new List<string> { "5" }, new List<string> { "TestName" }, false);
        }
    }
}
