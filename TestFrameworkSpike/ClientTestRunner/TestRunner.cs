using System.Collections.Generic;
using System.Linq;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Views;
using Android.Widget;
using Android.OS;
using AndroidUnit.Framework.models;

namespace ClientTestRunner
{
    public static class Skin
    {
        public static Color TitleBackground {get{return new Color(200, 200, 200); }}
        public static Color TitleText{get{return new Color(0,0,0);}}
        public static Color RowBackground { get { return new Color(220,220,220);}}
        public static Color AltRowBackground { get { return new Color(240, 240, 240); }}
        public static Color TestPassed {get{return new Color(76,255,0);}}
        public static Color TestFailed { get { return new Color(255, 0, 0); } }
        public static Color FailedTestBackground { get {  return new Color(255, 127, 127); }}
    }

    [Activity(Label = "ClientTestRunner", MainLauncher = true, Icon = "@drawable/icon")]
    public class TestRunner : Activity
    {
        protected TableLayout MainLayout;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            Init();
            RunTests();
        }

        private void RunTests()
        {

            var engine = Factory.GetTestEngine();
            List<TestResults> results = engine.TestResultses;// TestResultses();
            foreach (var testResult in results)
            {
                var titleRow = BuildTitleRow(testResult);
                MainLayout.AddView(titleRow);
                for (int i = 0; i < testResult.TestResultMesssage.Count; i++)
                {
                    var row = new TableRow(this);
                    row.SetBackgroundColor(new Color(i % 2 == 0 ? Skin.RowBackground : Skin.AltRowBackground));
                    var testName = new TextView(this) { Text = testResult.TestResultMesssage[i].TestName, Gravity = GravityFlags.Left };
                    testName.SetTextColor(Skin.TitleText);
                    row.AddView(testName);
                    var success = new TextView(this) { Gravity = GravityFlags.Right, };

                    if (testResult.TestResultMesssage[i].Success)
                    {
                        success.Text = "Passed";
                        success.SetTextColor(Skin.TestPassed);
                    }
                    else
                    {
                        success.Text = "Failed";
                        success.SetTextColor(Skin.TestFailed);
                    }
                    row.AddView(success);
                    MainLayout.AddView(row);

                    if(!testResult.TestResultMesssage[i].Success)
                    {
                        var exceptionRow = new TableRow(this);
                        exceptionRow.SetBackgroundColor(Skin.FailedTestBackground);
                        var exceptionText = new TextView(this) { Text = testResult.TestResultMesssage[i].Result, Gravity = GravityFlags.Left, };
                        exceptionRow.AddView(exceptionText);
                        MainLayout.AddView(exceptionRow);
                    }
                }
            }
        }

        private TableRow BuildTitleRow(TestResults testResult)
        {
            var row = new TableRow(this);
            row.SetBackgroundColor(new Color(Skin.TitleBackground));
            var description = new TextView(this) {Text = testResult.Description, Gravity = GravityFlags.Left,};
            description.SetTextColor(Skin.TitleText);
            row.AddView(description);
            var testCount = new TextView(this)
                                {
                                    Text = string.Format("Test Count:{0}", testResult.TestResultMesssage.Count),
                                    Gravity = GravityFlags.Right
                                };
            testCount.SetTextColor(Skin.TitleText);
            row.AddView(testCount);
            return row;
        }

        private static List<TestResults> TestResultses()
        {
            var results = new List<TestResults>
                {
                    new TestResults
                        {
                            Description = "Test result 1",
                            TestResultMesssage = new List<TestResult>
                                {
                                    new TestResult
                                        {
                                            Result = "result",
                                            Success = false,
                                            TestName = "Test 1"
                                        },
                                    new TestResult
                                        {
                                            Result = "result",
                                            Success = true,
                                            TestName = "Test 1"
                                        }
                                }
                        },
                    new TestResults
                        {
                            Description = "Test result 2",
                            TestResultMesssage = new List<TestResult>
                                {
                                    new TestResult
                                        {
                                            Result = "result",
                                            Success = true,
                                            TestName = "Test 3"
                                        },
                                    new TestResult
                                        {
                                            Result = string.Empty,
                                            Success = false,
                                            TestName = "Test 4"
                                        }
                                }
                        },
                };
            return results;
        }

        protected void Init()
        {
            SetContentView(Resource.Layout.Main);
            MainLayout = FindViewById<TableLayout>(Resource.Id.TableLayout);
        }
    }
}

