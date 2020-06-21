using System;
using Grasshopper.Kernel;
using Brontosaurus;
using Xunit;

namespace BrontosaurusTests
{
    public class TestAssertGhHelper
    {
        public static AssertGH TestObject
        {
            get
            {
                AssertGH testObject = new AssertGH();
                return testObject;
            }
        }
    }
    public class TestAssertGh
    {
        [Theory]
        [InlineData("Assert", "Assert",
            "If your actual value == expected value: component will pass the test.",
            "Brontosaurus", "Assert")]
        public void TestName(string name, string nickname, string description, string category, string subCategory)
        {
            Assert.Equal(name, TestAssertGhHelper.TestObject.Name);
            Assert.Equal(nickname, TestAssertGhHelper.TestObject.NickName);
            Assert.Equal(description, TestAssertGhHelper.TestObject.Description);
            Assert.Equal(category, TestAssertGhHelper.TestObject.Category);
            Assert.Equal(subCategory, TestAssertGhHelper.TestObject.SubCategory);
        }

        [Theory]
        [InlineData(0, "Test Names", "Test Names",
            "Test names as list, so it'll be easier to check which test passed/failed." +
            " Every name should match every assert (expected and actual value)",
            GH_ParamAccess.list)]
        [InlineData(1, "Expected", "Expected", "Expected values as list", GH_ParamAccess.list)]
        [InlineData(2, "Actual", "Actual", "Actual values that you want to check, as list", GH_ParamAccess.list)]

        public void TestRegisterInputParams(int id, string name, string nickname,
            string description, GH_ParamAccess access)
        {
            Assert.Equal(name, TestAssertGhHelper.TestObject.Params.Input[id].Name);
            Assert.Equal(nickname, TestAssertGhHelper.TestObject.Params.Input[id].NickName);
            Assert.Equal(description, TestAssertGhHelper.TestObject.Params.Input[id].Description);
            Assert.Equal(access, TestAssertGhHelper.TestObject.Params.Input[id].Access);
        }

        [Theory]
        [InlineData(0, "Result", "Result", "Result of tests", GH_ParamAccess.list)]
        [InlineData(1, "Failed Info", "Failed Info", "Information about failed tests", GH_ParamAccess.list)]
        public void TestRegisterOutputParams(int id, string name, string nickname,
            string description, GH_ParamAccess access)
        {
            Assert.Equal(name, TestAssertGhHelper.TestObject.Params.Output[id].Name);
            Assert.Equal(nickname, TestAssertGhHelper.TestObject.Params.Output[id].NickName);
            Assert.Equal(description, TestAssertGhHelper.TestObject.Params.Output[id].Description);
            Assert.Equal(access, TestAssertGhHelper.TestObject.Params.Output[id].Access);
        }

        [Fact]
        public void TestGuid()
        {
            Guid expected = new Guid("2e57844a-7d1d-4558-aaac-cc00e10cd89b");
            Guid actual = TestAssertGhHelper.TestObject.ComponentGuid;

            Assert.Equal(expected, actual);
        }
    }
}
