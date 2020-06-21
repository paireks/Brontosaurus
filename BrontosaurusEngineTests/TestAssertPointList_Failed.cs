using System;
using System.Collections.Generic;
using Xunit;
using BrontosaurusEngine;
using Rhino.Geometry;

namespace BrontosaurusEngineTests
{
    public class TestAssertPointList_Failed : TheoryData<List<Point3d>, List<Point3d>, string, double, bool>
    {
        public TestAssertPointList_Failed()
        {
            Add(new List<Point3d> { new Point3d(0, 0, 0) },
                new List<Point3d> { new Point3d(0, 0, 0) },
                "TestName",
                0,
                false);
            Add(new List<Point3d> { new Point3d(0, 0, 0), new Point3d(1, 1, 1) },
                new List<Point3d> { new Point3d(0, 0, 0), new Point3d(1, 1, 1) },
                "TestName",
                0,
                false);
            Add(new List<Point3d> { new Point3d(1, 0, 0) },
                new List<Point3d> { new Point3d(0, 1, 0) },
                "TestName",
                0,
                true);
            Add(new List<Point3d> { new Point3d(1, 0, 0), new Point3d(1, 0, 0) },
                new List<Point3d> { new Point3d(0, 0, 0), new Point3d(0, 0, 0) },
                "TestName",
                0,
                true);
            Add(new List<Point3d> { new Point3d(1, 0, 0), new Point3d(1, 0, 0), new Point3d(0, 0, 0) },
                new List<Point3d> { new Point3d(0, 0, 0), new Point3d(0, 0, 0), new Point3d(0, 0, 0) },
                "TestName",
                0,
                true);
            Add(new List<Point3d> { new Point3d(0, 0, 0) },
                new List<Point3d> { new Point3d(0.5, 0, 0) },
                "TestName",
                0.5,
                false);
            Add(new List<Point3d> { new Point3d(0, 0, 0) },
                new List<Point3d> { new Point3d(0.6, 0, 0) },
                "TestName",
                0.5,
                true);
        }
    }
}