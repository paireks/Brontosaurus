using System;
using System.Collections.Generic;
using Xunit;
using BrontosaurusEngine;
using Rhino.Geometry;

namespace BrontosaurusEngineTests
{
    public class TestAssertPointList_Result_Helper : TheoryData<List<Point3d>, List<Point3d>, string, double, string>
    {
        public TestAssertPointList_Result_Helper()
        {
            Add(new List<Point3d> { new Point3d(0, 0, 0) },
                new List<Point3d> { new Point3d(0, 0, 0) },
                "TestName",
                0,
                "TestName;OK");
            Add(new List<Point3d> { new Point3d(0, 0, 0), new Point3d(1, 1, 1) },
                new List<Point3d> { new Point3d(0, 0, 0), new Point3d(1, 1, 1) },
                "TestName",
                0,
                "TestName;OK");
            Add(new List<Point3d> { new Point3d(1, 0, 0) },
                new List<Point3d> { new Point3d(0, 1, 0) },
                "TestName",
                0,
                "TestName;FAILED");
            Add(new List<Point3d> { new Point3d(1, 0, 0), new Point3d(1, 0, 0) },
                new List<Point3d> { new Point3d(0, 0, 0), new Point3d(0, 0, 0) },
                "TestName",
                0,
                "TestName;FAILED");
            Add(new List<Point3d> { new Point3d(1, 0, 0), new Point3d(1, 0, 0), new Point3d(0, 0, 0) },
                new List<Point3d> { new Point3d(0, 0, 0), new Point3d(0, 0, 0), new Point3d(0, 0, 0) },
                "TestName",
                0,
                "TestName;FAILED");
            Add(new List<Point3d> { new Point3d(0, 0.5, 0) },
                new List<Point3d> { new Point3d(0, 0, 0) },
                "TestName",
                0.5,
                "TestName;OK");
            Add(new List<Point3d> { new Point3d(0, 1, 0) },
                new List<Point3d> { new Point3d(0, 0, 0) },
                "TestName",
                0.5,
                "TestName;FAILED");
        }
    }
}