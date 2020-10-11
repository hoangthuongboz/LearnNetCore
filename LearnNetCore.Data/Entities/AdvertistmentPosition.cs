using LearnNetCore.Infrastructure.ShareKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LearnNetCore.Data.Entities
{
    [Table("AdvertistmentPositions")]//vi tri cua quang cao
    public class AdvertistmentPosition : DomainEntity<string>
    {
        [StringLength(20)]
        public string PageId { get; set; }
        [StringLength(250)]
        public string Name { get; set; }
        [ForeignKey("PageId")]
        public virtual AdvertistmentPage AdvertistmentPage { get; set; }
        public virtual ICollection<Advertistment> Advertistments { get; set; }
    }
}
