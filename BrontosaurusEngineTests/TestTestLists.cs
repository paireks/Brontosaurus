using System;
using System.Collections.Generic;
using Xunit;
using BrontosaurusEngine;
using Rhino.Geometry;

namespace BrontosaurusEngineTests
{
    public class TestTestLists
    {
        // ---------- Assert lists tests ----------

        [Theory]
        [ClassData(typeof(TestAssertList_InputProperties_Helper))]
        public void TestAssertList_InputProperties_Helper(List<string> exp, List<string> act, string name)
        {
            TestLists testObject = new TestLists(exp, act, name);

            Assert.Equal(exp, testObject.ExpectedList);
            Assert.Equal(act, testObject.ActualList);
            Assert.Equal(name, testObject.Name);
        }
        [Theory]
        [ClassData(typeof(TestAssertList_Result_Helper))]
        public void TestAssertList_Result_Helper(List<string> exp, List<string> act, string name, string result)
        {
            TestLists testObject = new TestLists(exp, act, name);
            Assert.Equal(result, testObject.Result);
        }
        [Theory]
        [ClassData(typeof(TestAssertList_FailedInfo_Helper))]
        public void TestAssertList_FailedInfo_Helper(List<string> exp, List<string> act, string name, List<string> failedInfo)
        {
            TestLists testObject = new TestLists(exp, act, name);
            Assert.Equal(failedInfo, testObject.FailedInfo);
        }
        [Theory]
        [ClassData(typeof(TestAssertList_Failed_Helper))]
        public void TestAssertList_Failed_Helper(List<string> exp, List<string> act, string name, bool failed)
        {
            TestLists testObject = new TestLists(exp, act, name);
            Assert.Equal(failed, testObject.Failed);
        }

        // ---------- Assert vector lists tests ----------

        [Theory]
        [ClassData(typeof(TestAssertVectorList_InputProperties_Helper))]
        public void TestAssertVectorList_InputProperties_Helper(List<Vector3d> exp, List<Vector3d> act, string name)
        {
            TestLists testObject = new TestLists(exp, act, name);

            Assert.Equal(exp, testObject.ExpectedVectorList);
            Assert.Equal(act, testObject.ActualVectorList);
            Assert.Equal(name, testObject.Name);
        }
        [Theory]
        [ClassData(typeof(TestAssertVectorList_Result_Helper))]
        public void TestAssertVectorList_Result_Helper(List<Vector3d> exp, List<Vector3d> act, string name, string result)
        {
            TestLists testObject = new TestLists(exp, act, name);
            Assert.Equal(result, testObject.Result);
        }
        [Theory]
        [ClassData(typeof(TestAssertVectorList_FailedInfo_Helper))]
        public void TestAssertVectorList_FailedInfo_Helper(List<Vector3d> exp, List<Vector3d> act, string name, List<string> failedInfo)
        {
            TestLists testObject = new TestLists(exp, act, name);
            Assert.Equal(failedInfo, testObject.FailedInfo);
        }
        [Theory]
        [ClassData(typeof(TestAssertVectorList_Failed_Helper))]
        public void TestAssertVectorList_Failed_Helper(List<Vector3d> exp, List<Vector3d> act, string name, bool failed)
        {
            TestLists testObject = new TestLists(exp, act, name);
            Assert.Equal(failed, testObject.Failed);
        }

        // ---------- Assert point lists tests ----------

        [Theory]
        [ClassData(typeof(TestAssertPointList_InputProperties_Helper))]
        public void TestAssertPointList_InputProperties_Helper(List<Point3d> exp, List<Point3d> act, string name)
        {
            TestLists testObject = new TestLists(exp, act, name);

            Assert.Equal(exp, testObject.ExpectedPointList);
            Assert.Equal(act, testObject.ActualPointList);
            Assert.Equal(name, testObject.Name);
        }
        [Theory]
        [ClassData(typeof(TestAssertPointList_Result_Helper))]
        public void TestAssertPointList_Result_Helper(List<Point3d> exp, List<Point3d> act, string name, string result)
        {
            TestLists testObject = new TestLists(exp, act, name);
            Assert.Equal(result, testObject.Result);
        }
        [Theory]
        [ClassData(typeof(TestAssertPointList_FailedInfo_Helper))]
        public void TestAssertPointList_FailedInfo_Helper(List<Point3d> exp, List<Point3d> act, string name, List<string> failedInfo)
        {
            TestLists testObject = new TestLists(exp, act, name);
            Assert.Equal(failedInfo, testObject.FailedInfo);
        }
        [Theory]
        [ClassData(typeof(TestAssertPointList_Failed_Helper))]
        public void TestAssertPointList_Failed_Helper(List<Point3d> exp, List<Point3d> act, string name, bool failed)
        {
            TestLists testObject = new TestLists(exp, act, name);
            Assert.Equal(failed, testObject.Failed);
        }
    }
}
