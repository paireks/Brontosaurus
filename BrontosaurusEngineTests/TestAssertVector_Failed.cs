using System;
using System.Collections.Generic;
using Xunit;
using BrontosaurusEngine;
using Rhino.Geometry;

namespace BrontosaurusEngineTests
{
    public class TestAssertVector_Failed : TheoryData<List<Vector3d>, List<Vector3d>, List<string>, double, bool>
    {
        public TestAssertVector_Failed()
        {
            Add(new List<Vector3d> { new Vector3d(0, 0, 0) },
                new List<Vector3d> { new Vector3d(0, 0, 0) },
                new List<string> { "TestName" },
                0,
                false);
            Add(new List<Vector3d> { new Vector3d(1, 0, 0) },
                new List<Vector3d> { new Vector3d(1.0, 0, 0) },
                new List<string> { "TestName" },
                0,
                false);
            // --- 15 digits precision ---
            Add(new List<Vector3d> { new Vector3d(1, 0, 0) },
                new List<Vector3d> { new Vector3d(1.0000000000000001, 0, 0) },
                new List<string> { "TestName" },
                0,
                false);
            Add(new List<Vector3d> { new Vector3d(1, 0, 0) },
                new List<Vector3d> { new Vector3d(1.000000000000001, 0, 0) },
                new List<string> { "TestName" },
                0,
                true);
            Add(new List<Vector3d> { new Vector3d(1, 0, 0) },
                new List<Vector3d> { new Vector3d(1.000000000000001, 0, 0) },
                new List<string> { "TestName" },
                0.001,
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
            Add(new List<Vector3d> { new Vector3d(1, 0, 0), new Vector3d(0, 0, 0), new Vector3d(1, 0, 0) },
                new List<Vector3d> { new Vector3d(1, 0, 0), new Vector3d(0, 1, 0), new Vector3d(1, 0, 0) },
                new List<string> { "TestName1", "TestName2", "TestName3" },
                0,
                true);
            Add(new List<Vector3d> { new Vector3d(0, 0, 0), new Vector3d(0, 1, 0), new Vector3d(0, 0, 0) },
                new List<Vector3d> { new Vector3d(1, 0, 0), new Vector3d(0, 1, 0), new Vector3d(1, 0, 0) },
                new List<string> { "TestName1", "TestName2", "TestName3" },
                0,
                true);
        }
    }
}