﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace BS_Models
{
	public class Product
	{
		public int Id { get; set; }
		[Required]
		public string Title { get; set; } 
		public string Description { get; set; }
		[Required]
		public string ISBN { get; set; }
		[Required]
		public string Author { get; set; }
		[Required]
		[Display(Name = "List Price")]
		[Range(1,1000)]
		public int ListPrice { get; set; }
		[Required]
		[Display(Name = "Price for 1-50")]
		[Range(1, 1000)]
		public int Price { get; set; }
		[Required]
		[Display(Name = "Price for 50+")]
		[Range(1, 1000)]
		public int Price50 { get; set; }
		[Required]
		[Display(Name = "Price for 100+")]
		[Range(1, 1000)]
		public int Price100 { get; set; }
		public int CategoryId { get; set; }
		[ForeignKey("CategoryId")]
		[ValidateNever]
		public Category category { get; set; }
		[ValidateNever]
		public string ImageUrl { get; set; }
	}
}
