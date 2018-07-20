using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommerceV3.Models
{
    public class Brand
    {
		public string Id { get; set; }
		public string Name { get; set; }
		public string Logo { get; set; }

		public virtual ICollection<Product> Products { get; set; }
    }
}
