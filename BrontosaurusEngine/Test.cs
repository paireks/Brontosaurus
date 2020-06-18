using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rhino.Geometry;

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

        public Test(List<Point3d> expected, List<Point3d> actual, List<string> names)
        {
            ExpectedPoints = expected;
            ActualPoints = actual;
            Names = names;

            _result = new List<string>();
            _failedInfo = new List<string>();

            string _failedString;

            if (ExpectedPoints.Count != ActualPoints.Count || ExpectedPoints.Count != Names.Count)
            {
                throw new ArgumentException("Expected list should match actual and names - check if all three lists have the same number of elements");
            }

            _failed = false;

            for (int i = 0; i < ActualPoints.Count; i++)
            {
                if (ExpectedPoints[i] == ActualPoints[i])
                {
                    Result.Add(Names[i] + ";OK");
                }
                else
                {
                    _failedString = "";
                    Result.Add(Names[i] + ";FAILED");
                    if (ExpectedPoints[i].X.ToString() != ActualPoints[i].X.ToString())
                    {
                        _failedString += "Check X coordinate;" + Environment.NewLine;
                    }
                    if (ExpectedPoints[i].Y.ToString() != ActualPoints[i].Y.ToString())
                    {
                        _failedString += "Check Y coordinate;" + Environment.NewLine;
                    }
                    if (ExpectedPoints[i].Z.ToString() != ActualPoints[i].Z.ToString())
                    {
                        _failedString += "Check Z coordinate;" + Environment.NewLine;
                    }
                    FailedInfo.Add(Names[i]
                                   + Environment.NewLine + "Test Failed: Expected != Actual"
                                   + Environment.NewLine + ExpectedPoints[i] + " != " + ActualPoints[i]
                                   + Environment.NewLine + _failedString);
                    _failed = true;
                }
            }
        }

        public Test(List<Vector3d> expected, List<Vector3d> actual, List<string> names)
        {
            ExpectedVectors = expected;
            ActualVectors = actual;
            Names = names;

            _result = new List<string>();
            _failedInfo = new List<string>();

            string _failedString;

            if (ExpectedVectors.Count != ActualVectors.Count || ExpectedVectors.Count != Names.Count)
            {
                throw new ArgumentException("Expected list should match actual and names - check if all three lists have the same number of elements");
            }

            _failed = false;

            for (int i = 0; i < ActualVectors.Count; i++)
            {
                if (ExpectedVectors[i] == ActualVectors[i])
                {
                    Result.Add(Names[i] + ";OK");
                }
                else
                {
                    _failedString = "";
                    Result.Add(Names[i] + ";FAILED");
                    if (ExpectedVectors[i].X.ToString() != ActualVectors[i].X.ToString())
                    {
                        _failedString += "Check X direction;" + Environment.NewLine;
                    }
                    if (ExpectedVectors[i].Y.ToString() != ActualVectors[i].Y.ToString())
                    {
                        _failedString += "Check Y direction;" + Environment.NewLine;
                    }
                    if (ExpectedVectors[i].Z.ToString() != ActualVectors[i].Z.ToString())
                    {
                        _failedString += "Check Z direction;" + Environment.NewLine;
                    }
                    FailedInfo.Add(Names[i]
                                   + Environment.NewLine + "Test Failed: Expected != Actual"
                                   + Environment.NewLine + ExpectedVectors[i] + " != " + ActualVectors[i]
                                   + Environment.NewLine + _failedString);
                    _failed = true;
                }
            }
        }

        public List<string> Expected { get; set; }
        public List<Point3d> ExpectedPoints { get; set; }
        public List<Vector3d> ExpectedVectors { get; set; }
        public List<bool> ActualBoolean { get; set; }
        public List<string> Actual { get; set; }
        public List<Point3d> ActualPoints { get; set; }
        public List<Vector3d> ActualVectors { get; set; }
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