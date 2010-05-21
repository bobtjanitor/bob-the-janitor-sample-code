using System;

namespace DomainModels.RepositoryInterfaces
{
    public interface IAuthentiactionRepository
    {
        Guid AuthenticatedUser { get; set; }
        bool CheckAuthentication(string userName, string password);
    }
}