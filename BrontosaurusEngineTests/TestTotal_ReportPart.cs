using System;
using System.Collections.Generic;
using Xunit;
using BrontosaurusEngine;

namespace BrontosaurusEngineTests
{
    public class TestTotal_ReportPart : TheoryData<List<string>, string>
    {
        public TestTotal_ReportPart()
        {
            Add(new List<string> {"TestName1;OK"}, 
                "Total result: 100% tests passed."
                + Environment.NewLine + "Tests passed: 1"
                + Environment.NewLine + "Tests failed: 0"
                + Environment.NewLine + "| Name | Result |"
                + Environment.NewLine + "| :---: | :---: |"
                + Environment.NewLine + "| TestName1 | <span style=\"color: green\">OK</span> |"
                + Environment.NewLine);
            Add(new List<string> { "TestName1;OK", "TestName2;FAILED" },
                "Total result: 50% tests passed."
                + Environment.NewLine + "Tests passed: 1"
                + Environment.NewLine + "Tests failed: 1"
                + Environment.NewLine + "| Name | Result |"
                + Environment.NewLine + "| :---: | :---: |"
                + Environment.NewLine + "| TestName1 | <span style=\"color: green\">OK</span> |"
                + Environment.NewLine + "| TestName2 | <span style=\"color: red\">FAILED</span> |"
                + Environment.NewLine);
            Add(new List<string> { "TestName1;OK", "TestName2;FAILED", "TestName3;FAILED" },
                "Total result: 33,33334% tests passed."
                + Environment.NewLine + "Tests passed: 1"
                + Environment.NewLine + "Tests failed: 2"
                + Environment.NewLine + "| Name | Result |"
                + Environment.NewLine + "| :---: | :---: |"
                + Environment.NewLine + "| TestName1 | <span style=\"color: green\">OK</span> |"
                + Environment.NewLine + "| TestName2 | <span style=\"color: red\">FAILED</span> |"
                + Environment.NewLine + "| TestName3 | <span style=\"color: red\">FAILED</span> |"
                + Environment.NewLine);
        }
    }
}