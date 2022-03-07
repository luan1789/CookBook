﻿using CookingBox.Business.CustomEntities.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingBox.Business.CustomEntities.ModelSearch
{
    public class RoleListSearch : PagingParameters
    {
        public string? name { get; set; }

        public bool? status { get; set; }
    }
}
