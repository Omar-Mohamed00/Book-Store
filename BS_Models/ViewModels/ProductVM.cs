using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace BS_Models.ViewModels
{
	public class ProductVM
	{
        public Product Product { get; set; }
		[ValidateNever]
		public IEnumerable<SelectListItem> CategoryList { get; set; }

	}
}
