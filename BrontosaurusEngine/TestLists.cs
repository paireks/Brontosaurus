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

            for (int i = 0; i < ActualList.Count; i++)
            {
                if (ExpectedList[i] != ActualList[i])
                {
                    _failedInfo.Add("Check element " + i.ToString() + Environment.NewLine + ExpectedList[i] + " != " + ActualList[i]);
                    _failed = true;
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
        public List<string> ActualList { get; set; }
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