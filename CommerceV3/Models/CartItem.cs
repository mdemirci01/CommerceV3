using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CommerceV3.Models
{
    public class CartItem
    {
		public string Id { get; set; }
		public string CartId { get; set; }
		[ForeignKey("CartId")]
		public Cart Cart { get; set; }

		public string ProductId { get; set; }
		[ForeignKey("ProductId")]
		public Product Product { get; set; }

		public int Quantity { get; set; }

		[NotMapped]
		public decimal TotalPrice
		{
			get
			{
				return Product.Price * Quantity;
			}
		}
    }
}
