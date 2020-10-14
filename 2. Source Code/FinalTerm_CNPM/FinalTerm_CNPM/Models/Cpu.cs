using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinalTerm_CNPM.Models
{
    public class Cpu
    {
        public Cpu() { }
        public Cpu(string nameCpu, string typeCpu, string detailCpu)
        {
            this.nameCpu = nameCpu;
            this.typeCpu = typeCpu;
            this.detailCpu = detailCpu;
        }

        [Key]                                                                   //chỉ định khóa chỉnh
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]                   //nhảy id tự động => do tự động tăng nên không được có controller khai báo nhập id
        [Display(Name = "ID CPU")]                                              //tên hiển thị ở label (view)
        public int id { get; set; }

        [Required(ErrorMessage = "{0} không được bỏ trống")]                    //yêu cầu notnull, khi trên view để trống sẽ hiện thị thông báo trong errormessage
        [StringLength(100, ErrorMessage = "{0} không được quá {1} ký tự")]      //giới hạn độ dài tối đa, {0} là tên của biến, {1} là số 100                                        
        [Display(Name = "Tên CPU")]
        public string nameCpu { get; set; }

        [Required(ErrorMessage = "{0} không được bỏ trống")]
        [StringLength(30, ErrorMessage = "{0} không được quá {1} ký tự")]
        [Display(Name = "Phân khúc CPU")]
        public string typeCpu { get; set; }

        [StringLength(500, MinimumLength = 50, ErrorMessage = "{0} từ {2} đến {1} ký tự")]      //giới hạn từ 50~500 ký tự
        [Display(Name = "Thông tin chi tiết CPU")]
        public string detailCpu { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}