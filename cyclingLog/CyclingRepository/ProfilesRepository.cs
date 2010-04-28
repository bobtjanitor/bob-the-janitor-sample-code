using System;
using DomainModels;
using DomainModels.RepositoryInterfaces;

namespace CyclingRepository
{
    public class ProfilesRepository : IProfilesRepository
    {
        public Profiles GetProfileList()
        {
            throw new NotImplementedException();
        }

        public Profile GetProfileById(int id)
        {
            throw new NotImplementedException();
        }
    }
}