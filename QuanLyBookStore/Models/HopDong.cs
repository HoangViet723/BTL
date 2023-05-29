using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyBookStore.Models
{
    public class HopDong
    {
        [Key]
        [Display(Name ="Mã hợp đồng")]
        public string? MaHD {get; set;}

        [Display(Name ="Tên nhân viên")]
        public string? TenNV {get; set;}
        [ForeignKey("TenNV")]
        public NhanVien? NhanVien {get; set;}

        [Display(Name ="Ngày bắt đầu")]
        public string? DateStart {get; set;}

        [Display(Name ="Ngày kết thúc")]
        public string? DateEnd {get; set;}

        [Display(Name ="Lương")]
        public string? Luong {get; set;}
        
    }
}