using LearnNetCore.Data.Enums;
using LearnNetCore.Data.Interfaces;
using LearnNetCore.Infrastructure.ShareKernel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearnNetCore.Data.Entities
{
    [Table("Pages")]
    public class Page : DomainEntity<int>, ISwitchable
    {
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }
        [MaxLength(256)]
        [Required]
        public string Alias { get; set; }
        public string Content { get; set; }
        public Status Status { get; set; }
    }
}
