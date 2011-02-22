using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MVCHelpers
{
    public static class CaptchaHelper
    {
        private const string KeyPrefix = "_MyCaptcha";
        private const string ImageOutputFormat = @"<img src='{0}' alt='Human Test'\> <input type='hidden' name='{1}' value='{2}' >";
        private const int RandomSeed = 2134343212;

        private static int _minTextLength=4;
        

        public static int MinTextLength
        {
            get { return _minTextLength; }
            set { _minTextLength = value; }
        }

        private static int _maxTextLength=8;
        public static int MaxTextLength
        {
            get {
                return _maxTextLength;
            }
            set {
                _maxTextLength = value;
            }
        }

        public static MvcHtmlString Captcha(this HtmlHelper html, string name)
        {
            HttpSessionStateBase session = html.ViewContext.HttpContext.Session;
            session[KeyPrefix + Guid.NewGuid()] = MakeRandomText();
            throw new NotImplementedException();
        }

        public static string MakeRandomText()
        {
            Random random = new Random(RandomSeed);
            int length = random.Next(MinTextLength, MaxTextLength);
            char[] chars = new char[length];
            for (int i = 0; i < length; i++)
            {
                chars[i] = (char) ('a' + random.Next(26));
            }
            return new string(chars);
        }
    }
}
