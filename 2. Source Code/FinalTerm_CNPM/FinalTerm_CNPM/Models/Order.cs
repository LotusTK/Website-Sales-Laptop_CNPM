using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinalTerm_CNPM.Models
{
    public class Order
    {
        public Order() { }
        public Order(int totalPrice, int userId, User user)
        {
            this.totalPrice = totalPrice;
            this.userId = userId;
            User = user;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Display(Name = "Tổng tiền")]
        public int totalPrice { get; set; }

        public int userId { get; set; }
        [ForeignKey("userId")]
        public virtual User User { get; set; }

        public virtual ICollection<OrderProducts> OrderProducts { get; set; }
    }
}