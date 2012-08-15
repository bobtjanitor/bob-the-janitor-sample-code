using System;

namespace ObserverDemo
{
    public class FakeTwitterClient :ITwitter
    {
        public void TweetMessage(string message)
        {
            Console.WriteLine(string.Format("Your tweet is: "+message));
        }
    }
}