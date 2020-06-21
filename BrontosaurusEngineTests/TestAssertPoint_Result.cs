using System;
using System.Collections.Generic;
using Xunit;
using BrontosaurusEngine;
using Rhino.Geometry;

namespace BrontosaurusEngineTests
{
    public class TestAssertPoint_Result : TheoryData<List<Point3d>, List<Point3d>, List<string>, double, List<string>>
    {
        public TestAssertPoint_Result()
        {
            Add(new List<Point3d> { new Point3d(0, 0, 0) },
                new List<Point3d> { new Point3d(0, 0, 0) },
                new List<string> { "TestName" },
                0,
                new List<string> { "TestName;OK" });
            Add(new List<Point3d> { new Point3d(1, 0, 0) },
                new List<Point3d> { new Point3d(0, 0, 0) },
                new List<string> { "TestName" },
                0,
                new List<string> { "TestName;FAILED" });
            Add(new List<Point3d> { new Point3d(0, 0, 0) },
                new List<Point3d> { new Point3d(0, 1, 0) },
                new List<string> { "TestName" },
                0,
                new List<string> { "TestName;FAILED" });
            Add(new List<Point3d> { new Point3d(0, 1, 0), new Point3d(0, 1, 1) },
                new List<Point3d> { new Point3d(0, 1, 0), new Point3d(0, 1, 1) },
                new List<string> { "TestName1", "TestName2" },
                0,
                new List<string> { "TestName1;OK", "TestName2;OK" });
            Add(new List<Point3d> { new Point3d(0, 0, 0), new Point3d(0, 1, 1) },
                new List<Point3d> { new Point3d(0, 1, 0), new Point3d(0, 1, 1) },
                new List<string> { "TestName1", "TestName2" },
                0,
                new List<string> { "TestName1;FAILED", "TestName2;OK" });
            Add(new List<Point3d> { new Point3d(0, 0, 0), new Point3d(0, 1, 1) },
                new List<Point3d> { new Point3d(0, 1, 0), new Point3d(0, 0, 1) },
                new List<string> { "TestName1", "TestName2" },
                0,
                new List<string> { "TestName1;FAILED", "TestName2;FAILED" });
            Add(new List<Point3d> { new Point3d(0, 0, 0), new Point3d(0, 1, 1) },
                new List<Point3d> { new Point3d(0, 1, 0), new Point3d(0, 0.5, 0.5) },
                new List<string> { "TestName1", "TestName2" },
                0.6,
                new List<string> { "TestName1;FAILED", "TestName2;OK" });
            Add(new List<Point3d> { new Point3d(0, 0, 0), new Point3d(0, 1, 1) },
                new List<Point3d> { new Point3d(0, 1, 0), new Point3d(0, 0.5, 0.5) },
                new List<string> { "TestName1", "TestName2" },
                0.5,
                new List<string> { "TestName1;FAILED", "TestName2;OK" });
        }
    }
}