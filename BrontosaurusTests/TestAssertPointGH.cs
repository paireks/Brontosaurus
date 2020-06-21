using System;
using Grasshopper.Kernel;
using Brontosaurus;
using Xunit;

namespace BrontosaurusTests
{
    public class TestAssertPointGhHelper
    {
        public static AssertPointGH TestObject
        {
            get
            {
                AssertPointGH testObject = new AssertPointGH();
                return testObject;
            }
        }
    }
    public class TestAssertPointGh
    {
        [Theory]
        [InlineData("Assert Point", "Assert Point",
            "If your actual point coordinates == expected point coordinates: component will pass the test.",
            "Brontosaurus", "Assert Geo")]
        public void TestName(string name, string nickname, string description, string category, string subCategory)
        {
            Assert.Equal(name, TestAssertPointGhHelper.TestObject.Name);
            Assert.Equal(nickname, TestAssertPointGhHelper.TestObject.NickName);
            Assert.Equal(description, TestAssertPointGhHelper.TestObject.Description);
            Assert.Equal(category, TestAssertPointGhHelper.TestObject.Category);
            Assert.Equal(subCategory, TestAssertPointGhHelper.TestObject.SubCategory);
        }

        [Theory]
        [InlineData(0, "Test Names", "Test Names",
            "Test names as list, so it'll be easier to check which test passed/failed." +
            " Every name should match every assert (expected and actual value)",
            GH_ParamAccess.list)]
        [InlineData(1, "Expected", "Expected", "Expected points as list", GH_ParamAccess.list)]
        [InlineData(2, "Actual", "Actual", "Actual points that you want to check, as list", GH_ParamAccess.list)]
        [InlineData(3, "Tolerance",
            "Tolerance",
            "Tolerance - limit distance, to check if actual point is close enough to expected",
            GH_ParamAccess.item)]

        public void TestRegisterInputParams(int id, string name, string nickname,
            string description, GH_ParamAccess access)
        {
            Assert.Equal(name, TestAssertPointGhHelper.TestObject.Params.Input[id].Name);
            Assert.Equal(nickname, TestAssertPointGhHelper.TestObject.Params.Input[id].NickName);
            Assert.Equal(description, TestAssertPointGhHelper.TestObject.Params.Input[id].Description);
            Assert.Equal(access, TestAssertPointGhHelper.TestObject.Params.Input[id].Access);
        }

        [Theory]
        [InlineData(0, "Result", "Result", "Result of tests", GH_ParamAccess.list)]
        [InlineData(1, "Failed Info", "Failed Info", "Information about failed tests", GH_ParamAccess.list)]
        public void TestRegisterOutputParams(int id, string name, string nickname,
            string description, GH_ParamAccess access)
        {
            Assert.Equal(name, TestAssertPointGhHelper.TestObject.Params.Output[id].Name);
            Assert.Equal(nickname, TestAssertPointGhHelper.TestObject.Params.Output[id].NickName);
            Assert.Equal(description, TestAssertPointGhHelper.TestObject.Params.Output[id].Description);
            Assert.Equal(access, TestAssertPointGhHelper.TestObject.Params.Output[id].Access);
        }

        [Fact]
        public void TestGuid()
        {
            Guid expected = new Guid("dd744886-bd7f-4f1a-9d78-443f878533f6");
            Guid actual = TestAssertPointGhHelper.TestObject.ComponentGuid;

            Assert.Equal(expected, actual);
        }
    }
}
