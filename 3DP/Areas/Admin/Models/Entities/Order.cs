using _3DP.Areas.Admin.Constant;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _3DP.Areas.Admin.Models.Entities
{
    [Table("tb_Order")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MyOrderIDProperty { get; set; }

        [Required(ErrorMessage = ErrorMessageConstant.Require)]
        [Display(Name = "Sản phẩm")]
        [Column(TypeName = "int")]
        public int ProductID { get; set; }

        [Required(ErrorMessage = ErrorMessageConstant.Require)]
        [Display(Name = "Trạng thái")]
        [Column(TypeName = "int")]
        public int State { get; set; }
    }
}