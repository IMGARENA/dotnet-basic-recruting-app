﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchDataManager.Api.Models
{
    public class LocationDto : EntityDto
    {
        public string Name { get; set; }

        public string City { get; set; }
    }
}
