using System;
using System.Collections.Generic;

using Grasshopper.Kernel;
using Rhino.Geometry;

namespace Charonosaurus
{
    public class TotalGH : GH_Component
    {
        private bool _testsPassed;
        private bool _unusedComponent = true;
        public TotalGH()
          : base("Total", "Total",
              "Group tests and create stats for all of them",
              "Charonosaurus", "Group")
        {
        }
        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
            pManager.AddTextParameter("Group Names",
                "Group Names",
                "Group names as list, important for report creation",
                GH_ParamAccess.list);
            pManager.AddTextParameter("Results",
                "Results",
                "Results of tests",
                GH_ParamAccess.list);
        }
        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
            pManager.AddTextParameter("Total Result", "Total Result", "Total result of tests",
                GH_ParamAccess.list);
            pManager.AddTextParameter("Report Part", "Report Part", "Created part of the report",
                GH_ParamAccess.item);
        }
        protected override void SolveInstance(IGH_DataAccess DA)
        {
            List<string> names = new List<string>();
            List<string> results = new List<string>();

            DA.GetDataList(0, names);
            DA.GetDataList(1, results);

            DestroyIconCache();

            _testsPassed = true;
            _unusedComponent = false;
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
            get { return new Guid("f3a6e8be-3b40-4e97-88c1-ca0678261349"); }
        }
    }
}