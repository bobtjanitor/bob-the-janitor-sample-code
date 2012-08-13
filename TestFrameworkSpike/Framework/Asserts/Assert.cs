using System;
using System.Collections.Generic;

namespace MonoAndroidUnit.Framework.Asserts
{
    public static class Assert
    {
        public static void AreEqual<T>(T expected, T actual)
        {
            if (!EqualityComparer<T>.Default.Equals(expected, actual))
            {
                throw new Exception(string.Format("Expected : {0}\nActual :{1}", expected, actual));
            }
        }

        public static void AreNotEqual<T>(T notExpected, T actual)
        {
            if (EqualityComparer<T>.Default.Equals(notExpected, actual))
            {
                throw new Exception(string.Format("Not Expected : {0}\nActual :{1}", notExpected, actual));
            }
        }

        public static void IsTrue(bool expected)
        {
            if(!expected)
            {
                throw new Exception(string.Format("Expected : {0}\nActual :{1}", true, false));
            }
        }

        public static void IsFalse(bool expected)
        {
            if (expected)
            {
                throw new Exception(string.Format("Expected : {0}\nActual :{1}", false, true));
            }
        }

    }
}