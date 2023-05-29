using System.ComponentModel.DataAnnotations;
namespace QuanLyBookStore.Models
{
    public class Sach
    {
        [Key]
        [Display(Name ="Mã sách")]
        public string? MaSach {get; set;}

        [Display(Name ="Tên sách")]
        public string? TenSach {get; set;}

        [Display(Name ="Tên NXB")]
        public string? TenNXB {get; set;}

        [Display(Name ="Giá")]
        public string? Gia {get; set;}
    }
}