using System;
using System.Collections.Generic;
using Xunit;
using BrontosaurusEngine;
using Rhino.Geometry;

namespace BrontosaurusEngineTests
{
    public class TestAssertVector_FailedInfo_Helper : TheoryData<List<Vector3d>, List<Vector3d>, List<string>, double, List<string>>
    {
        public TestAssertVector_FailedInfo_Helper()
        {
            Add(new List<Vector3d> { new Vector3d(0, 0, 0) },
                new List<Vector3d> { new Vector3d(0, 0, 0) },
                new List<string> { "TestName" },
                0.0,
                new List<string> { });
            Add(new List<Vector3d> { new Vector3d(0, 1, 0), new Vector3d(0, 1, 1) },
                new List<Vector3d> { new Vector3d(0, 1, 0), new Vector3d(0, 1, 1) },
                new List<string> { "TestName1", "TestName2" },
                0.0,
                new List<string> { });
            Add(new List<Vector3d> { new Vector3d(1, 0, 0) },
                new List<Vector3d> { new Vector3d(0, 0, 0) },
                new List<string> { "TestName" },
                0.0,
                new List<string> { "TestName"
                                   + Environment.NewLine + "Test Failed: Expected != Actual"
                                   + Environment.NewLine + "1,0,0" + " != " + "0,0,0"
                                   + Environment.NewLine + "Check X direction;" + Environment.NewLine});
            Add(new List<Vector3d> { new Vector3d(0, 0, 0) },
                new List<Vector3d> { new Vector3d(0, 1, 0) },
                new List<string> { "TestName" },
                0.0,
                new List<string> { "TestName"
                                   + Environment.NewLine + "Test Failed: Expected != Actual"
                                   + Environment.NewLine + "0,0,0" + " != " + "0,1,0"
                                   + Environment.NewLine + "Check Y direction;" + Environment.NewLine});
            Add(new List<Vector3d> { new Vector3d(0, 0, 1) },
                new List<Vector3d> { new Vector3d(0, 0, 0) },
                new List<string> { "TestName" },
                0.0,
                new List<string> { "TestName"
                                   + Environment.NewLine + "Test Failed: Expected != Actual"
                                   + Environment.NewLine + "0,0,1" + " != " + "0,0,0"
                                   + Environment.NewLine + "Check Z direction;" + Environment.NewLine});
            Add(new List<Vector3d> { new Vector3d(1, 0, 1) },
                new List<Vector3d> { new Vector3d(0, 0, 0) },
                new List<string> { "TestName" },
                0.0,
                new List<string> { "TestName"
                                   + Environment.NewLine + "Test Failed: Expected != Actual"
                                   + Environment.NewLine + "1,0,1" + " != " + "0,0,0"
                                   + Environment.NewLine + "Check X direction;"
                                   + Environment.NewLine + "Check Z direction;" + Environment.NewLine});
            Add(new List<Vector3d> { new Vector3d(1, 0, 0), new Vector3d(0, 0, 0) },
                new List<Vector3d> { new Vector3d(0, 1, 0), new Vector3d(0, 0, 0) },
                new List<string> { "TestName1", "TestName2" },
                0.0,
                new List<string> { "TestName1"
                                   + Environment.NewLine + "Test Failed: Expected != Actual"
                                   + Environment.NewLine + "1,0,0" + " != " + "0,1,0"
                                   + Environment.NewLine + "Check X direction;"
                                   + Environment.NewLine + "Check Y direction;" + Environment.NewLine});
            Add(new List<Vector3d> { new Vector3d(1, 1, 1), new Vector3d(5, 5, 5) },
                new List<Vector3d> { new Vector3d(1, 1, 1), new Vector3d(0, 0, 0) },
                new List<string> { "TestName1", "TestName2" },
                0.0,
                new List<string> { "TestName2"
                                   + Environment.NewLine + "Test Failed: Expected != Actual"
                                   + Environment.NewLine + "5,5,5" + " != " + "0,0,0"
                                   + Environment.NewLine + "Check X direction;"
                                   + Environment.NewLine + "Check Y direction;"
                                   + Environment.NewLine + "Check Z direction;" + Environment.NewLine});
            Add(new List<Vector3d> { new Vector3d(1, 0, 1), new Vector3d(5, 5, 5) },
                new List<Vector3d> { new Vector3d(1, 1, 1), new Vector3d(0, 0, 0) },
                new List<string> { "TestName1", "TestName2" },
                0.0,
                new List<string> { "TestName1"
                                   + Environment.NewLine + "Test Failed: Expected != Actual"
                                   + Environment.NewLine + "1,0,1" + " != " + "1,1,1"
                                   + Environment.NewLine + "Check Y direction;" + Environment.NewLine,
                                   "TestName2"
                                   + Environment.NewLine + "Test Failed: Expected != Actual"
                                   + Environment.NewLine + "5,5,5" + " != " + "0,0,0"
                                   + Environment.NewLine + "Check X direction;"
                                   + Environment.NewLine + "Check Y direction;"
                                   + Environment.NewLine + "Check Z direction;" + Environment.NewLine});
            Add(new List<Vector3d> { new Vector3d(1.20349, 1, 1) },
                new List<Vector3d> { new Vector3d(1.20349, 1, 1) },
                new List<string> { "TestName" },
                0.0,
                new List<string> { });
            Add(new List<Vector3d> { new Vector3d(1.20349, 1, 1) },
                new List<Vector3d> { new Vector3d(1.20348, 1, 1) },
                new List<string> { "TestName" },
                0.0,
                new List<string> {"TestName"
                                  + Environment.NewLine + "Test Failed: Expected != Actual"
                                  + Environment.NewLine + "1.20349,1,1" + " != " + "1.20348,1,1"
                                  + Environment.NewLine + "Check X direction;" + Environment.NewLine});
            Add(new List<Vector3d> { new Vector3d(1.2034923049034902394023940239420490, 1, 1) },
                new List<Vector3d> { new Vector3d(1.2034923049034902394023940239420495, 1, 1) },
                new List<string> { "TestName" },
                0.0,
                new List<string> { });
            Add(new List<Vector3d> { new Vector3d(1.12, 1, 1) },
                new List<Vector3d> { new Vector3d(1.13, 1, 1) },
                new List<string> { "TestName" },
                0.01,
                new List<string> { });
            Add(new List<Vector3d> { new Vector3d(1.12, 1, 1) },
                new List<Vector3d> { new Vector3d(1.13, 1, 1) },
                new List<string> { "TestName" },
                0.001,
                new List<string> { "TestName"
                                   + Environment.NewLine + "Test Failed: Expected != Actual"
                                   + Environment.NewLine + "1.12,1,1" + " != " + "1.13,1,1"
                                   + Environment.NewLine + "Check X direction;" + Environment.NewLine});
        }
    }
}