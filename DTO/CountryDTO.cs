﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CountryDTO
    {
        public int Id { get; set; }
        public string CountyName { get; set; }
        public bool IsActive { get; set; }

    }
}
