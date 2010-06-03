using System.Collections.Generic;
using DomainModels.RepositoryInterfaces;

namespace DomainModels.BizInterfaces
{
    public interface IRouteRequests
    {
        IRouteRepository RouteRepositoryInterface { get; set; }
        List<string> Errors { get; set; }
        bool AddRoute(Route route);
    }
}