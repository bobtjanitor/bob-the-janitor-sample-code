using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CyclingRepository;

namespace cyclingLog.Biz
{
    public interface IAuthentication
    {
        string Username { get; set; }
        string Password { get; set; }
        List<string> ValidationErrors { get; set; }
        bool Authenticate();
    }

    public class Authentication : IAuthentication
    {
        public string Username{get;set;}
        public string Password { get; set; }

        private List<string> _validationErrors=new List<string>();
        public List<string> ValidationErrors
        {
            get { return _validationErrors; }
            set { _validationErrors = value; }
        }

        private IAuthentiactionRepository _authenticationRepositoryInterface;
        public IAuthentiactionRepository AuthenticationRepositoryInterface
        {
            get
            {
                if (_authenticationRepositoryInterface == null)
                {
                    _authenticationRepositoryInterface = Factories.GetAuthenticationRepository();
                }
                return _authenticationRepositoryInterface;
            }
            set { _authenticationRepositoryInterface = value; }
        }

        public bool Authenticate()
        {
            if (string.IsNullOrWhiteSpace(Username))
            {
                ValidationErrors.Add("Username Required");
            }

            if (string.IsNullOrWhiteSpace(Password))
            {
                ValidationErrors.Add("Password Required");
            }
            return ValidationErrors.Count==0;
        }
    }
}
