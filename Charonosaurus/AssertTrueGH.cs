using System;
using System.Collections.Generic;

using Grasshopper.Kernel;
using Rhino.Geometry;

namespace Charonosaurus
{
    public class AssertTrueGH : GH_Component
    {
        public AssertTrueGH()
          : base("Assert True", "Assert True",
              "If your actual value == True: component will pass the test.",
              "Pterodactyl", "Test")
        {
        }
        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
            pManager.AddTextParameter("Test Names",
                "Test Names",
                "Test names as list, so it'll be easier to check which test passed/failed",
                GH_ParamAccess.list);
            pManager.AddBooleanParameter("Actual",
                "Actual",
                "Actual values that you want to check, as list",
                GH_ParamAccess.list);
        }
        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
            pManager.AddTextParameter("Result", "Result", "Information about tests, which one passed/failed",
                GH_ParamAccess.list);
            pManager.AddTextParameter("ReportPart", "ReportPart",
                "Created part of the report, you can use it with Pterodactyl plugin to create custom reports",
                GH_ParamAccess.item);
        }
        protected override void SolveInstance(IGH_DataAccess DA)
        {

        }
        protected override System.Drawing.Bitmap Icon
        {
            get
            {
                return null;
            }
        }
        public override Guid ComponentGuid
        {
            get { return new Guid("2e57844a-7d1d-4558-aaac-cc00e10cd89a"); }
        }
    }
}
