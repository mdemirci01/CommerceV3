using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CommerceV3.Models
{
    public class Region
    {
		public string Id { get; set; }
		public string Name { get; set; }
		public RegionType RegionType { get; set; }
		public string ParentRegionId { get; set; }
		[ForeignKey("ParentRegionId")]
		public Region ParentRegion { get; set; }
		public virtual ICollection<Region> ChildRegions { get; set; }
		public virtual ICollection<Supplier> Suppliers { get; set; }
    }
}
