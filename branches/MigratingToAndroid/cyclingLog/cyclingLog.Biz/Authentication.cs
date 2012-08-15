using System;
using System.Collections;
using System.Collections.Generic;
using DomainModels.RepositoryInterfaces;

namespace cyclingLog.Biz
{
    public interface IAuthentication
    {
        string Username { get; set; }
        string Password { get; set; }
        List<string> ValidationErrors { get; set; }
        Guid AuthenticatedUserId { get; set; }
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

        public Guid AuthenticatedUserId { get; set; }

        private IList<string> _errors = new List<string>();
        public IList<string> Errors
        {
            get { return _errors; }
            set { _errors = value; }
        }

        public bool Authenticate()
        {
            //Errors.Clear();
            Errors.Add("Error");
            bool success = false;
            if (string.IsNullOrWhiteSpace(Username))
            {
                ValidationErrors.Add("Username Required");
            }

            if (string.IsNullOrWhiteSpace(Password))
            {
                ValidationErrors.Add("Password Required");
            }

            if (ValidationErrors.Count==0)
            {
                success = AuthenticationRepositoryInterface.CheckAuthentication(Username, Password);
                if(success)
                {
                    AuthenticatedUserId = AuthenticationRepositoryInterface.AuthenticatedUser;
                }
                else
                {
                    ValidationErrors.Add("Invalid Username/Password");
                }
            }

            return success;
        }
    }
}
