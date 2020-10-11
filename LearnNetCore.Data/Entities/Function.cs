using LearnNetCore.Data.Enums;
using LearnNetCore.Data.Interfaces;
using LearnNetCore.Infrastructure.ShareKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Text;

namespace LearnNetCore.Data.Entities
{
    [Table("Funtions")]
    public class Function : DomainEntity<string>, ISwitchable, ISoftable
    {
        public Function() { }
        public Function(string name, string url, string parentId, string iconCss, int sortOrder)
        {
            this.Name = name;
            this.Url = url;
            this.ParentId = parentId;
            this.IconCss = iconCss;
            this.SoftOrder = sortOrder;
            this.Status = Status.Active;
        }
        [Required]
        [StringLength(128)]
        public string Name { get; set; }
        [Required]
        [StringLength(250)]
        public string Url { get; set; }
        [StringLength(128)]
        public string ParentId { get; set; }
        public string IconCss { get; set; }
        public int SoftOrder { get; set; }
        public Status Status { get; set; }

    }
}
