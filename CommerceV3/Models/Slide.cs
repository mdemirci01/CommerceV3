using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommerceV3.Models
{
    public class Slide
    {
		public string Id { get; set; }
		public string Name { get; set; }
		public string Image { get; set; }
		public string Url { get; set; }
		public string Target { get; set; }
		public bool IsPublished { get; set; }
		public int Position { get; set; }
    }
}
