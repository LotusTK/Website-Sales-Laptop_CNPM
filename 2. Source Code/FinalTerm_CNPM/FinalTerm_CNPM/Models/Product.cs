using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinalTerm_CNPM.Models
{
    public class Product
    {
        public Product() { }
        public Product(int state, int price, string primaryType, string img, int? laptopId, int? cpuId, int? ramId, int? storageId)
        {
            this.state = state;
            this.price = price;
            this.primaryType = primaryType;
            this.img = img;
            this.laptopId = laptopId;
            this.cpuId = cpuId;
            this.ramId = ramId;
            this.storageId = storageId;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID Sản phẩm")]
        public int id { get; set; }

        [Required]
        [Display(Name = "Trạng thái")]
        public int state { get; set; }

        [Required]
        [Display(Name = "Giá tiền")]
        public int price { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "{0} không quá {1} ký tự")]
        public string primaryType { get; set; }

        [StringLength(500, ErrorMessage = "{0} không quá {1} ký tự")]
        public string img { get; set; }

        public int? laptopId { get; set; }                                //FK đặt lại tên "?" -> cho phép null
        [ForeignKey("laptopId")]
        public virtual Laptop Laptop { get; set; }                        //khi khai báo biến này, nó sẽ tạo FK tự động dựa trên object mình chỉ định
                                                                          //nhưng nếu muốn đổi tên lại FK thì viết như trên, public int laptopId
                                                                          //và thêm [ForeignKey("laptopId")] trên biến Laptop Laptop
                                                                          //từ khóa virtual để báo có quan hệ với object Laptop

        public int? cpuId { get; set; }
        [ForeignKey("cpuId")]
        public virtual Cpu Cpu { get; set; }

        public int? ramId { get; set; }
        [ForeignKey("ramId")]
        public virtual Ram Ram { get; set; }

        public int? storageId { get; set; }
        [ForeignKey("storageId")]
        public virtual Storage Storage { get; set; }

        public virtual ICollection<CartProducts> CartProducts { get; set; }
        public virtual ICollection<OrderProducts> OrderProducts { get; set; }
    }
}