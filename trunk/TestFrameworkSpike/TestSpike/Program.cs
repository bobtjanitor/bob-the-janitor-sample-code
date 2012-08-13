using System;

namespace TestRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length==0)
            {
                args = new []{"Sample_Tests.dll"};
            }
            
            foreach (var s in args)
            {
                var builder = new TestBuilder(s);
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
            }
            Console.WriteLine("press any key");
            Console.ReadKey();
        }
    }
}
