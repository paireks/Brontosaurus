using System;
using System.Collections.Generic;
using Xunit;
using BrontosaurusEngine;
using Rhino.Geometry;

namespace BrontosaurusEngineTests
{
    public class TestAssertVectorList_Failed_Helper : TheoryData<List<Vector3d>, List<Vector3d>, string, bool>
    {
        public TestAssertVectorList_Failed_Helper()
        {
            Add(new List<Vector3d> { new Vector3d(0, 0, 0) },
                new List<Vector3d> { new Vector3d(0, 0, 0) },
                "TestName", false);
            Add(new List<Vector3d> { new Vector3d(0, 0, 0), new Vector3d(1, 1, 1) },
                new List<Vector3d> { new Vector3d(0, 0, 0), new Vector3d(1, 1, 1) },
                "TestName", false);
            Add(new List<Vector3d> { new Vector3d(1, 0, 0) },
                new List<Vector3d> { new Vector3d(0, 1, 0) },
                "TestName", true);
            Add(new List<Vector3d> { new Vector3d(1, 0, 0), new Vector3d(1, 0, 0) },
                new List<Vector3d> { new Vector3d(0, 0, 0), new Vector3d(0, 0, 0) },
                "TestName", true);
            Add(new List<Vector3d> { new Vector3d(1, 0, 0), new Vector3d(1, 0, 0), new Vector3d(0, 0, 0) },
                new List<Vector3d> { new Vector3d(0, 0, 0), new Vector3d(0, 0, 0), new Vector3d(0, 0, 0) },
                "TestName", true);
        }
    }
}