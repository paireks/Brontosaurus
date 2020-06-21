using System;
using System.Collections.Generic;
using Xunit;
using BrontosaurusEngine;
using Rhino.Geometry;

namespace BrontosaurusEngineTests
{
    public class TestAssertPoint_Failed_Helper : TheoryData<List<Point3d>, List<Point3d>, List<string>, double, bool>
    {
        public TestAssertPoint_Failed_Helper()
        {
            Add(new List<Point3d> { new Point3d(0, 0, 0) },
                new List<Point3d> { new Point3d(0, 0, 0) },
                new List<string> { "TestName" },
                0,
                false);
            Add(new List<Point3d> { new Point3d(1, 0, 0) },
                new List<Point3d> { new Point3d(1.0, 0, 0) },
                new List<string> { "TestName" },
                0,
                false);
            // --- 15 digits precision ---
            Add(new List<Point3d> { new Point3d(1, 0, 0) },
                new List<Point3d> { new Point3d(1.0000000000000001, 0, 0) },
                new List<string> { "TestName" },
                0,
                false);
            Add(new List<Point3d> { new Point3d(1, 0, 0) },
                new List<Point3d> { new Point3d(1.000000000000001, 0, 0) },
                new List<string> { "TestName" },
                0,
                true);
            Add(new List<Point3d> { new Point3d(1, 0, 0) },
                new List<Point3d> { new Point3d(1.000000000000001, 0, 0) },
                new List<string> { "TestName" },
                0.001,
                false);
            Add(new List<Point3d> { new Point3d(1, 0, 0) },
                new List<Point3d> { new Point3d(0, 1, 0) },
                new List<string> { "TestName" },
                0,
                true);
            Add(new List<Point3d> { new Point3d(1, 0, 0), new Point3d(1, 0, 0) },
                new List<Point3d> { new Point3d(0, 0, 0), new Point3d(0, 0, 0) },
                new List<string> { "TestName1", "TestName2" },
                0,
                true);
            Add(new List<Point3d> { new Point3d(1, 0, 0), new Point3d(0, 1, 0) },
                new List<Point3d> { new Point3d(1, 0, 0), new Point3d(0, 1, 0) },
                new List<string> { "TestName1", "TestName2" },
                0,
                false);
            Add(new List<Point3d> { new Point3d(1, 0, 0), new Point3d(0, 0, 0), new Point3d(1,0,0) },
                new List<Point3d> { new Point3d(1, 0, 0), new Point3d(0, 1, 0), new Point3d(1,0,0) },
                new List<string> { "TestName1", "TestName2", "TestName3" },
                0,
                true);
            Add(new List<Point3d> { new Point3d(0, 0, 0), new Point3d(0, 1, 0), new Point3d(0, 0, 0) },
                new List<Point3d> { new Point3d(1, 0, 0), new Point3d(0, 1, 0), new Point3d(1, 0, 0) },
                new List<string> { "TestName1", "TestName2", "TestName3" },
                0,
                true);
        }
    }
}