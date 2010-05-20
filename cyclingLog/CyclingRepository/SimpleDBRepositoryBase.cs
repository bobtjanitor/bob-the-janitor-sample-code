using System.Configuration;

namespace CyclingRepository
{
    public class SimpleDBRepositoryBase
    {
        protected readonly string _publicKey = ConfigurationManager.AppSettings["PublicKey"];
        protected readonly string _secretKey = ConfigurationManager.AppSettings["SecretKey"];
    }
}