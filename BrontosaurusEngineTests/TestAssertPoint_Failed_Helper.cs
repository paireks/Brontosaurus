using System;
using System.Collections.Generic;
using Xunit;
using BrontosaurusEngine;
using Rhino.Geometry;

namespace BrontosaurusEngineTests
{
    public class TestAssertPoint_Failed_Helper : TheoryData<List<Point3d>, List<Point3d>, List<string>, bool>
    {
        public TestAssertPoint_Failed_Helper()
        {
            Add(new List<Point3d> { new Point3d(0, 0, 0) },
                new List<Point3d> { new Point3d(0, 0, 0) },
                new List<string> { "TestName" },
                false);
            Add(new List<Point3d> { new Point3d(1, 0, 0) },
                new List<Point3d> { new Point3d(0, 1, 0) },
                new List<string> { "TestName" },
                true);
            Add(new List<Point3d> { new Point3d(1, 0, 0), new Point3d(1, 0, 0) },
                new List<Point3d> { new Point3d(0, 0, 0), new Point3d(0, 0, 0) },
                new List<string> { "TestName1", "TestName2" },
                true);
            Add(new List<Point3d> { new Point3d(1, 0, 0), new Point3d(0, 1, 0) },
                new List<Point3d> { new Point3d(1, 0, 0), new Point3d(0, 1, 0) },
                new List<string> { "TestName1", "TestName2" },
                false);
        }
    }
}