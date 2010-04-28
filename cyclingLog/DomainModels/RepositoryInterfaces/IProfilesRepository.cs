namespace DomainModels.RepositoryInterfaces
{
    public interface IProfilesRepository
    {
        Profiles GetProfileList();
        Profile GetProfileById(int id);
    }
}