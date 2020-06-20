using System;
using System.Collections.Generic;
using Xunit;
using BrontosaurusEngine;
using Rhino.Geometry;

namespace BrontosaurusEngineTests
{
    public class TestAssertPoint_InputProperties_Exception_Helper : TheoryData<List<Point3d>, List<Point3d>, List<string>, double, string>
    {
        public TestAssertPoint_InputProperties_Exception_Helper()
        {
            Add(new List<Point3d> { new Point3d(0, 0, 0), new Point3d(1, 0, 0) },
                new List<Point3d> { new Point3d(0, 0, 0) },
                new List<string> { "TestName" },
                0,
                "Expected list should match actual and names - check if all three lists have the same number of elements");
            Add(new List<Point3d> { new Point3d(0, 0, 0), new Point3d(1, 0, 0) },
                new List<Point3d> { new Point3d(0, 0, 0) },
                new List<string> { "TestName", "TestName2" },
                1.0,
                "Expected list should match actual and names - check if all three lists have the same number of elements");
            Add(new List<Point3d> { new Point3d(0, 0, 0), new Point3d(1, 0, 0) },
                new List<Point3d> { new Point3d(0, 0, 0), new Point3d(1, 0, 0) },
                new List<string> { "TestName" },
                0.1,
                "Expected list should match actual and names - check if all three lists have the same number of elements");
        }
    }
}