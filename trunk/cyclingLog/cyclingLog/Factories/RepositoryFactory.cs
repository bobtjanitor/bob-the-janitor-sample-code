using System;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using System.Web.Routing;
using Castle.Core;
using Castle.Core.Resource;
using Castle.Windsor;
using Castle.Windsor.Configuration.Interpreters;
using CyclingRepository;
using DomainModels.RepositoryInterfaces;

namespace cyclingLog.Factories
{
    public class RepositoryFactory
    {
        public static IProfilesRepository GetProfilesRepository()
        {
            return new StubProfilesRepository();
        }
    }
}