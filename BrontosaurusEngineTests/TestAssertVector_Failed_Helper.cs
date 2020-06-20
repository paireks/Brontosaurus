using System;
using System.Collections.Generic;
using Xunit;
using BrontosaurusEngine;
using Rhino.Geometry;

namespace BrontosaurusEngineTests
{
    public class TestAssertVector_Failed_Helper : TheoryData<List<Vector3d>, List<Vector3d>, List<string>, double, bool>
    {
        public TestAssertVector_Failed_Helper()
        {
            Add(new List<Vector3d> { new Vector3d(0, 0, 0) },
                new List<Vector3d> { new Vector3d(0, 0, 0) },
                new List<string> { "TestName" },
                0,
                false);
            Add(new List<Vector3d> { new Vector3d(1, 0, 0) },
                new List<Vector3d> { new Vector3d(0, 1, 0) },
                new List<string> { "TestName" },
                0,
                true);
            Add(new List<Vector3d> { new Vector3d(1, 0, 0), new Vector3d(1, 0, 0) },
                new List<Vector3d> { new Vector3d(0, 0, 0), new Vector3d(0, 0, 0) },
                new List<string> { "TestName1", "TestName2" },
                0,
                true);
            Add(new List<Vector3d> { new Vector3d(1, 0, 0), new Vector3d(0, 1, 0) },
                new List<Vector3d> { new Vector3d(1, 0, 0), new Vector3d(0, 1, 0) },
                new List<string> { "TestName1", "TestName2" },
                0,
                false);
            Add(new List<Vector3d> { new Vector3d(1, 0, 0), new Vector3d(0, 1, 0) },
                new List<Vector3d> { new Vector3d(1, 0, 0), new Vector3d(0, 0.5, 0) },
                new List<string> { "TestName1", "TestName2" },
                0.5,
                false);
            Add(new List<Vector3d> { new Vector3d(1, 0, 0), new Vector3d(0, 1, 0) },
                new List<Vector3d> { new Vector3d(1, 0, 0), new Vector3d(0, 0.2, 0) },
                new List<string> { "TestName1", "TestName2" },
                0.5,
                true);
        }
    }
}