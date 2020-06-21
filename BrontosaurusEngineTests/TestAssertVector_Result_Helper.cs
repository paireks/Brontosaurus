using System;
using System.Collections.Generic;
using Xunit;
using BrontosaurusEngine;
using Rhino.Geometry;

namespace BrontosaurusEngineTests
{
    public class TestAssertVector_Result_Helper : TheoryData<List<Vector3d>, List<Vector3d>, List<string>, double, List<string>>
    {
        public TestAssertVector_Result_Helper()
        {
            Add(new List<Vector3d> { new Vector3d(0, 0, 0) },
                new List<Vector3d> { new Vector3d(0, 0, 0) },
                new List<string> { "TestName" },
                0,
                new List<string> { "TestName;OK" });
            Add(new List<Vector3d> { new Vector3d(1, 0, 0) },
                new List<Vector3d> { new Vector3d(0, 0, 0) },
                new List<string> { "TestName" },
                0,
                new List<string> { "TestName;FAILED" });
            Add(new List<Vector3d> { new Vector3d(0, 0, 0) },
                new List<Vector3d> { new Vector3d(0, 1, 0) },
                new List<string> { "TestName" },
                0,
                new List<string> { "TestName;FAILED" });
            Add(new List<Vector3d> { new Vector3d(0, 1, 0), new Vector3d(0, 1, 1) },
                new List<Vector3d> { new Vector3d(0, 1, 0), new Vector3d(0, 1, 1) },
                new List<string> { "TestName1", "TestName2" },
                0,
                new List<string> { "TestName1;OK", "TestName2;OK" });
            Add(new List<Vector3d> { new Vector3d(0, 0, 0), new Vector3d(0, 1, 1) },
                new List<Vector3d> { new Vector3d(0, 1, 0), new Vector3d(0, 1, 1) },
                new List<string> { "TestName1", "TestName2" },
                0,
                new List<string> { "TestName1;FAILED", "TestName2;OK" });
            Add(new List<Vector3d> { new Vector3d(0, 0, 0), new Vector3d(0, 1, 1) },
                new List<Vector3d> { new Vector3d(0, 1, 0), new Vector3d(0, 0, 1) },
                new List<string> { "TestName1", "TestName2" },
                0,
                new List<string> { "TestName1;FAILED", "TestName2;FAILED" });
            Add(new List<Vector3d> { new Vector3d(0, 0, 0), new Vector3d(0, 1, 1) },
                new List<Vector3d> { new Vector3d(0, 1, 0), new Vector3d(0, 0.5, 0.5) },
                new List<string> { "TestName1", "TestName2" },
                0.5,
                new List<string> { "TestName1;FAILED", "TestName2;OK" });
        }
    }
}