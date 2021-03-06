﻿using System;
using System.Collections.Generic;
using Xunit;
using BrontosaurusEngine;
using Rhino.Geometry;

namespace BrontosaurusEngineTests
{
    public class TestAssertVectorList_Result : TheoryData<List<Vector3d>, List<Vector3d>, string, double, string>
    {
        public TestAssertVectorList_Result()
        {
            Add(new List<Vector3d> { new Vector3d(0, 0, 0) },
                new List<Vector3d> { new Vector3d(0, 0, 0) },
                "TestName",
                0,
                "TestName;OK");
            Add(new List<Vector3d> { new Vector3d(0, 0, 0), new Vector3d(1, 1, 1) },
                new List<Vector3d> { new Vector3d(0, 0, 0), new Vector3d(1, 1, 1) },
                "TestName",
                0,
                "TestName;OK");
            Add(new List<Vector3d> { new Vector3d(1, 0, 0) },
                new List<Vector3d> { new Vector3d(0, 1, 0) },
                "TestName",
                0,
                "TestName;FAILED");
            Add(new List<Vector3d> { new Vector3d(1, 0, 0), new Vector3d(1, 0, 0) },
                new List<Vector3d> { new Vector3d(0, 0, 0), new Vector3d(0, 0, 0) },
                "TestName",
                0,
                "TestName;FAILED");
            Add(new List<Vector3d> { new Vector3d(1, 0, 0), new Vector3d(1, 0, 0), new Vector3d(0, 0, 0) },
                new List<Vector3d> { new Vector3d(0, 0, 0), new Vector3d(0, 0, 0), new Vector3d(0, 0, 0) },
                "TestName",
                0,
                "TestName;FAILED");
            Add(new List<Vector3d> { new Vector3d(0, 0.5, 0) },
                new List<Vector3d> { new Vector3d(0, 0, 0) },
                "TestName",
                0.5,
                "TestName;OK");
            Add(new List<Vector3d> { new Vector3d(0, 1, 0) },
                new List<Vector3d> { new Vector3d(0, 0, 0) },
                "TestName",
                0.5,
                "TestName;FAILED");
        }
    }
}