using System.Collections.Generic;

namespace DomainModels.RepositoryInterfaces
{
    public interface IRoutesRepository
    {
        List<Route> GetUsersRoutes(int userId);
        Route GetRouteById(int routeId);
    }
}