using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinalTerm_CNPM.Models
{
    public class User
    {
        public User() { }
        public User(int id, string userName, string password, string userEmail, string userRole)
        {
            this.id = id;
            this.userName = userName;
            this.password = password;
            this.userEmail = userEmail;
            this.userRole = userRole;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [Index(IsUnique = true)]
        [StringLength(200)]
        public String userName { get; set; }

        [Required]
        [StringLength(200)]
        public String password { get; set; }

        [Required]
        [Index(IsUnique = true)]
        [StringLength(200)]
        public String userEmail { get; set; }

        [Required]
        [Index(IsUnique = true)]
        [StringLength(10)]
        public String userRole { get; set; }

        public virtual ICollection<Cart> Cart { get; set; }
        public virtual ICollection<Order> Order { get; set; }
    }
}