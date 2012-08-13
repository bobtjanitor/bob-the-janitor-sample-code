using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Framework;
using Framework.Attributes;

namespace TestRunner
{
    public class TestBuilder
    {
        public string AssembyName { get; set; }
        private List<TestResults> _testResultses = new List<TestResults>();
        public List<TestResults> TestResultses
        {
            get { return _testResultses; }
            set { _testResultses = value; }
        }

        public delegate void Setup();
        public delegate void Test();
       
        public TestBuilder(string name)
        {
            AssembyName = name;
            SetTestFixture();
        }

        public void SetTestFixture()
        {
            var theList = Assembly.LoadFrom(AssembyName).GetTypes().ToArray();
            foreach (Type type in theList)
            {
                if (type.GetCustomAttributes(typeof(TestFixtureAttribute), false).Any())
                {
                    var instance = type.GetConstructor(new Type[] { }).Invoke(new object[] { });

                    var methods = type.GetMethods();
                    var result = new TestResults { Description = type.FullName };

                    MethodInfo setup = methods.First(x => x.GetCustomAttributes(typeof(SetUpAttribute), false).Any());

                    Delegate test = Delegate.CreateDelegate(typeof(Setup), instance, setup);

                    var setupMethod = (Setup)Delegate.CreateDelegate(typeof(Setup), instance, setup);

                    var tests = methods.Where(x => x.GetCustomAttributes(typeof(TestAttribute), false).Any())
                        .Select(x => (Test)Delegate.CreateDelegate(typeof(Test),instance, x)).ToList();
                    result.TestResultMesssage = RunTests(setupMethod, tests);
                    TestResultses.Add(result);

                }
            }
        }

        public List<TestResult> RunTests(Setup setup, IList<Test> tests)
        {
            var results = new List<TestResult>();

            foreach (var test in tests)
            {
                var result = new TestResult();
                try
                {
                    result.TestName = test.Method.Name;
                    setup.Invoke();
                    test.Invoke();
                    result.Success = true;

                }
                catch(Exception exception)
                {
                    result.Success = false;
                    result.Result = exception.Message;
                }
                finally
                {
                    results.Add(result);
                }
                
            }

            return results;
        }
    }
}