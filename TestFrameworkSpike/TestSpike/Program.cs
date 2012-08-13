using System;
using System.Linq;
using MonoAndroidUnit.Framework;

namespace TestRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length==0)
            {
                args = new[] { "MonoAndroidUnit.Sample_Tests.dll" };
            }
            
            foreach (var s in args)
            {
                var builder = new TestEngine(s);
                foreach (var result in builder.TestResultses)
                {
                    Console.WriteLine(result.Description);
                    for (int x=0; x<result.TestResultMesssage.Count;x++)
                    {
                        var testResult = result.TestResultMesssage[x];
                        var current = x + 1;
                        var total = result.TestResultMesssage.Count;

                        if (testResult.Success)
                        {
                            Console.WriteLine(string.Format("{0}\t success {1}/{2}", testResult.TestName, current, total));
                        }
                        else
                        {
                            Console.WriteLine(string.Format("{0}\t Failed {1}/{2}", testResult.TestName, current, total));
                            Console.WriteLine(testResult.Result);
                        }
                    }
                }
                var totalTests = builder.TestResultses.SelectMany(x => x.TestResultMesssage).ToList();
                var totalTestCount = totalTests.Count;
                var totalPassingTestsCount = totalTests.Count(x => x.Success);
                var totalFailingTestCount = totalTests.Count(x => !x.Success);

                Console.WriteLine(string.Format("Total Test Count: {0}\t Total Passing: {1}\t Total Failing: {2}", totalTestCount, totalPassingTestsCount, totalFailingTestCount));
            }
            
            Console.WriteLine("press any key");
            Console.ReadKey();
        }
    }
}
