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
        [ClassData(typeof(TestAssertList_InputProperties))]
        public void TestAssertList_InputProperties(List<string> exp, List<string> act, string name)
        {
            TestLists testObject = new TestLists(exp, act, name);

            Assert.Equal(exp, testObject.ExpectedList);
            Assert.Equal(act, testObject.ActualList);
            Assert.Equal(name, testObject.Name);
        }
        [Theory]
        [ClassData(typeof(TestAssertList_Result))]
        public void TestAssertList_Result(List<string> exp, List<string> act, string name, string result)
        {
            TestLists testObject = new TestLists(exp, act, name);
            Assert.Equal(result, testObject.Result);
        }
        [Theory]
        [ClassData(typeof(TestAssertList_FailedInfo))]
        public void TestAssertList_FailedInfo(List<string> exp, List<string> act, string name, List<string> failedInfo)
        {
            TestLists testObject = new TestLists(exp, act, name);
            Assert.Equal(failedInfo, testObject.FailedInfo);
        }
        [Theory]
        [ClassData(typeof(TestAssertList_Failed))]
        public void TestAssertList_Failed(List<string> exp, List<string> act, string name, bool failed)
        {
            TestLists testObject = new TestLists(exp, act, name);
            Assert.Equal(failed, testObject.Failed);
        }

        // ---------- Assert vector lists tests ----------

        [Theory]
        [ClassData(typeof(TestAssertVectorList_InputProperties))]
        public void TestAssertVectorList_InputProperties(List<Vector3d> exp, List<Vector3d> act, string name, double tolerance)
        {
            TestLists testObject = new TestLists(exp, act, name, tolerance);

            Assert.Equal(exp, testObject.ExpectedVectorList);
            Assert.Equal(act, testObject.ActualVectorList);
            Assert.Equal(name, testObject.Name);
            Assert.Equal(tolerance, testObject.Tolerance);
        }
        [Theory]
        [ClassData(typeof(TestAssertVectorList_Result))]
        public void TestAssertVectorList_Result(List<Vector3d> exp, List<Vector3d> act, string name, double tolerance, string result)
        {
            TestLists testObject = new TestLists(exp, act, name, tolerance);
            Assert.Equal(result, testObject.Result);
        }
        [Theory]
        [ClassData(typeof(TestAssertVectorList_FailedInfo))]
        public void TestAssertVectorList_FailedInfo(List<Vector3d> exp, List<Vector3d> act, string name,
            double tolerance, List<string> failedInfo)
        {
            TestLists testObject = new TestLists(exp, act, name, tolerance);
            Assert.Equal(failedInfo, testObject.FailedInfo);
        }
        [Theory]
        [ClassData(typeof(TestAssertVectorList_Failed))]
        public void TestAssertVectorList_Failed(List<Vector3d> exp, List<Vector3d> act, string name,
            double tolerance, bool failed)
        {
            TestLists testObject = new TestLists(exp, act, name, tolerance);
            Assert.Equal(failed, testObject.Failed);
        }

        // ---------- Assert point lists tests ----------

        [Theory]
        [ClassData(typeof(TestAssertPointList_InputProperties))]
        public void TestAssertPointList_InputProperties(List<Point3d> exp, List<Point3d> act, string name, double tolerance)
        {
            TestLists testObject = new TestLists(exp, act, name, tolerance);

            Assert.Equal(exp, testObject.ExpectedPointList);
            Assert.Equal(act, testObject.ActualPointList);
            Assert.Equal(name, testObject.Name);
            Assert.Equal(tolerance, testObject.Tolerance);
        }
        [Theory]
        [ClassData(typeof(TestAssertPointList_Result))]
        public void TestAssertPointList_Result(List<Point3d> exp, List<Point3d> act, string name, double tolerance, string result)
        {
            TestLists testObject = new TestLists(exp, act, name, tolerance);
            Assert.Equal(result, testObject.Result);
        }
        [Theory]
        [ClassData(typeof(TestAssertPointList_FailedInfo))]
        public void TestAssertPointList_FailedInfo(List<Point3d> exp, List<Point3d> act, string name,
            double tolerance, List<string> failedInfo)
        {
            TestLists testObject = new TestLists(exp, act, name, tolerance);
            Assert.Equal(failedInfo, testObject.FailedInfo);
        }
        [Theory]
        [ClassData(typeof(TestAssertPointList_Failed))]
        public void TestAssertPointList_Failed(List<Point3d> exp, List<Point3d> act, string name,
            double tolerance, bool failed)
        {
            TestLists testObject = new TestLists(exp, act, name, tolerance);
            Assert.Equal(failed, testObject.Failed);
        }
    }
}
