using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using _3DP.Areas.Admin.Constant;

namespace _3DP.Areas.Admin.Models.Entities
{
    [Table("tb_Category")]
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CatID { get; set; }

        [Required(ErrorMessage = ErrorMessageConstant.Require)]
        [StringLength(220, ErrorMessage = "Tối đa 20 ký tự")]
        [Display(Name = "Mã danh mục")]
        [Column(TypeName = "nvarchar")]
        public string CatCode { get; set; }

        [Required(ErrorMessage = ErrorMessageConstant.Require)]
        [StringLength(300, ErrorMessage = "Tối đa 300 ký tự")]
        [Display(Name = "Tên danh mục")]
        [Column(TypeName = "nvarchar")]
        public string CatName { get; set; }

        [StringLength(20, ErrorMessage = "Tối đa 20 ký tự")]
        [Display(Name = "Danh mục cha")]
        [Column(TypeName = "nvarchar")]
        public string ParentCatCode { get; set; }
    }
}