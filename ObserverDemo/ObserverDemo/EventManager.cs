using System.Collections.Generic;

namespace ObserverDemo
{
    public class EventManager<T>
    { 
        private Dictionary<string, ISubscriber<T>> _subscribers = new Dictionary<string, ISubscriber<T>>();
        public Dictionary<string,ISubscriber<T>> Subscribers
        {
            get { return _subscribers; }
            set { _subscribers = value; }
        }

        public void Notify(T newState)
        {
            foreach (var obverver in Subscribers.Values)
            {
                obverver.State = newState;
                obverver.Update();
            }
        }
    }
}