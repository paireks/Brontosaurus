using System;
using System.Collections.Generic;
using Xunit;
using BrontosaurusEngine;
using Rhino.Geometry;

namespace BrontosaurusEngineTests
{
    public class
        TestAssertVectorList_FailedInfo_Helper : TheoryData<List<Vector3d>, List<Vector3d>, string, List<string>>
    {
        public TestAssertVectorList_FailedInfo_Helper()
        {
            Add(new List<Vector3d> {new Vector3d(0, 0, 0)},
                new List<Vector3d> {new Vector3d(0, 0, 0)},
                "TestName",
                new List<string> { });
            Add(new List<Vector3d> {new Vector3d(0, 0, 0), new Vector3d(0.5, 0.5, 0.5)},
                new List<Vector3d> {new Vector3d(0, 0, 0), new Vector3d(0.5, 0.5, 0.5)},
                "TestName",
                new List<string> { });
            Add(new List<Vector3d> {new Vector3d(1, 0, 0)},
                new List<Vector3d> {new Vector3d(0, 0, 0)},
                "TestName",
                new List<string>
                {
                    "Check element " + 0
                                     + Environment.NewLine + "1,0,0" + " != " + "0,0,0"
                                     + Environment.NewLine + "Check X direction;" + Environment.NewLine
                });
            Add(new List<Vector3d> {new Vector3d(0, 0, 0), new Vector3d(1, 0, 0)},
                new List<Vector3d> {new Vector3d(0, 0, 0), new Vector3d(0, 0, 0)},
                "TestName",
                new List<string>
                {
                    "Check element " + 1
                                     + Environment.NewLine + "1,0,0" + " != " + "0,0,0"
                                     + Environment.NewLine + "Check X direction;" + Environment.NewLine
                });
            Add(new List<Vector3d> {new Vector3d(0, 0, 0), new Vector3d(1, 1, 0)},
                new List<Vector3d> {new Vector3d(0, 0, 0), new Vector3d(0, 0, 0)},
                "TestName",
                new List<string>
                {
                    "Check element " + 1
                                     + Environment.NewLine + "1,1,0" + " != " + "0,0,0"
                                     + Environment.NewLine + "Check X direction;"
                                     + Environment.NewLine + "Check Y direction;" + Environment.NewLine
                });
            Add(new List<Vector3d> { new Vector3d(0, 0, 0), new Vector3d(1, 1, 0) },
                new List<Vector3d> { new Vector3d(0, 0, 1), new Vector3d(0, 0, 0) },
                "TestName",
                new List<string>
                {
                    "Check element " + 0 + Environment.NewLine + "0,0,0" + " != " + "0,0,1"
                                      + Environment.NewLine + "Check Z direction;" + Environment.NewLine,
                    "Check element " + 1 + Environment.NewLine + "1,1,0" + " != " + "0,0,0"
                                         + Environment.NewLine + "Check X direction;"
                                         + Environment.NewLine + "Check Y direction;" + Environment.NewLine
                });
            Add(new List<Vector3d> { new Vector3d(1, 0, 0), new Vector3d(0.5, 0.5, 0.5) },
                new List<Vector3d> { new Vector3d(0, 0, 0) },
                "TestName",
                new List<string> { "There is a difference between number of elements for both lists"
                                   + Environment.NewLine + "Expected list length: " + 2
                                   + Environment.NewLine + "Actual list length: " + 1
                                   + Environment.NewLine });
            Add(new List<Vector3d> { new Vector3d(0.5, 0.5, 0.5) },
                new List<Vector3d> { new Vector3d(0, 0, 0), new Vector3d(0, 0, 0) },
                "TestName",
                new List<string> { "There is a difference between number of elements for both lists"
                                   + Environment.NewLine + "Expected list length: " + 1
                                   + Environment.NewLine + "Actual list length: " + 2
                                   + Environment.NewLine });
        }
    }
}
