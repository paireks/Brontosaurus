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
        [ClassData(typeof(TestAssert_InputProperties))]
        public void TestAssert_InputProperties(List<string> exp, List<string> act, List<string> names)
        {
            Test testObject = new Test(exp, act, names);

            Assert.Equal(exp, testObject.Expected);
            Assert.Equal(act, testObject.Actual);
            Assert.Equal(names, testObject.Names);
        }

        [Theory]
        [ClassData(typeof(TestAssert_InputProperties_Exception))]
        public void TestAssert_InputProperties_Exception(List<string> exp, List<string> act, List<string> names, string message)
        {
            var exception = Assert.Throws<ArgumentException>(() => new Test(exp, act, names));
            Assert.Equal(message, exception.Message);
        }

        [Theory]
        [ClassData(typeof(TestAssert_Result))]
        public void TestAssert_Result(List<string> exp, List<string> act, List<string> names, List<string> result)
        {
            Test testObject = new Test(exp, act, names);
            Assert.Equal(result, testObject.Result);
        }

        [Theory]
        [ClassData(typeof(TestAssert_FailedInfo))]
        public void TestAssert_FailedInfo(List<string> exp, List<string> act, List<string> names, List<string> failedInfo)
        {
            Test testObject = new Test(exp, act, names);
            Assert.Equal(failedInfo, testObject.FailedInfo);
        }

        [Theory]
        [ClassData(typeof(TestAssert_Failed))]
        public void TestAssert_Failed(List<string> exp, List<string> act, List<string> names, bool failed)
        {
            Test testObject = new Test(exp, act, names);
            Assert.Equal(failed, testObject.Failed);
        }

        // ---------- AssertTrue tests ----------

        [Theory]
        [ClassData(typeof(TestAssertTrue_InputProperties))]
        public void TestAssertTrue_InputProperties(List<bool> act, List<string> names)
        {
            Test testObject = new Test(act, names);

            Assert.Equal(act, testObject.ActualBoolean);
            Assert.Equal(names, testObject.Names);
        }

        [Theory]
        [ClassData(typeof(TestAssertTrue_InputProperties_Exception))]
        public void TestAssertTrue_InputProperties_Exception(List<bool> act, List<string> names, string message)
        {
            var exception = Assert.Throws<ArgumentException>(() => new Test(act, names));
            Assert.Equal(message, exception.Message);
        }

        [Theory]
        [ClassData(typeof(TestAssertTrue_Result))]
        public void TestAssertTrue_Result(List<bool> act, List<string> names, List<string> result)
        {
            Test testObject = new Test(act, names);
            Assert.Equal(result, testObject.Result);
        }

        [Theory]
        [ClassData(typeof(TestAssertTrue_Failed))]
        public void TestAssertTrue_Failed(List<bool> act, List<string> names, bool failed)
        {
            Test testObject = new Test(act, names);
            Assert.Equal(failed, testObject.Failed);
        }

        [Theory]
        [ClassData(typeof(TestAssertTrue_FailedInfo))]
        public void TestAssertTrue_FailedInfo(List<bool> act, List<string> names, List<string> failedInfo)
        {
            Test testObject = new Test(act, names);
            Assert.Equal(failedInfo, testObject.FailedInfo);
        }

        // ---------- AssertPoint tests ----------

        [Theory]
        [ClassData(typeof(TestAssertPoint_InputProperties))]
        public void TestAssertPoint_InputProperties(List<Point3d> exp, List<Point3d> act, List<string> names, double tolerance)
        {
            Test testObject = new Test(exp, act, names, tolerance);

            Assert.Equal(exp, testObject.ExpectedPoints);
            Assert.Equal(act, testObject.ActualPoints);
            Assert.Equal(names, testObject.Names);
            Assert.Equal(tolerance, testObject.Tolerance);
        }

        [Theory]
        [ClassData(typeof(TestAssertPoint_InputProperties_Exception))]
        public void TestAssertPoint_InputProperties_Exception(List<Point3d> exp,
            List<Point3d> act, List<string> names, double tolerance, string message)
        {
            var exception = Assert.Throws<ArgumentException>(() => new Test(exp, act, names, tolerance));
            Assert.Equal(message, exception.Message);
        }

        [Theory]
        [ClassData(typeof(TestAssertPoint_Result))]
        public void TestAssertPoint_Result(List<Point3d> exp,
            List<Point3d> act, List<string> names, double tolerance, List<string> result)
        {
            Test testObject = new Test(exp, act, names, tolerance);
            Assert.Equal(result, testObject.Result);
        }

        [Theory]
        [ClassData(typeof(TestAssertPoint_Failed))]
        public void TestAssertPoint_Failed(List<Point3d> exp, List<Point3d> act, List<string> names, double tolerance, bool failed)
        {
            Test testObject = new Test(exp, act, names, tolerance);
            Assert.Equal(failed, testObject.Failed);
        }

        [Theory]
        [ClassData(typeof(TestAssertPoint_FailedInfo))]
        public void TestAssertPoint_FailedInfo(List<Point3d> exp, List<Point3d> act,
            List<string> names, double tolerance, List<string> failedInfo)
        {
            Test testObject = new Test(exp, act, names, tolerance);
            Assert.Equal(failedInfo, testObject.FailedInfo);
        }

        // ---------- AssertVector tests ----------

        [Theory]
        [ClassData(typeof(TestAssertVector_InputProperties))]
        public void TestAssertVector_InputProperties(List<Vector3d> exp, List<Vector3d> act, List<string> names, double tolerance)
        {
            Test testObject = new Test(exp, act, names, tolerance);

            Assert.Equal(exp, testObject.ExpectedVectors);
            Assert.Equal(act, testObject.ActualVectors);
            Assert.Equal(names, testObject.Names);
            Assert.Equal(tolerance, testObject.Tolerance);
        }

        [Theory]
        [ClassData(typeof(TestAssertVector_InputProperties_Exception))]
        public void TestAssertVector_InputProperties_Exception(List<Vector3d> exp,
            List<Vector3d> act, List<string> names, double tolerance, string message)
        {
            var exception = Assert.Throws<ArgumentException>(() => new Test(exp, act, names, tolerance));
            Assert.Equal(message, exception.Message);
        }

        [Theory]
        [ClassData(typeof(TestAssertVector_Result))]
        public void TestAssertVector_Result(List<Vector3d> exp, List<Vector3d> act, List<string> names, double tolerance, List<string> result)
        {
            Test testObject = new Test(exp, act, names, tolerance);
            Assert.Equal(result, testObject.Result);
        }

        [Theory]
        [ClassData(typeof(TestAssertVector_Failed))]
        public void TestAssertVector_Failed(List<Vector3d> exp,
            List<Vector3d> act, List<string> names, double tolerance, bool failed)
        {
            Test testObject = new Test(exp, act, names, tolerance);
            Assert.Equal(failed, testObject.Failed);
        }

        [Theory]
        [ClassData(typeof(TestAssertVector_FailedInfo))]
        public void TestAssertVector_FailedInfo(List<Vector3d> exp, List<Vector3d> act, List<string> names, double tolerance, List<string> failedInfo)
        {
            Test testObject = new Test(exp, act, names, tolerance);
            Assert.Equal(failedInfo, testObject.FailedInfo);
        }
    }
}
