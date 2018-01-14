using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using _3DP.Areas.Admin.Constant;

namespace _3DP.Areas.Admin.Models.Entities
{
    [Table("tb_Bills")]
    public class Bill
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string BillID { get; set; }

        [Required(ErrorMessage = ErrorMessageConstant.Require)]
        [StringLength(50, ErrorMessage = "Tối đa 50 ký tự")]
        [Display(Name = "Tên hóa đơn")]
        [Column(TypeName = "nvarchar")]
        public string BillCode { get; set; }

        [Required(ErrorMessage = ErrorMessageConstant.Require)]
        [Display(Name = "Ngày lập hóa đơn")]
        [Column(TypeName = "date")]
        public string BillDate { get; set; }

        [StringLength(20, ErrorMessage = "Tối đa 20 ký tự")]
        [Display(Name = "Mã khuyến mãi")]
        [Column(TypeName = "nvarchar")]
        public string PromoteCode { get; set; }

        [Required(ErrorMessage = ErrorMessageConstant.Require)]
        [Display(Name = "Tổng tiền")]
        [Column(TypeName = "float")]
        public float Total { get; set; }
    }
}