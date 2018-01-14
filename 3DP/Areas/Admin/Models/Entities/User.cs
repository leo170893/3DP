using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using _3DP.Areas.Admin.Constant;

namespace _3DP.Areas.Admin.Models
{
    [Table("tb_Users")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string UserID { get; set; }

        [Required(ErrorMessage = ErrorMessageConstant.Require)]
        [Display(Name = "Mật khẩu")]
        [Column(TypeName ="nvarchar")]
        [MaxLength(20, ErrorMessage ="Tối đa 20 ký tự")]
        [MinLength(6, ErrorMessage ="Tối thiếu 6 ký tự")]
        public string Password { get; set; }

        [Required(ErrorMessage = ErrorMessageConstant.Require)]
        [StringLength(50, ErrorMessage = "Tối đa 50 ký tự")]
        [Display(Name = "Tên đăng nhập")]
        [Column(TypeName = "nvarchar")]
        public string UserName { get; set; }

        [Required(ErrorMessage = ErrorMessageConstant.Require)]
        [StringLength(150, ErrorMessage = "Tối đa 150 ký tự")]
        [Display(Name = "Họ và tên")]
        [Column(TypeName = "nvarchar")]
        public string FullName { get; set; }

        [Display(Name = "Giới tính")]
        [Column(TypeName = "bit")]
        public bool Gender { get; set; }

        [StringLength(500, ErrorMessage = "Tối đa 500 ký tự")]
        [Required(ErrorMessage = ErrorMessageConstant.Require)]
        [Display(Name = "Địa chỉ")]
        [Column(TypeName = "nvarchar")]
        public string Address { get; set; }

        [Required(ErrorMessage = ErrorMessageConstant.Require)]
        [StringLength(100, ErrorMessage = "Tối đa 100 ký tự")]
        [Display(Name = "Email")]
        [Column(TypeName = "nvarchar")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = ErrorMessageConstant.Require)]
        [StringLength(100, ErrorMessage = "Tối đa 100 ký tự")]
        [Display(Name = "Số điện thoại")]
        [Column(TypeName = "nvarchar")]
        [DataType(DataType.EmailAddress)]
        public string PhoneNumber { get; set; }

        [Display(Name = "Ảnh đại diện")]
        [Column(TypeName = "nvarchar")]
        [DataType(DataType.ImageUrl)]
        public string Avatar { get; set; }

        [Required(ErrorMessage = ErrorMessageConstant.Require)]
        [Display(Name = "Ngày sinh")]
        [Column(TypeName = "date")]
        public DateTime BirthDay { get; set; }
    }
}