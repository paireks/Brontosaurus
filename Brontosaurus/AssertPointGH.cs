﻿using System;
using System.Collections.Generic;
using System.Drawing;
using Grasshopper.GUI.Canvas;
using Grasshopper.Kernel;
using Grasshopper.Kernel.Attributes;
using Rhino.Geometry;
using BrontosaurusEngine;

namespace Brontosaurus
{
    public class AssertPointGH : GH_Component
    {
        private bool _testsFailed;
        private bool _unusedComponent = true;
        public AssertPointGH()
          : base("Assert Point", "Assert Point",
              "If your actual point coordinates == expected point coordinates: component will pass the test.",
              "Brontosaurus", "Assert Geo")
        {
        }
        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
            pManager.AddTextParameter("Test Names",
                "Test Names",
                "Test names as list, so it'll be easier to check which test passed/failed." +
                " Every name should match every assert (expected and actual value)",
                GH_ParamAccess.list);
            pManager.AddPointParameter("Expected",
                "Expected",
                "Expected points as list",
                GH_ParamAccess.list);
            pManager.AddPointParameter("Actual",
                "Actual",
                "Actual points that you want to check, as list",
                GH_ParamAccess.list);
        }
        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
            pManager.AddTextParameter("Result", "Result", "Result of tests",
                GH_ParamAccess.list);
            pManager.AddTextParameter("Failed Info", "Failed Info", "Information about failed tests",
                GH_ParamAccess.list);
        }
        protected override void SolveInstance(IGH_DataAccess DA)
        {
            List<string> names = new List<string>();
            List<Point3d> actual = new List<Point3d>();
            List<Point3d> expected = new List<Point3d>();

            DA.GetDataList(0, names);
            DA.GetDataList(1, actual);
            DA.GetDataList(2, expected);

            DestroyIconCache();

            Test testObject = new Test(expected, actual, names);

            _testsFailed = testObject.Failed;
            _unusedComponent = false;

            DA.SetDataList(0, testObject.Result);
            DA.SetDataList(1, testObject.FailedInfo);
        }
        protected override System.Drawing.Bitmap Icon
        {
            get
            {
                if (!_testsFailed && !_unusedComponent)
                {
                    return Properties.Resources.Ok;
                }
                else if (_testsFailed && !_unusedComponent)
                {
                    return Properties.Resources.Failed;
                }
                else
                {
                    return Properties.Resources.AssertPoint;
                }
            }
        }
        public override Guid ComponentGuid
        {
            get { return new Guid("597a3afc-5c8b-4bd1-a2b2-b7019f36c058"); }
        }
    }
}