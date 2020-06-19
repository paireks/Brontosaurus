using System;
using System.Collections.Generic;
using Xunit;
using BrontosaurusEngine;
using Rhino.Geometry;

namespace BrontosaurusEngineTests
{
    public class TestAssertPointList_InputProperties_Helper : TheoryData<List<Point3d>, List<Point3d>, string>
    {
        public TestAssertPointList_InputProperties_Helper()
        {
            Add(new List<Point3d> { new Point3d(0, 0, 0) },
                new List<Point3d> { new Point3d(0, 0, 0) },
                "TestName");
            Add(new List<Point3d> { new Point3d(1, 0, 0) },
                new List<Point3d> { new Point3d(0, 1, 0) },
                "TestName");
            Add(new List<Point3d> { new Point3d(1, 0, 0), new Point3d(1, 0, 0) },
                new List<Point3d> { new Point3d(0, 0, 0), new Point3d(0, 0, 0) },
                "TestName");
            Add(new List<Point3d> { new Point3d(1, 0, 0), new Point3d(1, 0, 0), new Point3d(0, 0, 0) },
                new List<Point3d> { new Point3d(0, 0, 0), new Point3d(0, 0, 0), new Point3d(0, 0, 0) },
                "TestName");
        }
    }
}