using AndroidUnit.Framework;

namespace ClientTestRunner
{
    public static class Factory
    {
        public static TestEngine  GetTestEngine()
        {
            return new TestEngine("MonoAndroidUnit.Sample_Tests.dll");
        }
    }
}