using System;
using System.Collections.Generic;
using Xunit;
using BrontosaurusEngine;
using Rhino.Geometry;

namespace BrontosaurusEngineTests
{
    public class TestAssertVectorList_InputProperties : TheoryData<List<Vector3d>, List<Vector3d>, string, double>
    {
        public TestAssertVectorList_InputProperties()
        {
            Add(new List<Vector3d> { new Vector3d(0, 0, 0) },
                new List<Vector3d> { new Vector3d(0, 0, 0) },
                "TestName",
                0);
            Add(new List<Vector3d> { new Vector3d(1, 0, 0) },
                new List<Vector3d> { new Vector3d(0, 1, 0) },
                "TestName",
                0);
            Add(new List<Vector3d> { new Vector3d(1, 0, 0), new Vector3d(1, 0, 0) },
                new List<Vector3d> { new Vector3d(0, 0, 0), new Vector3d(0, 0, 0) },
                "TestName",
                0);
            Add(new List<Vector3d> { new Vector3d(1, 0, 0), new Vector3d(1, 0, 0), new Vector3d(0, 0, 0) },
                new List<Vector3d> { new Vector3d(0, 0, 0), new Vector3d(0, 0, 0), new Vector3d(0, 0, 0) },
                "TestName",
                0);
            Add(new List<Vector3d> { new Vector3d(0, 0, 0) },
                new List<Vector3d> { new Vector3d(0, 0, 0) },
                "TestName",
                0.5);
        }
    }
}