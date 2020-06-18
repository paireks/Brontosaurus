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
    public class AssertListGH : GH_Component
    {
        private bool _testsFailed;
        private bool _unusedComponent = true;
        public AssertListGH()
          : base("Assert List", "Assert List",
              "This component will treat testing your whole list as one test with one result." +
              " If your actual list == expected list: component will pass the test.",
              "Brontosaurus", "Assert")
        {
        }
        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
            pManager.AddTextParameter("Test Name",
                "Test Name",
                "One test name for whole test",
                GH_ParamAccess.item);
            pManager.AddTextParameter("Expected List",
                "Expected List",
                "Expected list",
                GH_ParamAccess.list);
            pManager.AddTextParameter("Actual List",
                "Actual List",
                "Actual list",
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
            List<string> actual = new List<string>();
            List<string> expected = new List<string>();

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
                    return Properties.Resources.AssertList;
                }
            }
        }
        public override Guid ComponentGuid
        {
            get { return new Guid("062f6484-69e4-4c71-9e67-227b59c5ee16"); }
        }
    }
}
