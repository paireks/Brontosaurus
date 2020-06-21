using System;
using Grasshopper.Kernel;
using Brontosaurus;
using Xunit;

namespace BrontosaurusTests
{
    public class TestAssertPointListGhHelper
    {
        public static AssertPointListGH TestObject
        {
            get
            {
                AssertPointListGH testObject = new AssertPointListGH();
                return testObject;
            }
        }
    }
    public class TestAssertPointListGh
    {
        [Theory]
        [InlineData("Assert Point List", "Assert Point List",
            "This component will treat testing your whole list as one test with one result." +
            " If your actual list == expected list: component will pass the test.",
            "Brontosaurus", "Assert Geo")]
        public void TestName(string name, string nickname, string description, string category, string subCategory)
        {
            Assert.Equal(name, TestAssertPointListGhHelper.TestObject.Name);
            Assert.Equal(nickname, TestAssertPointListGhHelper.TestObject.NickName);
            Assert.Equal(description, TestAssertPointListGhHelper.TestObject.Description);
            Assert.Equal(category, TestAssertPointListGhHelper.TestObject.Category);
            Assert.Equal(subCategory, TestAssertPointListGhHelper.TestObject.SubCategory);
        }

        [Theory]
        [InlineData(0, "Test Name", "Test Name", "One test name for whole test", GH_ParamAccess.item)]
        [InlineData(1, "Expected Point List", "Expected Point List", "Expected list of points", GH_ParamAccess.list)]
        [InlineData(2, "Actual Point List", "Actual Point List", "Actual list of points", GH_ParamAccess.list)]
        [InlineData(3, "Tolerance", "Tolerance", "Tolerance - limit distance, to check if actual point is close enough to expected",
            GH_ParamAccess.item)]

        public void TestRegisterInputParams(int id, string name, string nickname,
            string description, GH_ParamAccess access)
        {
            Assert.Equal(name, TestAssertPointListGhHelper.TestObject.Params.Input[id].Name);
            Assert.Equal(nickname, TestAssertPointListGhHelper.TestObject.Params.Input[id].NickName);
            Assert.Equal(description, TestAssertPointListGhHelper.TestObject.Params.Input[id].Description);
            Assert.Equal(access, TestAssertPointListGhHelper.TestObject.Params.Input[id].Access);
        }

        [Theory]
        [InlineData(0, "Result", "Result", "Result of test", GH_ParamAccess.item)]
        [InlineData(1, "Failed Info", "Failed Info", "Information about failed test", GH_ParamAccess.list)]
        public void TestRegisterOutputParams(int id, string name, string nickname,
            string description, GH_ParamAccess access)
        {
            Assert.Equal(name, TestAssertPointListGhHelper.TestObject.Params.Output[id].Name);
            Assert.Equal(nickname, TestAssertPointListGhHelper.TestObject.Params.Output[id].NickName);
            Assert.Equal(description, TestAssertPointListGhHelper.TestObject.Params.Output[id].Description);
            Assert.Equal(access, TestAssertPointListGhHelper.TestObject.Params.Output[id].Access);
        }

        [Fact]
        public void TestGuid()
        {
            Guid expected = new Guid("dd744886-bd7f-4f1a-9d78-443f878533f7");
            Guid actual = TestAssertPointListGhHelper.TestObject.ComponentGuid;

            Assert.Equal(expected, actual);
        }
    }
}
