using LearnNetCore.Infrastructure.ShareKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LearnNetCore.Data.Entities
{
    public class ProductTag:DomainEntity<int>
    {
        public int ProductId { get; set; }
        [StringLength(50)]
        [Column(TypeName ="VARCHAR")]
        public string TagId { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
        [ForeignKey("TagId")]
        public virtual Tag Tag { get; set; }
    }
}
