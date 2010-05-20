using CyclingRepository;
using DomainModels.RepositoryInterfaces;

namespace cyclingLog.Biz
{
    public static class Factories
    {
        public static IAuthentiactionRepository GetAuthenticationRepository()
        {
            return new AuthentiactionRepository();
        }
    }
}