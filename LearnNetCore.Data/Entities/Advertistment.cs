using LearnNetCore.Data.Enums;
using LearnNetCore.Data.Interfaces;
using LearnNetCore.Infrastructure.ShareKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LearnNetCore.Data.Entities
{
    [Table("Advertistments")]
    public class Advertistment : DomainEntity<int>, ISwitchable, ISoftable, IDateTracking
    {
        [StringLength(250)]
        public string Name { get; set; }
        [StringLength(250)]
        public string Description { get; set; }
        [StringLength(250)]
        public string Image { get; set; }
        [StringLength(250)]
        public string Url { get; set; }
        [StringLength(20)]
        public string PositionId { get; set; }
        public int SoftOrder { get; set; }
        public Status Status { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        [ForeignKey("PositionId")]
        public virtual AdvertistmentPosition AdvertistmentPosition { get; set; }
    }
}
