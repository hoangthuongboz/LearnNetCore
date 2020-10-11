using LearnNetCore.Data.Enums;
using LearnNetCore.Data.Interfaces;
using LearnNetCore.Infrastructure.ShareKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LearnNetCore.Data.Entities
{
    [Table("Products")]
    public class Product : DomainEntity<int>, ISwitchable, IDateTracking, IHasSeoMetaData
    {
        [StringLength(255)]
        [Required]
        public string Name { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [StringLength(255)]
        public string Image { get; set; }
        [Required]
        [DefaultValue(0)]
        public decimal Price { get; set; }
        public decimal PromotionPrice { get; set; }
        public decimal OriginalPrice { get; set; }//decimal mà k có ? sau thì nó sẽ là bắt buộc
        [StringLength(255)]
        public string Description { get; set; }
        public string Content { get; set; }
        public bool? HomeFlag { get; set; }
        public bool HotFlag { get; set; }
        public int? ViewCount { get; set; }
        [StringLength(255)]
        public string Tags { get; set; }
        public string Unit { get; set; }
        [ForeignKey("CategoryId")] //liên kết chỉ ra trường khóa ngoại là CategoryId
        public virtual ProductCategory ProductCategory { get; set; }
        public string SeoPageTitle { get; set; }
        [Column(TypeName ="VARCHAR")]
        [StringLength(255)]
        public string SeoAlias { get; set; }
        [StringLength(255)]
        public string SeoKeywords { get; set; }
        [StringLength(255)]
        public string SeoDiscription { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public Status Status { get; set; }

        
    }
}
