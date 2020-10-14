using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinalTerm_CNPM.Models
{
    public class Laptop
    {
        public Laptop() { }
        public Laptop(string nameLaptop, string displaySize, double weightLaptop, string detailLaptop)
        {
            this.nameLaptop = nameLaptop;
            this.displaySize = displaySize;
            this.weightLaptop = weightLaptop;
            this.detailLaptop = detailLaptop;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID Laptop")]
        public int id { get; set; }

        [Required(ErrorMessage = "{0} không được bỏ trống")]
        [StringLength(100, ErrorMessage = "{0} không được quá {1} ký tự")]
        [Display(Name = "Tên Laptop")]
        public string nameLaptop { get; set; }

        [Required(ErrorMessage = "{0} không được bỏ trống")]
        [StringLength(10, ErrorMessage = "{0} không được quá {1} ký tự")]
        [Display(Name = "Kích thước màn hình")]
        public string displaySize { get; set; }

        [Required(ErrorMessage = "{0} không được bỏ trống")]
        [Display(Name = "Trọng lượng")]
        public double weightLaptop { get; set; }

        [StringLength(500, MinimumLength = 50, ErrorMessage = "{0} từ {2} đến {1} ký tự")]
        [Display(Name = "Thông tin chi tiết Laptop")]
        public string detailLaptop { get; set; }

        public virtual ICollection<Product> Product { get; set; }               //do Laptop xuất hiện nhiều lần trong Product nên phải khai báo
                                                                                //một biến danh sách các Product trong Laptop
    }
}