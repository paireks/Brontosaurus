using System;
using System.Collections.Generic;
using Xunit;
using BrontosaurusEngine;

namespace BrontosaurusEngineTests
{
    public class TestAssertTrue_Result : TheoryData<List<bool>, List<string>, List<string>>
    {
        public TestAssertTrue_Result()
        {
            Add(new List<bool> { true }, new List<string> { "TestName" }, new List<string> { "TestName;OK" });
            Add(new List<bool> { false }, new List<string> { "TestName" }, new List<string> { "TestName;FAILED" });
            Add(new List<bool> { true, false }, new List<string> { "TestName1", "TestName2" }, new List<string> { "TestName1;OK", "TestName2;FAILED" });
        }
    }
}
