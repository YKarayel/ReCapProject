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
    public class CarImage : IEntity
    {
        public int Id { get; set; }
        public string? ImagePath { get; set; }
        public DateTime? UploadDate { get; set; }
		public int CarId { get; set; }

	}
}
