using System;
using System.Collections.Generic;
using Xunit;
using BrontosaurusEngine;
using Rhino.Geometry;

namespace BrontosaurusEngineTests
{
    public class TestTest
    {

        // ---------- Assert tests ----------

        [Theory]
        [ClassData(typeof(TestAssert_InputProperties_Helper))]
        public void TestAssert_InputProperties_Helper(List<string> exp, List<string> act, List<string> names)
        {
            Test testObject = new Test(exp, act, names);

            Assert.Equal(exp, testObject.Expected);
            Assert.Equal(act, testObject.Actual);
            Assert.Equal(names, testObject.Names);
        }

        [Theory]
        [ClassData(typeof(TestAssert_InputProperties_Exception_Helper))]
        public void TestAssert_InputProperties_Exception_Helper(List<string> exp, List<string> act, List<string> names, string message)
        {
            var exception = Assert.Throws<ArgumentException>(() => new Test(exp, act, names));
            Assert.Equal(message, exception.Message);
        }

        [Theory]
        [ClassData(typeof(TestAssert_Result_Helper))]
        public void TestAssert_Result_Helper(List<string> exp, List<string> act, List<string> names, List<string> result)
        {
            Test testObject = new Test(exp, act, names);
            Assert.Equal(result, testObject.Result);
        }

        [Theory]
        [ClassData(typeof(TestAssert_FailedInfo_Helper))]
        public void TestAssert_FailedInfo_Helper(List<string> exp, List<string> act, List<string> names, List<string> failedInfo)
        {
            Test testObject = new Test(exp, act, names);
            Assert.Equal(failedInfo, testObject.FailedInfo);
        }

        [Theory]
        [ClassData(typeof(TestAssert_Failed_Helper))]
        public void TestAssert_Failed_Helper(List<string> exp, List<string> act, List<string> names, bool failed)
        {
            Test testObject = new Test(exp, act, names);
            Assert.Equal(failed, testObject.Failed);
        }

        // ---------- AssertTrue tests ----------

        [Theory]
        [ClassData(typeof(TestAssertTrue_InputProperties_Helper))]
        public void TestAssertTrue_InputProperties_Helper(List<bool> act, List<string> names)
        {
            Test testObject = new Test(act, names);

            Assert.Equal(act, testObject.ActualBoolean);
            Assert.Equal(names, testObject.Names);
        }

        [Theory]
        [ClassData(typeof(TestAssertTrue_InputProperties_Exception_Helper))]
        public void TestAssertTrue_InputProperties_Exception_Helper(List<bool> act, List<string> names, string message)
        {
            var exception = Assert.Throws<ArgumentException>(() => new Test(act, names));
            Assert.Equal(message, exception.Message);
        }

        [Theory]
        [ClassData(typeof(TestAssertTrue_Result_Helper))]
        public void TestAssertTrue_Result_Helper(List<bool> act, List<string> names, List<string> result)
        {
            Test testObject = new Test(act, names);
            Assert.Equal(result, testObject.Result);
        }

        [Theory]
        [ClassData(typeof(TestAssertTrue_Failed_Helper))]
        public void TestAssertTrue_Failed_Helper(List<bool> act, List<string> names, bool failed)
        {
            Test testObject = new Test(act, names);
            Assert.Equal(failed, testObject.Failed);
        }

        [Theory]
        [ClassData(typeof(TestAssertTrue_FailedInfo_Helper))]
        public void TestAssertTrue_FailedInfo_Helper(List<bool> act, List<string> names, List<string> failedInfo)
        {
            Test testObject = new Test(act, names);
            Assert.Equal(failedInfo, testObject.FailedInfo);
        }

        // ---------- AssertPoint tests ----------

        [Theory]
        [ClassData(typeof(TestAssertPoint_InputProperties_Helper))]
        public void TestAssertPoint_InputProperties_Helper(List<Point3d> exp, List<Point3d> act, List<string> names, double tolerance)
        {
            Test testObject = new Test(exp, act, names, tolerance);

            Assert.Equal(exp, testObject.ExpectedPoints);
            Assert.Equal(act, testObject.ActualPoints);
            Assert.Equal(names, testObject.Names);
            Assert.Equal(tolerance, testObject.Tolerance);
        }

        [Theory]
        [ClassData(typeof(TestAssertPoint_InputProperties_Exception_Helper))]
        public void TestAssertPoint_InputProperties_Exception_Helper(List<Point3d> exp,
            List<Point3d> act, List<string> names, double tolerance, string message)
        {
            var exception = Assert.Throws<ArgumentException>(() => new Test(exp, act, names, tolerance));
            Assert.Equal(message, exception.Message);
        }

        [Theory]
        [ClassData(typeof(TestAssertPoint_Result_Helper))]
        public void TestAssertPoint_Result_Helper(List<Point3d> exp,
            List<Point3d> act, List<string> names, double tolerance, List<string> result)
        {
            Test testObject = new Test(exp, act, names, tolerance);
            Assert.Equal(result, testObject.Result);
        }

        [Theory]
        [ClassData(typeof(TestAssertPoint_Failed_Helper))]
        public void TestAssertPoint_Failed_Helper(List<Point3d> exp, List<Point3d> act, List<string> names, double tolerance, bool failed)
        {
            Test testObject = new Test(exp, act, names, tolerance);
            Assert.Equal(failed, testObject.Failed);
        }

        [Theory]
        [ClassData(typeof(TestAssertPoint_FailedInfo_Helper))]
        public void TestAssertPoint_FailedInfo_Helper(List<Point3d> exp, List<Point3d> act,
            List<string> names, double tolerance, List<string> failedInfo)
        {
            Test testObject = new Test(exp, act, names, tolerance);
            Assert.Equal(failedInfo, testObject.FailedInfo);
        }

        // ---------- AssertVector tests ----------

        [Theory]
        [ClassData(typeof(TestAssertVector_InputProperties_Helper))]
        public void TestAssertVector_InputProperties_Helper(List<Vector3d> exp, List<Vector3d> act, List<string> names, double tolerance)
        {
            Test testObject = new Test(exp, act, names, tolerance);

            Assert.Equal(exp, testObject.ExpectedVectors);
            Assert.Equal(act, testObject.ActualVectors);
            Assert.Equal(names, testObject.Names);
        }

        [Theory]
        [ClassData(typeof(TestAssertVector_InputProperties_Exception_Helper))]
        public void TestAssertVector_InputProperties_Exception_Helper(List<Vector3d> exp,
            List<Vector3d> act, List<string> names, double tolerance, string message)
        {
            var exception = Assert.Throws<ArgumentException>(() => new Test(exp, act, names, tolerance));
            Assert.Equal(message, exception.Message);
        }

        [Theory]
        [ClassData(typeof(TestAssertVector_Result_Helper))]
        public void TestAssertVector_Result_Helper(List<Vector3d> exp, List<Vector3d> act, List<string> names, double tolerance, List<string> result)
        {
            Test testObject = new Test(exp, act, names, tolerance);
            Assert.Equal(result, testObject.Result);
        }

        [Theory]
        [ClassData(typeof(TestAssertVector_Failed_Helper))]
        public void TestAssertVector_Failed_Helper(List<Vector3d> exp,
            List<Vector3d> act, List<string> names, double tolerance, bool failed)
        {
            Test testObject = new Test(exp, act, names, tolerance);
            Assert.Equal(failed, testObject.Failed);
        }

        [Theory]
        [ClassData(typeof(TestAssertVector_FailedInfo_Helper))]
        public void TestAssertVector_FailedInfo_Helper(List<Vector3d> exp, List<Vector3d> act, List<string> names, double tolerance, List<string> failedInfo)
        {
            Test testObject = new Test(exp, act, names, tolerance);
            Assert.Equal(failedInfo, testObject.FailedInfo);
        }
    }
}
