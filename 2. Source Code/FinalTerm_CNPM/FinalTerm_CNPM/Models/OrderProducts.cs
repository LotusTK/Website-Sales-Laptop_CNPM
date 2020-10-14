using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinalTerm_CNPM.Models
{
    public class OrderProducts
    {
        public OrderProducts() { }
        public OrderProducts(int amount, int orderId, Order order, int productId, Product product)
        {
            this.amount = amount;
            this.orderId = orderId;
            Order = order;
            this.productId = productId;
            Product = product;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int amount { get; set; }

        public int orderId { get; set; }
        [ForeignKey("orderId")]
        public Order Order { get; set; }

        public int productId { get; set; }
        [ForeignKey("productId")]
        public Product Product { get; set; }
    }
}