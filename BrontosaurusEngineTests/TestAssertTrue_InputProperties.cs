﻿using System;
using System.Collections.Generic;
using Xunit;
using BrontosaurusEngine;

namespace BrontosaurusEngineTests
{
    public class TestAssertTrue_InputProperties : TheoryData<List<bool>, List<string>>
    {
        public TestAssertTrue_InputProperties()
        {
            Add(new List<bool> { true }, new List<string> { "TestName" });
            Add(new List<bool> { false }, new List<string> { "TestName" });
            Add(new List<bool> { true, false }, new List<string> { "TestName1", "TestName2" });
        }
    }
}
