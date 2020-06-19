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
    public class AssertVectorListGH : GH_Component
    {
        private bool _testsFailed;
        private bool _unusedComponent = true;
        public AssertVectorListGH()
          : base("Assert Vector List", "Assert Vector List",
              "This component will treat testing your whole list as one test with one result." +
              " If your actual list == expected list: component will pass the test.",
              "Brontosaurus", "Assert Geo")
        {
        }
        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
            pManager.AddTextParameter("Test Name",
                "Test Name",
                "One test name for whole test",
                GH_ParamAccess.item);
            pManager.AddVectorParameter("Expected Vector List",
                "Expected Vector List",
                "Expected list of vectors",
                GH_ParamAccess.list);
            pManager.AddVectorParameter("Actual Vector List",
                "Actual Vector List",
                "Actual list of vectors",
                GH_ParamAccess.list);
        }
        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
            pManager.AddTextParameter("Result", "Result", "Result of test",
                GH_ParamAccess.item);
            pManager.AddTextParameter("Failed Info", "Failed Info", "Information about failed test",
                GH_ParamAccess.list);
        }
        protected override void SolveInstance(IGH_DataAccess DA)
        {
            string name = "";
            List<Vector3d> actual = new List<Vector3d>();
            List<Vector3d> expected = new List<Vector3d>();

            DA.GetData(0, ref name);
            DA.GetDataList(1, actual);
            DA.GetDataList(2, expected);

            DestroyIconCache();

            TestLists testObject = new TestLists(expected, actual, name);

            _testsFailed = testObject.Failed;
            _unusedComponent = false;

            DA.SetData(0, testObject.Result);
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
                    return Properties.Resources.AssertVectors;
                }
            }
        }
        public override Guid ComponentGuid
        {
            get { return new Guid("dd744886-bd7f-4f1a-9d78-443f878533f6"); }
        }
    }
}
