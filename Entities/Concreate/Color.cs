﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concreate
{
    public class Color : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

    }
}