using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace DomailEntity.Entities
{
    public class Product : BaseEntity
    {
        #region Field
        [StringLength(256)]
        public string Name { get; set; }
        public DateTime? PublicationDate { get; set; }
        [Required]
        public double Price { get; set; }
        public string Description { get; set; }  
        public double? Weight { get; set; }        
        public double? Height { get; set; }
        public double? Width { get; set; }
		public string UrlImage { get; set; }
        #endregion

        #region Relation

        [ForeignKey("Category")]
        public Guid? CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public Guid? SupplierId { get; set; }
        [ForeignKey("SupplierId")]
        public virtual Supplier Supplier { get; set; }
        public Guid? ManufacturerId { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
		[NotMapped]
		public HttpPostedFileBase UploadImage { get; set; }
		#endregion

#if Ignore
        public int Inventory { get; set; }
        public int? OutOfStockOption { get; set; }
        public decimal? RetailPrice { get; set; }
        public int TrackInventory { get; set; }
        public string CustomCalculationScript { get; set; }
        public int? PriceType { get; set; }
        public bool? IsNeedShipping { get; set; }
        public Guid? TaxClassId { get; set; }
        public int QuantityTierType { get; set; }

#endif

	}
}
