using NUnit.Framework;
using SampleApplication.Objects.Tools;

namespace SampleApplication.Objects_Tests.Tools_Tests
{
    [TestFixture]
    public class EnumExtentions_Tests
    {
        [Test]
        public void Get_Description_For_Enum_With_Description_Test()
        {
            Assert.AreEqual("Value 1",TestEnum.Value1.ToDiscription());
        }

        [Test]
        public void Get_Description_For_Enum_With_Out_Description_Test()
        {
            Assert.AreEqual("Value2", TestEnum.Value2.ToDiscription());
        }
    }
}