﻿using System;

namespace DomainModels
{
    public class Profile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string Location { get; set; }
    }
}