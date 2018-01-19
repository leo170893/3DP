using _3DP.Areas.Admin.Constant;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _3DP.Areas.Admin.Models.Entities
{
    [Table("tb_Products")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; }

        [Required(ErrorMessage = ErrorMessageConstant.Require)]
        [Display(Name = "Tên")]
        [Column(TypeName = "nvarchar")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = ErrorMessageConstant.Require)]
        [StringLength(20, ErrorMessage = "Tối đa 20 ký tự")]
        [Display(Name = "Mã")]
        [Column(TypeName = "nvarchar")]
        public string ProductCode { get; set; }

        [Required(ErrorMessage = ErrorMessageConstant.Require)]
        [Display(Name = "Danh mục")]
        [Column(TypeName = "nvarchar")]
        public string CatCode { get; set; }

        [Required(ErrorMessage = ErrorMessageConstant.Require)]
        [Display(Name = "Giá bán")]
        [Column(TypeName = "float")]
        public float Price { get; set; }

        [Required(ErrorMessage = ErrorMessageConstant.Require)]
        [Display(Name = "Khuyễn mãi")]
        [Column(TypeName = "float")]
        public float SalePrice { get; set; }

        [Display(Name = "Ngày nhập")]
        [Column(TypeName = "date")]
        public DateTime CreatetDate { get; set; }

        [Display(Name = "ngày bán")]
        [Column(TypeName = "date")]
        public DateTime SaleDate { get; set; }

        [Required(ErrorMessage = ErrorMessageConstant.Require)]
        [Display(Name = "Hình ảnh")]
        [Column(TypeName = "nvarchar")]
        public string Image { get; set; }
    }
}