using System;
using System.Collections.Generic;
using System.Drawing;
using Grasshopper.GUI.Canvas;
using Grasshopper.Kernel;
using Grasshopper.Kernel.Attributes;
using Rhino.Geometry;
using BrontosaurusEngine;

namespace Brontosaurus
{
    public class AssertVectorGH : GH_Component
    {
        private bool _testsFailed;
        private bool _unusedComponent = true;
        public AssertVectorGH()
          : base("Assert Vector", "Assert Vector",
              "If your actual vector == expected vector: component will pass the test.",
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
            pManager.AddVectorParameter("Expected",
                "Expected",
                "Expected vectors as list",
                GH_ParamAccess.list);
            pManager.AddVectorParameter("Actual",
                "Actual",
                "Actual vectors that you want to check, as list",
                GH_ParamAccess.list);
            pManager.AddNumberParameter("Tolerance",
                "Tolerance",
                "Tolerance - limit distance, to check if actual vector is close enough to expected",
                GH_ParamAccess.item);
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
            List<Vector3d> expected = new List<Vector3d>();
            List<Vector3d> actual = new List<Vector3d>();
            double tolerance = 0.0;

            DA.GetDataList(0, names);
            DA.GetDataList(1, expected);
            DA.GetDataList(2, actual);
            DA.GetData(3, ref tolerance);

            DestroyIconCache();

            Test testObject = new Test(expected, actual, names, tolerance);

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
                    return Properties.Resources.AssertVector;
                }
            }
        }
        public override Guid ComponentGuid
        {
            get { return new Guid("ac7cf21c-1c54-47e1-8fe0-b69c9135deff"); }
        }
    }
}
