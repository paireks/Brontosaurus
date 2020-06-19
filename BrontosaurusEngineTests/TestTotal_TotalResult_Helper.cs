using System;
using System.Collections.Generic;
using Xunit;
using BrontosaurusEngine;

namespace BrontosaurusEngineTests
{
    public class TestTotal_TotalResult_Helper : TheoryData<List<string>, string>
    {
        public TestTotal_TotalResult_Helper()
        {
            Add(new List<string> { "TestName;OK" }, "Total result: " + 100 + "% tests passed."
                                                    + Environment.NewLine + "Tests passed: " + 1
                                                    + Environment.NewLine + "Tests failed: " + 0);
            Add(new List<string> { "TestName;FAILED" }, "Total result: " + 0 + "% tests passed."
                                                    + Environment.NewLine + "Tests passed: " + 0
                                                    + Environment.NewLine + "Tests failed: " + 1);
            Add(new List<string> { "TestName1;FAILED", "TestName2;OK" },
                "Total result: " + 50 + "% tests passed."
                + Environment.NewLine + "Tests passed: " + 1
                + Environment.NewLine + "Tests failed: " + 1);
            Add(new List<string> { "TestName1;FAILED", "TestName2;FAILED" },
                "Total result: " + 0 + "% tests passed."
                + Environment.NewLine + "Tests passed: " + 0
                + Environment.NewLine + "Tests failed: " + 2);
            Add(new List<string> { "TestName1;FAILED", "TestName2;FAILED", "TestName3;OK" },
                "Total result: " + 1/3f*100 + "% tests passed."
                + Environment.NewLine + "Tests passed: " + 1
                + Environment.NewLine + "Tests failed: " + 2);
        }
    }
}