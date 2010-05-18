using System;
using System.Collections.Generic;

namespace DomainModels.RepositoryInterfaces
{
    public interface IRoutesRepository
    {
        List<Route> GetUsersRoutes(Guid userId);
        Route GetRouteById(Guid routeId);
    }
}