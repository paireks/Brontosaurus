using System;
using System.Collections.Generic;
using Xunit;
using BrontosaurusEngine;

namespace BrontosaurusEngineTests
{
    public class TestAssertTrue_Failed_Helper : TheoryData<List<bool>, List<string>, bool>
    {
        public TestAssertTrue_Failed_Helper()
        {
            Add(new List<bool> { true }, new List<string> { "TestName" }, false);
            Add(new List<bool> { false }, new List<string> { "TestName" }, true);
            Add(new List<bool> { false, true, false }, new List<string> { "A", "B", "C" }, true);
            Add(new List<bool> { true, true, true }, new List<string> { "A", "B", "C" }, false);
            Add(new List<bool> { false, true, true }, new List<string> { "A", "B", "C" }, true);
            Add(new List<bool> { true, true, false }, new List<string> { "A", "B", "C" }, true);
            Add(new List<bool> { false, false, false }, new List<string> { "A", "B", "C" }, true);
        }
    }
}