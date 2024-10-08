﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_Models
{
	public class ProductImage
	{
		public int Id { get; set; }
		[Required]
		public string ImageUrl { get; set; }
		public int ProductId { get; set; }
		[ForeignKey("ProductId")]
		public Product Product { get; set; }
	}
}
