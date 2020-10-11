using LearnNetCore.Data.Enums;
using LearnNetCore.Data.Interfaces;
using LearnNetCore.Infrastructure.ShareKernel;
using System;
using System.Collections.Generic;

namespace LearnNetCore.Data.Entities
{
    public class ProductCategory : DomainEntity<int>, IHasSeoMetaData, ISwitchable, ISoftable, IDateTracking
    {
        public ProductCategory()
        {
            Products = new List<Product>();
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? ParentId { get; set; }
        public int? HomeOrder { get; set; }
        public string Image { get; set; }
        public bool? HomeFlag { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public int SoftOrder { get; set; }
        public Status Status { get; set; }
        public string SeoPageTitle { get; set; }
        public string SeoAlias { get; set; }
        public string SeoKeywords { get; set; }
        public string SeoDiscription { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}