using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CommerceV3.Models
{
    public class Product
    {
		public string Id { get; set; }
		public string Name { get; set; }
		public string Slug { get; set; }
		public string Description { get; set; }
		public decimal OldPrice { get; set; }
		public decimal Price { get; set; }
		public int Quantity { get; set; }
		public bool IsInStock { get; set; }
		public bool IsPublished { get; set; }
		public bool IsNew { get; set; }
		public decimal ShippingPriceCityWide { get; set; }
		public decimal ShippingPriceCountryWide { get; set; }
		public decimal ShippingPriceWorldWide { get; set; }

		public string SupplierId { get; set; }
		[ForeignKey("SupplierId")]
		public Supplier Supplier { get; set; }

		public string BrandId { get; set; }
		[ForeignKey("BrandId")]
		public Brand Brand { get; set; }

		public virtual ICollection<ProductCategory> ProductCategories { get; set; }

		public string CreatedBy { get; set; }
		public DateTime CreateDate { get; set; }
		public string UpdatedBy { get; set; }
		public DateTime UpdateDate { get; set; }

		public virtual ICollection<CartItem> CartItems { get; set; }


	}
}
