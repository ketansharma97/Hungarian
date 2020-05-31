﻿using Hungarian.Models.Dishes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hungarian.Interfaces
{
   
        public interface ICategoryRepository
        {
            IEnumerable<Category> Categories { get; }
        }
   
}
