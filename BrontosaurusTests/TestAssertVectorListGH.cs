using System;
using Grasshopper.Kernel;
using Brontosaurus;
using Xunit;

namespace BrontosaurusTests
{
    public class TestAssertVectorListGhHelper
    {
        public static AssertVectorListGH TestObject
        {
            get
            {
                AssertVectorListGH testObject = new AssertVectorListGH();
                return testObject;
            }
        }
    }
    public class TestAssertVectorListGh
    {
        [Theory]
        [InlineData("Assert Vector List", "Assert Vector List",
            "This component will treat testing your whole list as one test with one result." +
            " If your actual list == expected list: component will pass the test.",
            "Brontosaurus", "Assert Geo")]
        public void TestName(string name, string nickname, string description, string category, string subCategory)
        {
            Assert.Equal(name, TestAssertVectorListGhHelper.TestObject.Name);
            Assert.Equal(nickname, TestAssertVectorListGhHelper.TestObject.NickName);
            Assert.Equal(description, TestAssertVectorListGhHelper.TestObject.Description);
            Assert.Equal(category, TestAssertVectorListGhHelper.TestObject.Category);
            Assert.Equal(subCategory, TestAssertVectorListGhHelper.TestObject.SubCategory);
        }

        [Theory]
        [InlineData(0, "Test Name", "Test Name", "One test name for whole test", GH_ParamAccess.item)]
        [InlineData(1, "Expected Vector List", "Expected Vector List", "Expected list of vectors", GH_ParamAccess.list)]
        [InlineData(2, "Actual Vector List", "Actual Vector List", "Actual list of vectors", GH_ParamAccess.list)]

        public void TestRegisterInputParams(int id, string name, string nickname,
            string description, GH_ParamAccess access)
        {
            Assert.Equal(name, TestAssertVectorListGhHelper.TestObject.Params.Input[id].Name);
            Assert.Equal(nickname, TestAssertVectorListGhHelper.TestObject.Params.Input[id].NickName);
            Assert.Equal(description, TestAssertVectorListGhHelper.TestObject.Params.Input[id].Description);
            Assert.Equal(access, TestAssertVectorListGhHelper.TestObject.Params.Input[id].Access);
        }

        [Theory]
        [InlineData(0, "Result", "Result", "Result of test", GH_ParamAccess.item)]
        [InlineData(1, "Failed Info", "Failed Info", "Information about failed test", GH_ParamAccess.list)]
        public void TestRegisterOutputParams(int id, string name, string nickname,
            string description, GH_ParamAccess access)
        {
            Assert.Equal(name, TestAssertVectorListGhHelper.TestObject.Params.Output[id].Name);
            Assert.Equal(nickname, TestAssertVectorListGhHelper.TestObject.Params.Output[id].NickName);
            Assert.Equal(description, TestAssertVectorListGhHelper.TestObject.Params.Output[id].Description);
            Assert.Equal(access, TestAssertVectorListGhHelper.TestObject.Params.Output[id].Access);
        }

        [Fact]
        public void TestGuid()
        {
            Guid expected = new Guid("dd744886-bd7f-4f1a-9d78-443f878533f6");
            Guid actual = TestAssertVectorListGhHelper.TestObject.ComponentGuid;

            Assert.Equal(expected, actual);
        }
    }
}
