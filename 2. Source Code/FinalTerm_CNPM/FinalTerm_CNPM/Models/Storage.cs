using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinalTerm_CNPM.Models
{
    public class Storage
    {
        public Storage() { }
        public Storage(string nameStorage, string typeStorage, int sizeStorage, string unitSizeStorage, string detailStorage)
        {
            this.nameStorage = nameStorage;
            this.typeStorage = typeStorage;
            this.sizeStorage = sizeStorage;
            this.unitSizeStorage = unitSizeStorage;
            this.detailStorage = detailStorage;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   
        [Display(Name = "ID ổ cứng")]
        public int id { get; set; }

        [Required(ErrorMessage = "Nội dung không được bỏ trống")]   
        [StringLength(100, ErrorMessage = "{0} không được quá {1} ký tự")]                                         
        [Display(Name = "Tên ổ cứng")]
        public string nameStorage { get; set; }

        [Required(ErrorMessage = "Nội dung không được bỏ trống")]  
        [StringLength(50, ErrorMessage = "{0} không được quá {1} ký tự")]                                        
        [Display(Name = "Loại ổ đĩa cứng")]
        public string typeStorage { get; set; }

        [Required(ErrorMessage = "Nội dung không được bỏ trống")]   
        [Display(Name = "Dung lượng ổ cứng")]
        public int sizeStorage { get; set; }

        [Required(ErrorMessage = "Nội dung không được bỏ trống")]
        [StringLength(10, ErrorMessage = "{0} không được quá {1} ký tự")] 
        [Display(Name = "Đơn vị dung lượng ổ cứng")]
        public string unitSizeStorage { get; set; }

        [StringLength(500, MinimumLength = 50, ErrorMessage = "{0} từ {2} đến {1} ký tự")]
        [Display(Name = "Thông tin chi tiết ổ cứng")]
        public string detailStorage { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}