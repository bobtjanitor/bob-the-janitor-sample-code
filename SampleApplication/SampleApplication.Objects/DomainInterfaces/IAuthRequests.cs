namespace SampleApplication.Objects.DomainInterfaces
{
    public interface IAuthRequests
    {
        bool UserCanUpdateEmployee(int userId, int employeeId);
    }
}
