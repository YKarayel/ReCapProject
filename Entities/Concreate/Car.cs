using Core.Entities;
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
        public int Id { get; set; }
        public int ModelYear { get; set; }

        public double DailyPrice { get; set; }
        public string Description { get; set; }
		public int? RentalId { get; set; }
		public int? CarImageId { get; set; }
		public int ColorId { get; set; }
		public int BrandId { get; set; }

	}
}
