using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinalTerm_CNPM.Models
{
    public class CartProducts
    {
        public CartProducts() { }
        public CartProducts(int amount, int cartId, Cart cart, int productId, Product product)
        {
            this.amount = amount;
            this.cartId = cartId;
            Cart = cart;
            this.productId = productId;
            Product = product;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int amount { get; set; }

        public int cartId { get; set; }
        [ForeignKey("cartId")]
        public virtual Cart Cart { get; set; }

        public int productId { get; set; }
        [ForeignKey("productId")]
        public virtual Product Product { get; set; }
    }
}