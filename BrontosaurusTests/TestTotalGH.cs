using System;
using Grasshopper.Kernel;
using Brontosaurus;
using Xunit;

namespace BrontosaurusTests
{
    public class TestTotalGhHelper
    {
        public static TotalGH TestObject
        {
            get
            {
                TotalGH testObject = new TotalGH();
                return testObject;
            }
        }
    }
    public class TestTotalGh
    {
        [Theory]
        [InlineData("Total", "Total",
            "Group tests and create stats for all of them",
            "Brontosaurus", "Total")]
        public void TestName(string name, string nickname, string description, string category, string subCategory)
        {
            Assert.Equal(name, TestTotalGhHelper.TestObject.Name);
            Assert.Equal(nickname, TestTotalGhHelper.TestObject.NickName);
            Assert.Equal(description, TestTotalGhHelper.TestObject.Description);
            Assert.Equal(category, TestTotalGhHelper.TestObject.Category);
            Assert.Equal(subCategory, TestTotalGhHelper.TestObject.SubCategory);
        }

        [Theory]
        [InlineData(0, "Results", "Results", "Results of tests", GH_ParamAccess.list)]

        public void TestRegisterInputParams(int id, string name, string nickname,
            string description, GH_ParamAccess access)
        {
            Assert.Equal(name, TestTotalGhHelper.TestObject.Params.Input[id].Name);
            Assert.Equal(nickname, TestTotalGhHelper.TestObject.Params.Input[id].NickName);
            Assert.Equal(description, TestTotalGhHelper.TestObject.Params.Input[id].Description);
            Assert.Equal(access, TestTotalGhHelper.TestObject.Params.Input[id].Access);
        }

        [Theory]
        [InlineData(0, "Total Result", "Total Result", "Total result of tests", GH_ParamAccess.item)]
        [InlineData(1, "Report Part", "Report Part", "Created part of the report", GH_ParamAccess.item)]
        public void TestRegisterOutputParams(int id, string name, string nickname,
            string description, GH_ParamAccess access)
        {
            Assert.Equal(name, TestTotalGhHelper.TestObject.Params.Output[id].Name);
            Assert.Equal(nickname, TestTotalGhHelper.TestObject.Params.Output[id].NickName);
            Assert.Equal(description, TestTotalGhHelper.TestObject.Params.Output[id].Description);
            Assert.Equal(access, TestTotalGhHelper.TestObject.Params.Output[id].Access);
        }

        [Fact]
        public void TestGuid()
        {
            Guid expected = new Guid("f3a6e8be-3b40-4e97-88c1-ca0678261349");
            Guid actual = TestTotalGhHelper.TestObject.ComponentGuid;

            Assert.Equal(expected, actual);
        }
    }
}
