using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrontosaurusEngine
{
    public class Test
    {
        private List<string> _result;
        private List<string> _failedInfo;
        private bool _failed;
        public Test(List<string> expected, List<string> actual, List<string> names)
        {
            Expected = expected;
            Actual = actual;
            Names = names;
            
            _result = new List<string>();
            _failedInfo = new List<string>();

            if (Expected.Count != Actual.Count || Expected.Count != Names.Count)
            {
                throw new ArgumentException("Expected list should match actual and names - check if all three lists have the same number of elements");
            }

            _failed = false;

            for (int i = 0; i < Actual.Count; i++)
            {
                if (Expected[i] == Actual[i])
                {
                    Result.Add(Names[i] + ";OK");
                }
                else
                {
                    Result.Add(Names[i] + ";FAILED");
                    FailedInfo.Add(Names[i] + Environment.NewLine + "Test Failed: Expected != Actual" + Environment.NewLine + Expected[i] + " != " + Actual[i]);
                    _failed = true;
                }
            }
        }


        public Test(List<bool> actual, List<string> names)
        {
            ActualBoolean = actual;
            Names = names;

            _result = new List<string>();
            _failedInfo = new List<string>();

            if (ActualBoolean.Count != Names.Count)
            {
                throw new ArgumentException("Actual list should match names list - check if both lists have the same number of elements");
            }

            _failed = false;

            for (int i = 0; i < ActualBoolean.Count; i++)
            {
                if (ActualBoolean[i])
                {
                    Result.Add(Names[i] + ";OK");
                }
                else
                {
                    Result.Add(Names[i] + ";FAILED");
                    FailedInfo.Add(Names[i] + Environment.NewLine + "Test Failed: True != False");
                    _failed = true;
                }
            }
        }

        public List<string> Expected { get; set; }
        public List<bool> ActualBoolean { get; set; }
        public List<string> Actual { get; set; }
        public List<string> Names { get; set; }
        public List<string> Result
        {
            get { return _result; }
        }
        public List<string> FailedInfo
        {
            get { return _failedInfo; }
        }
        public bool Failed
        {
            get { return _failed; }
        }
    }
}