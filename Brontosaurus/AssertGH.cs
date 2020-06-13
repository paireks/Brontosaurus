using System;
using System.Collections.Generic;
using System.Drawing;
using Grasshopper.GUI.Canvas;
using Grasshopper.Kernel;
using Grasshopper.Kernel.Attributes;
using Rhino.Geometry;

namespace Brontosaurus
{
    public class AssertGH : GH_Component
    {
        private bool _testsPassed;
        private bool _unusedComponent = true;
        public AssertGH()
          : base("Assert", "Assert",
              "If your actual value == expected value: component will pass the test.",
              "Brontosaurus", "Test")
        {
        }
        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
            pManager.AddTextParameter("Test Names",
                "Test Names",
                "Test names as list, so it'll be easier to check which test passed/failed",
                GH_ParamAccess.list);
            pManager.AddTextParameter("Expected",
                "Expected",
                "Expected values as list",
                GH_ParamAccess.list);
            pManager.AddTextParameter("Actual",
                "Actual",
                "Actual values that you want to check, as list",
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
            List<string> actual = new List<string>();
            List<string> expected = new List<string>();

            DA.GetDataList(0, names);
            DA.GetDataList(1, actual);
            DA.GetDataList(2, expected);

            DestroyIconCache();

            _testsPassed = true;
            _unusedComponent = false;

            for (int i = 0; i < actual.Count; i++)
            {
                if (actual[i] != expected[i])
                {
                    _testsPassed = false;
                    break;
                }
            }
        }
        protected override System.Drawing.Bitmap Icon
        {
            get
            {
                if (_testsPassed && !_unusedComponent)
                {
                    return Properties.Resources.Ok;
                }
                else if (!_testsPassed && !_unusedComponent)
                {
                    return Properties.Resources.Failed;
                }
                else
                {
                    return Properties.Resources.Assert;
                }
            }
        }
        public override Guid ComponentGuid
        {
            get { return new Guid("2e57844a-7d1d-4558-aaac-cc00e10cd89b"); }
        }
    }
}
