using System.Collections.Generic;
using System.Linq;
using System.Text;
using DomainModels;
using DomainModels.RepositoryInterfaces;

namespace CyclingRepository
{
    public class StubProfilesRepository : IProfilesRepository
    {
        public Profiles GetProfileList()
        {
            Profiles list = new Profiles()
                                {
                                    new Profile()
                                        {
                                            Id = 1,
                                            Name = "Bob The janitor",
                                            Description = "The first Rider"
                                        },
                                        new Profile()
                                        {
                                            Id = 2,
                                            Name = "JoJo",
                                            Description = "Not into long rides"
                                        },
                                        new Profile()
                                        {
                                            Id = 3,
                                            Name = "Mr. Burns",
                                            Description = "The Old Man"
                                        }
                                };
            return list;
        }
    }

}
