using cyclingLog.Biz;
using DomainModels.BizInterfaces;

namespace cyclingLog.Factories
{
    public static class RouteFactory
    {
        public static IRouteRequests GetRouteRequests()
        {
            return new RouteRequests();
        }
    }
}