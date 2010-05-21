using CyclingRepository;
using DomainModels.RepositoryInterfaces;

namespace cyclingLog.Factories
{
    public class RepositoryFactory
    {
        public static IProfilesRepository GetProfilesRepository()
        {
            return new ProfilesRepository();
        }

        public static IRoutesRepository GetRoutesRepository()
        {
            return new StubRoutesRepository();
        }
    }
}