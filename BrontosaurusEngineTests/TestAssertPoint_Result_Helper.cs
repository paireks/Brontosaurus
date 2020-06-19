using System;
using System.Collections.Generic;
using Xunit;
using BrontosaurusEngine;
using Rhino.Geometry;

namespace BrontosaurusEngineTests
{
    public class TestAssertPoint_Result_Helper : TheoryData<List<Point3d>, List<Point3d>, List<string>, List<string>>
    {
        public TestAssertPoint_Result_Helper()
        {
            Add(new List<Point3d> { new Point3d(0, 0, 0) },
                new List<Point3d> { new Point3d(0, 0, 0) },
                new List<string> { "TestName" },
                new List<string> { "TestName;OK" });
            Add(new List<Point3d> { new Point3d(1, 0, 0) },
                new List<Point3d> { new Point3d(0, 0, 0) },
                new List<string> { "TestName" },
                new List<string> { "TestName;FAILED" });
            Add(new List<Point3d> { new Point3d(0, 0, 0) },
                new List<Point3d> { new Point3d(0, 1, 0) },
                new List<string> { "TestName" },
                new List<string> { "TestName;FAILED" });
            Add(new List<Point3d> { new Point3d(0, 1, 0), new Point3d(0, 1, 1) },
                new List<Point3d> { new Point3d(0, 1, 0), new Point3d(0, 1, 1) },
                new List<string> { "TestName1", "TestName2" },
                new List<string> { "TestName1;OK", "TestName2;OK" });
            Add(new List<Point3d> { new Point3d(0, 0, 0), new Point3d(0, 1, 1) },
                new List<Point3d> { new Point3d(0, 1, 0), new Point3d(0, 1, 1) },
                new List<string> { "TestName1", "TestName2" },
                new List<string> { "TestName1;FAILED", "TestName2;OK" });
            Add(new List<Point3d> { new Point3d(0, 0, 0), new Point3d(0, 1, 1) },
                new List<Point3d> { new Point3d(0, 1, 0), new Point3d(0, 0, 1) },
                new List<string> { "TestName1", "TestName2" },
                new List<string> { "TestName1;FAILED", "TestName2;FAILED" });
        }
    }
}