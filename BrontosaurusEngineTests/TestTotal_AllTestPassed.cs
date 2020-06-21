using System;
using System.Collections.Generic;
using Xunit;
using BrontosaurusEngine;

namespace BrontosaurusEngineTests
{
    public class TestTotal_AllTestsPassed : TheoryData<List<string>, bool>
    {
        public TestTotal_AllTestsPassed()
        {
            Add(new List<string> { "TestName;OK" }, true);
            Add(new List<string> { "TestName1;OK", "TestName2;OK" }, true);
            Add(new List<string> { "TestName;FAILED" }, false);
            Add(new List<string> { "TestName1;FAILED", "TestName2;FAILED" }, false);
            Add(new List<string> { "TestName1;OK", "TestName2;FAILED" }, false);
            Add(new List<string> { "TestName1;OK", "TestName2;FAILED", "TestName3;FAILED" }, false);
            Add(new List<string> { "TestName1;FAILED", "TestName2;OK", "TestName3;OK" }, false);
        }
    }
}