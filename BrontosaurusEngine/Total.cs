using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrontosaurusEngine
{
    public class Total
    {
        private int _passedCounter;
        private int _failedCounter;
        private float _passedPercent;
        private string _totalResult;
        private bool _allTestsPassed;
        private string _reportPart;

        public Total(List<string> results)
        {
            Results = results;

            _passedCounter = 0;
            _failedCounter = 0;
            _allTestsPassed = true;
            _reportPart = "| Name | Result |" + Environment.NewLine + "| :---: | :---: |" + Environment.NewLine;

            foreach (var i in Results)
            {
                string[] parts;
                parts = i.Split(Settings.Separator);
                if (parts[1] == "OK")
                {
                    _passedCounter++;
                    _reportPart += "| " + parts[0] + " | <span style=\"color: green\">" + parts[1] + "</span> |" + Environment.NewLine;
                }
                else
                {
                    _failedCounter++;
                    _allTestsPassed = false;
                    _reportPart += "| " + parts[0] + " | <span style=\"color: red\">" + parts[1] + "</span> |" + Environment.NewLine;
                }
            }

            _passedPercent = (float)_passedCounter / (_passedCounter + _failedCounter) * 100;
            _totalResult = "Total result: " + _passedPercent.ToString() + "% tests passed."
                           + Environment.NewLine + "Tests passed: " + _passedCounter
                           + Environment.NewLine + "Tests failed: " + _failedCounter;

            _reportPart = _totalResult + Environment.NewLine + _reportPart;
        }

        public List<string> Results { get; set; }

        public int PassedCounter
        {
            get { return _passedCounter; }
        }

        public int FailedCounter
        {
            get { return _failedCounter; }
        }

        public float PassedPercent
        {
            get { return _passedPercent; }
        }

        public string TotalResult
        {
            get { return _totalResult; }
        }

        public bool AllTestsPassed
        {
            get { return _allTestsPassed; }
        }

        public string ReportPart
        {
            get { return _reportPart; }
        }
    }
}
