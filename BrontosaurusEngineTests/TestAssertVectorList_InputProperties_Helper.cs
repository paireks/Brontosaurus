using System;
using System.Collections.Generic;
using Xunit;
using BrontosaurusEngine;
using Rhino.Geometry;

namespace BrontosaurusEngineTests
{
    public class TestAssertVectorList_InputProperties_Helper : TheoryData<List<Vector3d>, List<Vector3d>, string>
    {
        public TestAssertVectorList_InputProperties_Helper()
        {
            Add(new List<Vector3d> { new Vector3d(0, 0, 0) },
                new List<Vector3d> { new Vector3d(0, 0, 0) },
                "TestName");
            Add(new List<Vector3d> { new Vector3d(1, 0, 0) },
                new List<Vector3d> { new Vector3d(0, 1, 0) },
                "TestName");
            Add(new List<Vector3d> { new Vector3d(1, 0, 0), new Vector3d(1, 0, 0) },
                new List<Vector3d> { new Vector3d(0, 0, 0), new Vector3d(0, 0, 0) },
                "TestName");
            Add(new List<Vector3d> { new Vector3d(1, 0, 0), new Vector3d(1, 0, 0), new Vector3d(0,0,0) },
                new List<Vector3d> { new Vector3d(0, 0, 0), new Vector3d(0, 0, 0), new Vector3d(0,0,0) },
                "TestName");
        }
    }
}