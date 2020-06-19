using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rhino.Geometry;

namespace BrontosaurusEngine
{
    public class TestLists
    {
        private string _result;
        private List<string> _failedInfo;
        private bool _failed;
        public TestLists(List<string> expectedList, List<string> actualList, string name)
        {
            ExpectedList = expectedList;
            ActualList = actualList;
            Name = name;

            _failedInfo = new List<string>();

            _failed = false;

            if (ExpectedList.Count != ActualList.Count)
            {
                _failedInfo.Add("There is a difference between number of elements for both lists"
                                + Environment.NewLine + "Expected list length: " + ExpectedList.Count
                                + Environment.NewLine + "Actual list length: " + ActualList.Count
                                + Environment.NewLine);
                _failed = true;
            }
            else 
            {
                for (int i = 0; i < ActualList.Count; i++)
                {
                    if (ExpectedList[i] != ActualList[i])
                    {
                        _failedInfo.Add("Check element " + i.ToString() + Environment.NewLine + ExpectedList[i] + " != " + ActualList[i]);
                        _failed = true;
                    }
                }
            }

            if (_failed)
            {
                _result = Name + ";FAILED";
            }
            else
            {
                _result = Name + ";OK";
            }
        }
        public TestLists(List<Vector3d> expectedList, List<Vector3d> actualList, string name)
        {
            ExpectedVectorList = expectedList;
            ActualVectorList = actualList;
            Name = name;

            _failedInfo = new List<string>();

            _failed = false;

            string _failedString;

            if (ExpectedVectorList.Count != ActualVectorList.Count)
            {
                _failedInfo.Add("There is a difference between number of elements for both lists"
                                + Environment.NewLine + "Expected list length: " + ExpectedVectorList.Count
                                + Environment.NewLine + "Actual list length: " + ActualVectorList.Count
                                + Environment.NewLine);
                _failed = true;
            }
            else
            {
                for (int i = 0; i < ActualVectorList.Count; i++)
                {
                    _failedString = "";
                    if (ExpectedVectorList[i] != ActualVectorList[i])
                    {
                        if (ExpectedVectorList[i].X.ToString() != ActualVectorList[i].X.ToString())
                        {
                            _failedString += "Check X direction;" + Environment.NewLine;
                        }
                        if (ExpectedVectorList[i].Y.ToString() != ActualVectorList[i].Y.ToString())
                        {
                            _failedString += "Check Y direction;" + Environment.NewLine;
                        }
                        if (ExpectedVectorList[i].Z.ToString() != ActualVectorList[i].Z.ToString())
                        {
                            _failedString += "Check Z direction;" + Environment.NewLine;
                        }
                        _failedInfo.Add("Check element " + i.ToString()
                                                         + Environment.NewLine + ExpectedVectorList[i] + " != " + ActualVectorList[i]
                                                         + Environment.NewLine + _failedString);
                        _failed = true;
                    }
                }
            }
            if (_failed)
            {
                _result = Name + ";FAILED";
            }
            else
            {
                _result = Name + ";OK";
            }
        }
        public TestLists(List<Point3d> expectedList, List<Point3d> actualList, string name)
        {
            ExpectedPointList = expectedList;
            ActualPointList = actualList;
            Name = name;

            _failedInfo = new List<string>();

            _failed = false;

            string _failedString;

            if (ExpectedPointList.Count != ActualPointList.Count)
            {
                _failedInfo.Add("There is a difference between number of elements for both lists"
                                + Environment.NewLine + "Expected list length: " + ExpectedPointList.Count
                                + Environment.NewLine + "Actual list length: " + ActualPointList.Count
                                + Environment.NewLine);
                _failed = true;
            }
            else
            {
                for (int i = 0; i < ActualPointList.Count; i++)
                {
                    _failedString = "";
                    if (ExpectedPointList[i] != ActualPointList[i])
                    {
                        if (ExpectedPointList[i].X.ToString() != ActualPointList[i].X.ToString())
                        {
                            _failedString += "Check X coordinate;" + Environment.NewLine;
                        }
                        if (ExpectedPointList[i].Y.ToString() != ActualPointList[i].Y.ToString())
                        {
                            _failedString += "Check Y coordinate;" + Environment.NewLine;
                        }
                        if (ExpectedPointList[i].Z.ToString() != ActualPointList[i].Z.ToString())
                        {
                            _failedString += "Check Z coordinate;" + Environment.NewLine;
                        }
                        _failedInfo.Add("Check element " + i.ToString()
                                                         + Environment.NewLine + ExpectedPointList[i] + " != " + ActualPointList[i]
                                                         + Environment.NewLine + _failedString);
                        _failed = true;
                    }
                }
            }
            if (_failed)
            {
                _result = Name + ";FAILED";
            }
            else
            {
                _result = Name + ";OK";
            }
        }
        public List<string> ExpectedList { get; set; }
        public List<Vector3d> ExpectedVectorList { get; set; }
        public List<Point3d> ExpectedPointList { get; set; }
        public List<string> ActualList { get; set; }
        public List<Vector3d> ActualVectorList { get; set; }
        public List<Point3d> ActualPointList { get; set; }
        public string Name { get; set; }
        public string Result
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