using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinalTerm_CNPM.Models
{
    public class Ram
    {
        public Ram() { }
        public Ram(string nameRam, string typeRam, int sizeRam, string unitSizeRam, string busRam)
        {
            this.nameRam = nameRam;
            this.typeRam = typeRam;
            this.sizeRam = sizeRam;
            this.unitSizeRam = unitSizeRam;
            this.busRam = busRam;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   
        [Display(Name = "ID RAM")]                             
        public int id { get; set; }

        [Required(ErrorMessage = "{0} không được bỏ trống")]   
        [StringLength(100, ErrorMessage = "{0} không được quá {1} ký tự")]                                      
        [Display(Name = "Tên RAM")]
        public string nameRam { get; set; }

        [Required(ErrorMessage = "{0} không được bỏ trống")]   
        [StringLength(50, ErrorMessage = "{0} không được quá {1} ký tự")]                                       
        [Display(Name = "Loại RAM")]
        public string typeRam { get; set; }

        [Required(ErrorMessage = "{0} không được bỏ trống")]  
        [Display(Name = "Dung lượng RAM")]
        public int sizeRam { get; set; }

        [Required(ErrorMessage = "{0} không được bỏ trống")]   
        [StringLength(10, ErrorMessage = "{0} không được quá {1} ký tự")]                                         
        [Display(Name = "Đơn vị dung lượng RAM")]
        public string unitSizeRam { get; set; }

        [StringLength(50, ErrorMessage = "{0} không được quá {1} ký tự")]
        [Display(Name = "Tốc độ Bus RAM")]
        public string busRam { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}