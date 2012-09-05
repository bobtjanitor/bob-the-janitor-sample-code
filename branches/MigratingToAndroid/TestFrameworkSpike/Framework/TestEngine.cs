using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Framework.models;
using MonoAndroidUnit.Framework.Attributes;
using MonoAndroidUnit.Framework.models;

namespace MonoAndroidUnit.Framework
{
    public class TestEngine
    {
        public string AssemblyName { get; set; }
        private List<TestResults> _testResultses = new List<TestResults>();
        public List<TestResults> TestResultses
        {
            get { return _testResultses; }
            set { _testResultses = value; }
        }

        public delegate void Setup();
        public delegate void Test();
        public delegate void Teardown();
       
        public TestEngine(string name)
        {
            AssemblyName = name;
            RunAssemblyFixture();
        }

        public void RunAssemblyFixture()
        {
            var theList = Assembly.Load(AssemblyName).GetTypes().ToArray();
            foreach (Type type in theList)
            {
                if (type.GetCustomAttributes(typeof(TestFixtureAttribute), false).Any())
                {
                    var instance = type.GetConstructor(new Type[] { }).Invoke(new object[] { });

                    var methods = type.GetMethods();
                    var result = new TestResults { Description = type.FullName };

                    var setupMethod = SetupMethod(instance, methods);                    
                    var teardownMethod = TeardownMethod(instance, methods);

                    var tests = methods.Where(x => x.GetCustomAttributes(typeof(TestAttribute), false).Any())
                        .Select(x => (Test)Delegate.CreateDelegate(typeof(Test),instance, x)).ToList();
                    result.TestResultMesssage = RunTests(setupMethod, tests, teardownMethod);
                    TestResultses.Add(result);

                }
            }
        }

        private static Setup SetupMethod(object instance, IEnumerable<MethodInfo> methods)
        {
            Setup setupMethod;
            MethodInfo setup = methods.FirstOrDefault(x => x.GetCustomAttributes(typeof (SetUpAttribute), false).Any());
            if (setup!=null)
            {
                setupMethod = (Setup)Delegate.CreateDelegate(typeof(Setup), instance, setup);
            }
            else
            {
                setupMethod = delegate{ };
            }            
            return setupMethod;
        }

        private static Teardown TeardownMethod(object instance, IEnumerable<MethodInfo> methods)
        {
            Teardown teardownMethod;
            MethodInfo setup = methods.FirstOrDefault(x => x.GetCustomAttributes(typeof(TearDownAttribute), false).Any());
            if (setup != null)
            {
                teardownMethod = (Teardown)Delegate.CreateDelegate(typeof(Teardown), instance, setup);
            }
            else
            {
                teardownMethod = delegate{ };
            }
            return teardownMethod;
        }

        public List<TestResult> RunTests(Setup setup, IList<Test> tests, Teardown teardown)
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