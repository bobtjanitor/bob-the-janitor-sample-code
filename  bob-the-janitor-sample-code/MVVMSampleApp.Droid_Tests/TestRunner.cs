using System.Reflection;
using Android.App;
using Android.OS;
using Xamarin.Android.NUnitLite;

namespace MVVMSampleApp.Droid_Tests
{
    [Activity(Label = "MVVMSampleApp.Droid_Tests", MainLauncher = true, Icon = "@drawable/icon")]
    public class TestRunner : TestSuiteActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            AddTest(Assembly.GetExecutingAssembly());
            base.OnCreate(bundle);         
        }
    }
}

