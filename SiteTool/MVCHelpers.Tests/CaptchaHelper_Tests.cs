using NUnit.Framework;
namespace MVCHelpers.Tests
{
    [TestFixture]
    public class CaptchaHelper_Tests
    {
        [Test]
        public void MakeRandomText_MoreOrEquilToMinLangth_Test()
        {
            int expected = 5;
            for (int i = 0; i < 500; i++)
            {
                CaptchaHelper.MinTextLength = expected;
                var actual = CaptchaHelper.MakeRandomText();
                Assert.IsTrue(actual.Length>=expected);  
            }   
        }

        [Test]
        public void MakeRandomText_LessOrEquilToMaxLangth_Test()
        {
            int expected = 6;
            for (int i = 0; i < 500; i++)
            {
                CaptchaHelper.MaxTextLength = expected;
                string actual = CaptchaHelper.MakeRandomText();
                Assert.IsTrue(actual.Length <= expected);
            }
        }
    }
}
