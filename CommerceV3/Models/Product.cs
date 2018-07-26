﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CommerceV3.Models
{
    public class Product
    {
		public string Id { get; set; }
        [Display(Name = "Ürün Adı")]
        public string Name { get; set; }
        [Display(Name = "Bağlantı")]
        public string Slug { get; set; }

        [StringLength(200)]
        [Display(Name = "Fotoğraf")]
        public string Photo { get; set; }

        [Display(Name = "Açıklama")]
        public string Description { get; set; }
        [Display(Name = "Eski Fiyat")]
        public decimal OldPrice { get; set; }
        [Display(Name = "Fiyat")]
        public decimal Price { get; set; }
        [Display(Name = "Adet")]
        public int Quantity { get; set; }
        [Display(Name = "Stokta Var Mı?")]
        public bool IsInStock { get; set; }
        [Display(Name = "Yayında Mı?")]
        public bool IsPublished { get; set; }
        [Display(Name = "Yeni Mi?")]
        public bool IsNew { get; set; }
        [Display(Name = "Kargo Ücreti (Şehir)")]
        public decimal ShippingPriceCityWide { get; set; }
        [Display(Name = "Kargo Ücreti (Ülke)")]
        public decimal ShippingPriceCountryWide { get; set; }
        [Display(Name = "Kargo Ücret (Dünya)")]
        public decimal ShippingPriceWorldWide { get; set; }

        [Display(Name = "Tedarikçi")]
        public string SupplierId { get; set; }
		[ForeignKey("SupplierId")]
        [Display(Name = "Tedarikçi")]
        public Supplier Supplier { get; set; }
        [Display(Name = "Marka")]
        public string BrandId { get; set; }
		[ForeignKey("BrandId")]
        [Display(Name = "Marka")]
        public Brand Brand { get; set; }

		public virtual ICollection<ProductCategory> ProductCategories { get; set; }

        [Display(Name = "Oluşturulan Kullanıcı")]
        public string CreatedBy { get; set; }
        [Display(Name = "Oluşturulma Tarihi")]
        public DateTime CreateDate { get; set; }
        [Display(Name = "Güncelleyen Kullanıcı")]
        public string UpdatedBy { get; set; }
        [Display(Name = "Güncellenme Tarihi")]
        public DateTime UpdateDate { get; set; }

		public virtual ICollection<CartItem> CartItems { get; set; }


	}
}
