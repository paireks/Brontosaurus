using System;
using System.Collections.Generic;
using System.Linq;
using Grasshopper.Kernel;
using Rhino.Geometry;

namespace Brontosaurus
{
    public class AssertTrueGH : GH_Component
    {
        private bool _testsPassed;
        private bool _unusedComponent = true;
        public AssertTrueGH()
          : base("Assert True", "Assert True",
              "If your actual value == True: component will pass the test.",
              "Brontosaurus", "Test")
        {
        }
        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
            pManager.AddTextParameter("Test Names",
                "Test Names",
                "Test names as list, so it'll be easier to check which test passed/failed",
                GH_ParamAccess.list);
            pManager.AddBooleanParameter("Expected",
                "Expected",
                "Expected values as list",
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
            List<bool> actual = new List<bool>();

            DA.GetDataList(0, names);
            DA.GetDataList(1, actual);

            DestroyIconCache();

            _testsPassed = true;
            _unusedComponent = false;

            foreach (var currentActual in actual)
            {
                if (currentActual == false)
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
                    return Properties.Resources.Wrong;
                }
            }
        }
        public override Guid ComponentGuid
        {
            get { return new Guid("2e57844a-7d1d-4558-aaac-cc00e10cd89a"); }
        }
    }
}
