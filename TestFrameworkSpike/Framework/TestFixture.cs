using System.Collections.Generic;

namespace Framework
{
    public class TestResults
    {
        public string Description { get; set; }
        public List<TestResult> TestResultMesssage { get; set; }
    }

   public class TestResult
   {
       public string TestName { get; set; }
       public bool Success { get; set; }
       public string Result { get; set; }
   }
}