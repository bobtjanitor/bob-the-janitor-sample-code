using System.Collections.Generic;
using Framework.models;

namespace MonoAndroidUnit.Framework.models
{
    public class TestResults
    {
        public string Description { get; set; }
        public List<TestResult> TestResultMesssage { get; set; }
    }
}