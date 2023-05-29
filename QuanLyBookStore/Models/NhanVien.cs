using System.ComponentModel.DataAnnotations;
namespace QuanLyBookStore.Models
{
    public class NhanVien
    {
        [Key]
        [Display(Name ="Mã nhân viên")]
        public string? MaNV {get; set;}

        [Display(Name ="Tên nhân viên")]
        public string? TenNV {get; set;}

        [Display(Name ="Ngày sinh")]
        public string? NgaySinh {get; set;}

        [Display(Name ="Quê quán")]
        public string? Quequan {get; set;}
        
        [Display(Name ="Số điện thoại")]
        public string? SDT {get; set;}
    }
}