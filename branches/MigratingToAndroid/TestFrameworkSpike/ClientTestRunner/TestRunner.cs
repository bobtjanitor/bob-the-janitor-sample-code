using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace ClientTestRunner
{
    [Activity(Label = "ClientTestRunner", MainLauncher = true, Icon = "@drawable/icon")]
    public class TestRunner : Activity
    {
        public ExpandableListView TestResultsView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            Init();
            RunTests();
        }

        private void RunTests()
        {
            var engine = Factory.GetTestEngine();
            TestResultsView.Adapter = new ArrayAdapter(this, Resource.Id.TestResults, engine.TestResultses);
        }

        protected void Init()
        {
            SetContentView(Resource.Layout.Main);
            TestResultsView = FindViewById<ExpandableListView>(Resource.Id.TestResults);
        }
    }
}

