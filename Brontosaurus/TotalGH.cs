using System;
using System.Collections.Generic;

using Grasshopper.Kernel;
using Rhino.Geometry;

using BrontosaurusEngine;

namespace Brontosaurus
{
    public class TotalGH : GH_Component
    {
        private bool _testsPassed;
        private bool _unusedComponent = true;
        public TotalGH()
          : base("Total", "Total",
              "Group tests and create stats for all of them",
              "Brontosaurus", "Total")
        {
        }
        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
            pManager.AddTextParameter("Results",
                "Results",
                "Results of tests",
                GH_ParamAccess.list);
        }
        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
            pManager.AddTextParameter("Total Result", "Total Result", "Total result of tests",
                GH_ParamAccess.item);
            pManager.AddTextParameter("Report Part", "Report Part", "Created part of the report",
                GH_ParamAccess.item);
        }
        protected override void SolveInstance(IGH_DataAccess DA)
        {
            List<string> results = new List<string>();

            DA.GetDataList(0, results);

            DestroyIconCache();

            Total totalObject = new Total(results);

            _testsPassed = totalObject.AllTestsPassed;
            _unusedComponent = false;

            DA.SetData(0, totalObject.TotalResult);
            DA.SetData(1, totalObject.ReportPart);
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
                    return Properties.Resources.Total;
                }
            }
        }
        public override Guid ComponentGuid
        {
            get { return new Guid("f3a6e8be-3b40-4e97-88c1-ca0678261349"); }
        }
    }
}