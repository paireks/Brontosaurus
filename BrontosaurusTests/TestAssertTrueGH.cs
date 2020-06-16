using System;
using Grasshopper.Kernel;
using Brontosaurus;
using Xunit;

namespace BrontosaurusTests
{
    public class TestAssertTrueGhHelper
    {
        public static AssertTrueGH TestObject
        {
            get
            {
                AssertTrueGH testObject = new AssertTrueGH();
                return testObject;
            }
        }
    }
    public class TestAssertTrueGh
    {
        [Theory]
        [InlineData("Assert True", "Assert True",
            "If your actual value == True: component will pass the test.",
            "Brontosaurus", "Assert")]
        public void TestName(string name, string nickname, string description, string category, string subCategory)
        {
            Assert.Equal(name, TestAssertTrueGhHelper.TestObject.Name);
            Assert.Equal(nickname, TestAssertTrueGhHelper.TestObject.NickName);
            Assert.Equal(description, TestAssertTrueGhHelper.TestObject.Description);
            Assert.Equal(category, TestAssertTrueGhHelper.TestObject.Category);
            Assert.Equal(subCategory, TestAssertTrueGhHelper.TestObject.SubCategory);
        }

        [Theory]
        [InlineData(0, "Test Names", "Test Names",
            "Test names as list, so it'll be easier to check which test passed/failed",
            GH_ParamAccess.list)]
        [InlineData(1, "Actual", "Actual", "Actual values as list", GH_ParamAccess.list)]

        public void TestRegisterInputParams(int id, string name, string nickname,
            string description, GH_ParamAccess access)
        {
            Assert.Equal(name, TestAssertTrueGhHelper.TestObject.Params.Input[id].Name);
            Assert.Equal(nickname, TestAssertTrueGhHelper.TestObject.Params.Input[id].NickName);
            Assert.Equal(description, TestAssertTrueGhHelper.TestObject.Params.Input[id].Description);
            Assert.Equal(access, TestAssertTrueGhHelper.TestObject.Params.Input[id].Access);
        }

        [Theory]
        [InlineData(0, "Result", "Result", "Result of tests", GH_ParamAccess.list)]
        [InlineData(1, "Failed Info", "Failed Info", "Information about failed tests", GH_ParamAccess.list)]
        public void TestRegisterOutputParams(int id, string name, string nickname,
            string description, GH_ParamAccess access)
        {
            Assert.Equal(name, TestAssertTrueGhHelper.TestObject.Params.Output[id].Name);
            Assert.Equal(nickname, TestAssertTrueGhHelper.TestObject.Params.Output[id].NickName);
            Assert.Equal(description, TestAssertTrueGhHelper.TestObject.Params.Output[id].Description);
            Assert.Equal(access, TestAssertTrueGhHelper.TestObject.Params.Output[id].Access);
        }

        [Fact]
        public void TestGuid()
        {
            Guid expected = new Guid("2e57844a-7d1d-4558-aaac-cc00e10cd89a");
            Guid actual = TestAssertTrueGhHelper.TestObject.ComponentGuid;

            Assert.Equal(expected, actual);
        }
    }
}
