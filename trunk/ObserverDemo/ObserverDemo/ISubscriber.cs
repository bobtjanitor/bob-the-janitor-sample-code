namespace ObserverDemo
{
    public interface ISubscriber<T>
    {
        T State { get; set; }
        void Update();
    }
}