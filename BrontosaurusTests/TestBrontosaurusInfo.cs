using System;
using System.Drawing;
using Brontosaurus;
using Xunit;

namespace BrontosaurusTests
{
    public class TestBrontosauruInfoHelper
    {
        public static BrontosaurusInfo TestObject
        {
            get
            {
                BrontosaurusInfo testObject = new BrontosaurusInfo();
                return testObject;
            }
        }
    }


    public class TestPterodactylInfo
    {
        [Fact]
        public void TestName()
        {
            string expected = "Brontosaurus";
            string actual = TestBrontosauruInfoHelper.TestObject.Name;

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestDescription()
        {
            string expected = "Brontosaurus will help you to create unit tests inside Grasshopper";
            string actual = TestBrontosauruInfoHelper.TestObject.Description;

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestId()
        {
            System.Guid expected = new Guid("8f471575-841b-486a-bf6c-9876a5f7e718");
            System.Guid actual = TestBrontosauruInfoHelper.TestObject.Id;

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestAuthorName()
        {
            string expected = "Wojciech Radaczynski";
            string actual = TestBrontosauruInfoHelper.TestObject.AuthorName;

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestAuthorContact()
        {
            string expected = "w.radaczynski@gmail.com";
            string actual = TestBrontosauruInfoHelper.TestObject.AuthorContact;

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestIcon()
        {
            Bitmap expected = null;
            Bitmap actual = TestBrontosauruInfoHelper.TestObject.Icon;

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestVersion()
        {
            string expected = "1.0.0.0";
            string actual = TestBrontosauruInfoHelper.TestObject.Version;

            Assert.Equal(expected, actual);
        }
    }
}

