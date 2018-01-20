using _3DP.Areas.Admin.Constant;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _3DP.Areas.Admin.Models.Entities
{
    [Table("tb_Promote")]
    public class Promote
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MyPropePromoteIDrty { get; set; }

        [Required(ErrorMessage = ErrorMessageConstant.Require)]
        [StringLength(20, ErrorMessage = "Tối đa 20 ký tự")]
        [Display(Name = "Mã chương trình")]
        [Column(TypeName = "nvarchar")]
        public string PromoteCode { get; set; }

        [Required(ErrorMessage = ErrorMessageConstant.Require)]
        [Display(Name = "Tên")]
        [Column(TypeName = "nvarchar")]
        public string PromoteName { get; set; }

        [Required(ErrorMessage = ErrorMessageConstant.Require)]
        [Display(Name = "Ngày bắt đầu")]
        [Column(TypeName = "date")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = ErrorMessageConstant.Require)]
        [Display(Name = "Ngày kết thúc")]
        [Column(TypeName = "date")]
        public DateTime EndDate { get; set; }
                
        [Display(Name = "Khuyến mãi")]
        [Column(TypeName = "float")]
        public float SalePercent { get; set; }

    }
}