using System;
using System.Collections.Generic;
using Xunit;
using BrontosaurusEngine;
using Rhino.Geometry;

namespace BrontosaurusEngineTests
{
    public class TestAssertVector_InputProperties_Exception_Helper : TheoryData<List<Vector3d>, List<Vector3d>, List<string>, double, string>
    {
        public TestAssertVector_InputProperties_Exception_Helper()
        {
            Add(new List<Vector3d> { new Vector3d(0, 0, 0), new Vector3d(1, 0, 0) },
                new List<Vector3d> { new Vector3d(0, 0, 0) },
                new List<string> { "TestName" },
                0,
                "Expected list should match actual and names - check if all three lists have the same number of elements");
            Add(new List<Vector3d> { new Vector3d(0, 0, 0), new Vector3d(1, 0, 0) },
                new List<Vector3d> { new Vector3d(0, 0, 0) },
                new List<string> { "TestName", "TestName2" },
                0,
                "Expected list should match actual and names - check if all three lists have the same number of elements");
            Add(new List<Vector3d> { new Vector3d(0, 0, 0), new Vector3d(1, 0, 0) },
                new List<Vector3d> { new Vector3d(0, 0, 0), new Vector3d(1, 0, 0) },
                new List<string> { "TestName" },
                0,
                "Expected list should match actual and names - check if all three lists have the same number of elements");
        }
    }
}