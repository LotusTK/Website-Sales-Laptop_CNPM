using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinalTerm_CNPM.Models
{
    public class Cart
    {
        public Cart() { }
        public Cart(int totalProduct, int state, int userId, User user)
        {
            this.totalProduct = totalProduct;
            this.state = state;
            this.userId = userId;
            User = user;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Display(Name = "Số lượng sản phẩm")]
        public int totalProduct { get; set; }

        public int state { get; set; }

        public int userId { get; set; }
        [ForeignKey("userId")]
        public virtual User User { get; set; }

        public virtual ICollection<CartProducts> CartProducts { get; set; }
    }
}