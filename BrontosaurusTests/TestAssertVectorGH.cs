using System;
using Grasshopper.Kernel;
using Brontosaurus;
using Xunit;

namespace BrontosaurusTests
{
    public class TestAssertVectorGhHelper
    {
        public static AssertVectorGH TestObject
        {
            get
            {
                AssertVectorGH testObject = new AssertVectorGH();
                return testObject;
            }
        }
    }
    public class TestAssertVectorGh
    {
        [Theory]
        [InlineData("Assert Vector", "Assert Vector",
            "If your actual vector == expected vector: component will pass the test.",
            "Brontosaurus", "Assert Geo")]
        public void TestName(string name, string nickname, string description, string category, string subCategory)
        {
            Assert.Equal(name, TestAssertVectorGhHelper.TestObject.Name);
            Assert.Equal(nickname, TestAssertVectorGhHelper.TestObject.NickName);
            Assert.Equal(description, TestAssertVectorGhHelper.TestObject.Description);
            Assert.Equal(category, TestAssertVectorGhHelper.TestObject.Category);
            Assert.Equal(subCategory, TestAssertVectorGhHelper.TestObject.SubCategory);
        }

        [Theory]
        [InlineData(0, "Test Names", "Test Names",
            "Test names as list, so it'll be easier to check which test passed/failed." +
            " Every name should match every assert (expected and actual value)",
            GH_ParamAccess.list)]
        [InlineData(1, "Expected", "Expected", "Expected vectors as list", GH_ParamAccess.list)]
        [InlineData(2, "Actual", "Actual", "Actual vectors that you want to check, as list", GH_ParamAccess.list)]
        [InlineData(3, "Tolerance",
            "Tolerance",
            "Tolerance - limit distance, to check if actual vector is close enough to expected",
            GH_ParamAccess.item)]

        public void TestRegisterInputParams(int id, string name, string nickname,
            string description, GH_ParamAccess access)
        {
            Assert.Equal(name, TestAssertVectorGhHelper.TestObject.Params.Input[id].Name);
            Assert.Equal(nickname, TestAssertVectorGhHelper.TestObject.Params.Input[id].NickName);
            Assert.Equal(description, TestAssertVectorGhHelper.TestObject.Params.Input[id].Description);
            Assert.Equal(access, TestAssertVectorGhHelper.TestObject.Params.Input[id].Access);
        }

        [Theory]
        [InlineData(0, "Result", "Result", "Result of tests", GH_ParamAccess.list)]
        [InlineData(1, "Failed Info", "Failed Info", "Information about failed tests", GH_ParamAccess.list)]
        public void TestRegisterOutputParams(int id, string name, string nickname,
            string description, GH_ParamAccess access)
        {
            Assert.Equal(name, TestAssertVectorGhHelper.TestObject.Params.Output[id].Name);
            Assert.Equal(nickname, TestAssertVectorGhHelper.TestObject.Params.Output[id].NickName);
            Assert.Equal(description, TestAssertVectorGhHelper.TestObject.Params.Output[id].Description);
            Assert.Equal(access, TestAssertVectorGhHelper.TestObject.Params.Output[id].Access);
        }

        [Fact]
        public void TestGuid()
        {
            Guid expected = new Guid("ac7cf21c-1c54-47e1-8fe0-b69c9135deff");
            Guid actual = TestAssertVectorGhHelper.TestObject.ComponentGuid;

            Assert.Equal(expected, actual);
        }
    }
}
