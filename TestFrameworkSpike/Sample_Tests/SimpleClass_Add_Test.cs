using Framework.Asserts;
using Framework.Attributes;

namespace Sample_Tests
{
    [TestFixture]
    public class SimpleClass_Add_Test
    {
        public SimpleClass Target;
        public int Actual;

        [SetUp]
        public void Setup()
        {
            Target = new SimpleClass();
            Actual = Target.Add(1, 2);
        }

        [Test]
        public void Add_Test()
        {
            Assert.AreEqual(3, Actual);
        }

        [Test]
        public void Add_Failed_Test()
        {
            Assert.AreEqual(3+1, Actual);
        }
    }
}