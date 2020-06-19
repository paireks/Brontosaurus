using System;
using Grasshopper.Kernel;
using Brontosaurus;
using Xunit;

namespace BrontosaurusTests
{
    public class TestAssertListGhHelper
    {
        public static AssertListGH TestObject
        {
            get
            {
                AssertListGH testObject = new AssertListGH();
                return testObject;
            }
        }
    }
    public class TestAssertListGh
    {
        [Theory]
        [InlineData("Assert List", "Assert List",
            "This component will treat testing your whole list as one test with one result." +
            " If your actual list == expected list: component will pass the test.",
            "Brontosaurus", "Assert")]
        public void TestName(string name, string nickname, string description, string category, string subCategory)
        {
            Assert.Equal(name, TestAssertListGhHelper.TestObject.Name);
            Assert.Equal(nickname, TestAssertListGhHelper.TestObject.NickName);
            Assert.Equal(description, TestAssertListGhHelper.TestObject.Description);
            Assert.Equal(category, TestAssertListGhHelper.TestObject.Category);
            Assert.Equal(subCategory, TestAssertListGhHelper.TestObject.SubCategory);
        }

        [Theory]
        [InlineData(0, "Test Name", "Test Name", "One test name for whole test", GH_ParamAccess.item)]
        [InlineData(1, "Expected List", "Expected List", "Expected list", GH_ParamAccess.list)]
        [InlineData(2, "Actual List", "Actual List", "Actual list", GH_ParamAccess.list)]

        public void TestRegisterInputParams(int id, string name, string nickname,
            string description, GH_ParamAccess access)
        {
            Assert.Equal(name, TestAssertListGhHelper.TestObject.Params.Input[id].Name);
            Assert.Equal(nickname, TestAssertListGhHelper.TestObject.Params.Input[id].NickName);
            Assert.Equal(description, TestAssertListGhHelper.TestObject.Params.Input[id].Description);
            Assert.Equal(access, TestAssertListGhHelper.TestObject.Params.Input[id].Access);
        }

        [Theory]
        [InlineData(0, "Result", "Result", "Result of test", GH_ParamAccess.item)]
        [InlineData(1, "Failed Info", "Failed Info", "Information about failed test", GH_ParamAccess.list)]
        public void TestRegisterOutputParams(int id, string name, string nickname,
            string description, GH_ParamAccess access)
        {
            Assert.Equal(name, TestAssertListGhHelper.TestObject.Params.Output[id].Name);
            Assert.Equal(nickname, TestAssertListGhHelper.TestObject.Params.Output[id].NickName);
            Assert.Equal(description, TestAssertListGhHelper.TestObject.Params.Output[id].Description);
            Assert.Equal(access, TestAssertListGhHelper.TestObject.Params.Output[id].Access);
        }

        [Fact]
        public void TestGuid()
        {
            Guid expected = new Guid("062f6484-69e4-4c71-9e67-227b59c5ee16");
            Guid actual = TestAssertListGhHelper.TestObject.ComponentGuid;

            Assert.Equal(expected, actual);
        }
    }
}
