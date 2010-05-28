using System;

namespace ObserverDemo
{
    class Program
    {
        public static EventManager<Location> LocationHandler = new EventManager<Location>();

        static void Main(string[] args)
        {
            LocationHandler.Subscribers.Add("Repository",new SaveLocation());
            LocationHandler.Subscribers.Add("Twitter",new TweetLocation());

            Location currentLocation = new Location(){Lat = 111,Lon = -121};

            LocationHandler.Notify(currentLocation);

            Console.ReadKey();

            currentLocation.Lon = 1211;
            LocationHandler.Subscribers.Remove("Twitter");
            LocationHandler.Notify(currentLocation);

            Console.ReadKey();
            
            
        }
    }

    public class TweetLocation : ISubscriber<Location>
    {
        public ITwitter TwitterInterfacer = new FakeTwitterClient();
        public Location State { get; set; }

        public void Update()
        {
            TwitterInterfacer.TweetMessage(string.Format("currently at ({0},{1})",State.Lat,State.Lon));
        }
    }

    public class SaveLocation : ISubscriber<Location>
    {
        public ILocationReposigtory LocationRepository = new FakeLocationRepository();
        public Location State{get;set;}

        public void Update()
        {
            bool success = LocationRepository.SaveLocation(State);
        }
    }
}
