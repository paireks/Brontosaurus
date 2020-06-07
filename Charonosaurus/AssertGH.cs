using System;
using System.Collections.Generic;
using System.Drawing;
using Grasshopper.GUI.Canvas;
using Grasshopper.Kernel;
using Grasshopper.Kernel.Attributes;
using Rhino.Geometry;

namespace Charonosaurus
{
    public class AssertGH : GH_Component
    {
        public AssertGH()
          : base("Assert", "Assert",
              "If your actual value == expected value: component will pass the test.",
              "Charonosaurus", "Test")
        {
        }
        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
            pManager.AddTextParameter("Test Names",
                "Test Names",
                "Test names as list, so it'll be easier to check which test passed/failed",
                GH_ParamAccess.list);
            pManager.AddTextParameter("Actual",
                "Actual",
                "Actual values that you want to check, as list",
                GH_ParamAccess.list);
            pManager.AddTextParameter("Expected",
                "Expected",
                "Expected values as list",
                GH_ParamAccess.list);
        }
        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
            pManager.AddTextParameter("Result", "Result", "Information about tests, which one passed/failed",
                GH_ParamAccess.list);
            pManager.AddTextParameter("Failed Info", "Failed Info", "Information about failed tests",
                GH_ParamAccess.list);
            pManager.AddTextParameter("ReportPart", "ReportPart",
                "Created part of the report, you can use it with Pterodactyl plugin to create custom reports",
                GH_ParamAccess.item);
        }
        protected override void SolveInstance(IGH_DataAccess DA)
        {
            base.DestroyIconCache();
        }
        private bool A;
        private bool B;
        protected override System.Drawing.Bitmap Icon
        {
            get
            {
                if (A)
                {
                    return Properties.Resources.Ok;
                }
                else if (B)
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
            get { return new Guid("2e57844a-7d1d-4558-aaac-cc00e10cd89b"); }
        }
    }
}
