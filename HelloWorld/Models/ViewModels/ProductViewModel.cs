using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HelloWorld.Models.ViewModels
{
    public class ProductViewModel
    {
        public Guid Id { get; set; }
        [StringLength(256)]
        [DisplayName("Tên sp")]
        public string Name { get; set; }
		[DisplayName("Ngày hết hạn")]
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
		public DateTime? PublicationDate { get; set; }
		[Required]
        [DisplayName("Mệnh giá")]
        public double Price { get; set; }
        [DisplayName("Chi tiết")]
        public string Description { get; set; }
        [DisplayName("Cân nặng")]
        public double? Weight { get; set; }
        [DisplayName("Chiều cao")]
        public double? Height { get; set; }
        [DisplayName("Chiều rộng")]
        public double? Width { get; set; }
		[DisplayName("Hình ảnh")]
		public string UrlImage { get; set; }

		[DisplayName("Thể loại")]
		public Guid? CategoryId { get; set; }
		[DisplayName("Thể loại")]
		public string CategoryName { get; set; }

		[DisplayName("Nhà cung cấp")]
		public Guid? SupplierId { get; set; }
		[DisplayName("Nhà cung cấp")]
		public string SupplierName { get; set; }
		


		[DisplayName("Nhà sản xuất")]
        public Guid? ManufacturerId { get; set; }
		[DisplayName("Nhà sản xuất")]
		public string ManufacturerName { get; set; }

		[NotMapped]
		public HttpPostedFileBase UploadImage { get; set; }
	}
}