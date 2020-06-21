using System;
using System.Collections.Generic;
using Xunit;
using BrontosaurusEngine;
using Rhino.Geometry;

namespace BrontosaurusEngineTests
{
    public class
        TestAssertPointList_FailedInfo : TheoryData<List<Point3d>, List<Point3d>, string, double, List<string>>
    {
        public TestAssertPointList_FailedInfo()
        {
            Add(new List<Point3d> { new Point3d(0, 0, 0) },
                new List<Point3d> { new Point3d(0, 0, 0) },
                "TestName",
                0,
                new List<string> { });
            Add(new List<Point3d> { new Point3d(0, 0, 0), new Point3d(0.5, 0.5, 0.5) },
                new List<Point3d> { new Point3d(0, 0, 0), new Point3d(0.5, 0.5, 0.5) },
                "TestName",
                0,
                new List<string> { });
            Add(new List<Point3d> { new Point3d(1, 0, 0) },
                new List<Point3d> { new Point3d(0, 0, 0) },
                "TestName",
                0,
                new List<string>
                {
                    "Check element " + 0
                                     + Environment.NewLine + "1,0,0" + " != " + "0,0,0"
                                     + Environment.NewLine + "Check X coordinate;" + Environment.NewLine
                });
            Add(new List<Point3d> { new Point3d(0, 0, 0), new Point3d(1, 0, 0) },
                new List<Point3d> { new Point3d(0, 0, 0), new Point3d(0, 0, 0) },
                "TestName",
                0,
                new List<string>
                {
                    "Check element " + 1
                                     + Environment.NewLine + "1,0,0" + " != " + "0,0,0"
                                     + Environment.NewLine + "Check X coordinate;" + Environment.NewLine
                });
            Add(new List<Point3d> { new Point3d(0, 0, 0), new Point3d(1, 1, 0) },
                new List<Point3d> { new Point3d(0, 0, 0), new Point3d(0, 0, 0) },
                "TestName",
                0,
                new List<string>
                {
                    "Check element " + 1
                                     + Environment.NewLine + "1,1,0" + " != " + "0,0,0"
                                     + Environment.NewLine + "Check X coordinate;"
                                     + Environment.NewLine + "Check Y coordinate;" + Environment.NewLine
                });
            Add(new List<Point3d> { new Point3d(0, 0, 0), new Point3d(1, 1, 0) },
                new List<Point3d> { new Point3d(0, 0, 1), new Point3d(0, 0, 0) },
                "TestName",
                0,
                new List<string>
                {
                    "Check element " + 0 + Environment.NewLine + "0,0,0" + " != " + "0,0,1"
                                      + Environment.NewLine + "Check Z coordinate;" + Environment.NewLine,
                    "Check element " + 1 + Environment.NewLine + "1,1,0" + " != " + "0,0,0"
                                         + Environment.NewLine + "Check X coordinate;"
                                         + Environment.NewLine + "Check Y coordinate;" + Environment.NewLine
                });
            Add(new List<Point3d> { new Point3d(1, 0, 0), new Point3d(0.5, 0.5, 0.5) },
                new List<Point3d> { new Point3d(0, 0, 0) },
                "TestName",
                0,
                new List<string> { "There is a difference between number of elements for both lists"
                                   + Environment.NewLine + "Expected list length: " + 2
                                   + Environment.NewLine + "Actual list length: " + 1
                                   + Environment.NewLine });
            Add(new List<Point3d> { new Point3d(0.5, 0.5, 0.5) },
                new List<Point3d> { new Point3d(0, 0, 0), new Point3d(0, 0, 0) },
                "TestName",
                0,
                new List<string> { "There is a difference between number of elements for both lists"
                                   + Environment.NewLine + "Expected list length: " + 1
                                   + Environment.NewLine + "Actual list length: " + 2
                                   + Environment.NewLine });
            Add(new List<Point3d> { new Point3d(0.5, 0, 0) },
                new List<Point3d> { new Point3d(0, 0, 0) },
                "TestName",
                0.5,
                new List<string> { });
            Add(new List<Point3d> { new Point3d(1, 0, 0) },
                new List<Point3d> { new Point3d(0.4, 0, 0) },
                "TestName",
                0.5,
                new List<string>
                {
                    "Check element " + 0
                                     + Environment.NewLine + "1,0,0" + " != " + "0.4,0,0"
                                     + Environment.NewLine + "Check X coordinate;" + Environment.NewLine
                });
        }
    }
}
