using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace shop.Models
{
    public class Client
    {
        public int ID { get; set; }
        public int ProdusID { get; set; }
        [Required]
        [StringLength(20)]
        public string Title { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Description cannot be longer than 50 characters.")]
        public string Description { get; set; }
        public virtual ICollection<Cos> RelatieProdus { get; set; }

        public virtual Produs Produs { get; set; }
    }
}
