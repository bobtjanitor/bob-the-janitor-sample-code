using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DomainModels;
using DomainModels.RepositoryInterfaces;

namespace CyclingRepository
{
    public class StubProfilesRepository : IProfilesRepository
    {
        readonly Profiles _list = new Profiles()
                                {
                                    new Profile()
                                        {
                                            Id = new Guid(),
                                            Name = "Bob The janitor",
                                            Location="Caldwell, ID",
                                            Description = "The first Rider"
                                        },
                                        new Profile()
                                        {
                                            Id = new Guid(),
                                            Name = "JoJo",
                                            Location="Caldwell, ID",
                                            Description = "Not into long rides"
                                        },
                                        new Profile()
                                        {
                                            Id = new Guid(),
                                            Name = "Mr. Burns",
                                            Location="Kuna, ID",
                                            Description = "The Old Man"
                                        }
                                };
        public Profiles GetProfileList()
        {
            return _list;
        }

        public Profile GetProfileById(Guid id)
        {
            Profile profile = (from item in _list where item.Id == id select item).DefaultIfEmpty(new Profile()).First();
            return profile;
        }
    }

}
