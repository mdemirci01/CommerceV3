using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CommerceV3.Models
{
    public class Supplier
    {
		public string Id { get; set; }
		public string Name { get; set; }
		public string RegionId { get; set; }
		[ForeignKey("RegionId")]
		public Region Region { get; set; }

		public string CreatedBy { get; set; }
		public DateTime CreateDate { get; set; }
		public string UpdatedBy { get; set; }
		public DateTime UpdateDate { get; set; }

		public virtual ICollection<Product> Products { get; set; }
    }
}
