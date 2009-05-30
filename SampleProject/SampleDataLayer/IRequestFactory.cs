namespace SampleDataLayer
{
    public interface IRequestFactory
    {
        IAuthenticationRequests GetAuthenticationRequests();
    }
}