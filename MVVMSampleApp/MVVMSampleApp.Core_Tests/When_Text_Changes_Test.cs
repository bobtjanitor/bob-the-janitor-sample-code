using System.Collections.Generic;
using Cirrious.CrossCore.Core;
using Cirrious.MvvmCross.Test.Core;
using Cirrious.MvvmCross.Views;
using MVVMSampleApp.Core.ViewModels;
using NUnit.Framework;

namespace MVVMSampleApp.Core_Tests
{
    [TestFixture]
    public class When_Text_Changes_Test : MvxIoCSupportingTest
    {
        public FirstViewModel Target;
        public MockDispatcher MockDispatcher;
        public bool PropertyChanged = false;
        public List<string> FiredEventNames;

        [SetUp]
        public void SetUp()
        {
            base.ClearAll();
            Target = new FirstViewModel();
            FiredEventNames = new List<string>();
            MockDispatcher = new MockDispatcher();
            
            Ioc.RegisterSingleton<IMvxViewDispatcher>(MockDispatcher);
            Ioc.RegisterSingleton<IMvxMainThreadDispatcher>(MockDispatcher);
            Target.PropertyChanged += (sender, e) => FiredEventNames.Add(e.PropertyName);
            Target.Hello = "Test";
        }

        [Test]
        public void Was_Updated_And_Fired_Event_Test()
        {
            Assert.IsTrue(FiredEventNames.Contains("Hello"));
        }

        [Test]
        public void Fired_Expected_Number_Of_Events_Test()
        {
          
            Assert.AreEqual(1, FiredEventNames.Count);
        }

        [Test]
        public void Value_Was_Set_Test()
        {
            Assert.AreEqual("Test", Target.Hello);
        }
    }
}
