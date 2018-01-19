using _3DP.Areas.Admin.Constant;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _3DP.Areas.Admin.Models.Entities
{
    [Table("tb_News")]
    public class News
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NewID { get; set; }

        [Required(ErrorMessage = ErrorMessageConstant.Require)]
        [Display(Name = "Tiêu đề")]
        [Column(TypeName = "nvarchar")]
        public string Title { get; set; }

        [Required(ErrorMessage = ErrorMessageConstant.Require)]
        [Display(Name = "Nội dung")]
        [Column(TypeName = "nvarchar")]
        public string Content { get; set; }

        [Required(ErrorMessage = ErrorMessageConstant.Require)]
        [Display(Name = "Ngày đăng")]
        [Column(TypeName = "nvarchar")]
        public DateTime CreateDate { get; set; }

        [Display(Name = "Tác giả")]
        [Column(TypeName = "date")]
        public string Author { get; set; }

        [Required(ErrorMessage = ErrorMessageConstant.Require)]
        [Display(Name = "Hình ảnh")]
        [Column(TypeName = "nvarchar")]
        public string Image { get; set; }
    }
}