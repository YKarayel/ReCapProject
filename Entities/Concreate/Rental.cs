﻿using Core.Entities;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concreate
{
    public class Rental : IEntity
    {
        [Key]
        public int Id { get; set; }
        
        
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
		public int CarId { get; set; }
		public int CustormerId { get; set; }


        
	}
}
