using NUnit.Framework;

namespace SampleApplication.Domain_Tests.Behavioral
{
    [TestFixture]
    public abstract class Test_Context<T> where T : new() 
    {
        public T Target;
        

        [SetUp]
        public void Setup()
        {
            Context();
            Because();
        }

        public virtual void Context()
        {
            Target = new T();
        }

        public abstract void Because();
    }
}