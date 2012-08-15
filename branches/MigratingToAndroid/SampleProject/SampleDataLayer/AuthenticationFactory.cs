using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleDataLayer
{
    public class RequestFactory : IRequestFactory
    {
        public static readonly IRequestFactory Instance = new RequestFactory();

        private RequestFactory()
        {
            
        }

        public IAuthenticationRequests GetAuthenticationRequests()
        {
            IAuthenticationRequests myRequests = new AuthenticationRequests();
            return myRequests;
        }
    }
}
