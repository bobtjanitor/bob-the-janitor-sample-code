using System;
using System.Collections.Generic;

namespace Framework.Asserts
{
    public static class Assert
    {
        public static void AreEqual<T>(T expected, T actual)
        {
            if (!EqualityComparer<T>.Default.Equals(expected, actual))
            {
                throw new Exception(string.Format("Expected : {0}\n Actual :{1}", expected, actual));
            }
        }
    }
}