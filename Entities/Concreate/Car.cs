﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concreate
{
    public class Car : IEntity
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("BrandId")]
        public int BrandId { get; set; }
        [ForeignKey("ColorId")]

        public int ColorId { get; set; }
        public string ModelYear { get; set; }
        public double DailyPrice { get; set; }
        public string Description { get; set; }


    }
}
