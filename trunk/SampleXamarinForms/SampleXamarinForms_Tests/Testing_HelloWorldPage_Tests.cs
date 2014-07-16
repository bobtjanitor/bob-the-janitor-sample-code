using NUnit.Framework;
using SampleXamarinForms;
using Xamarin.Forms;

namespace SampleXamarinForms_Tests
{
    [TestFixture]
    public class Testing_HelloWorldPage_Tests
    {
        public HelloWorldPage Target;

        public void SetUp()
        {
            Target = new HelloWorldPage();
        }

        [Test]
        public void Has_Expected_valueLabel_Test()
        {
            //Assert.AreEqual("A simple Label", Target.valueLabel);
        }
    }

    [TestFixture]
    public class Testing_HelloWordCodePage_Tests
    {
        public HelloWordCodePage Target;

        [SetUp]
        public void SetUp()
        {
            Target = new HelloWordCodePage();
        }

        [Test]
        public void Has_Expected_valueLabel_Test()
        {
            Assert.AreEqual("Hello World", Target.HelloWorldLabel.Text);
        }

        [Test]
        public void Has_Expected_Content_Layout_Type_Test()
        {
            Assert.IsInstanceOf<StackLayout>(Target.Content);
        }
    }
}
