using System;

namespace DomainModels.RepositoryInterfaces
{
    public interface IProfilesRepository
    {
        Profiles GetProfileList();
        Profile GetProfileById(Guid id);
    }
}