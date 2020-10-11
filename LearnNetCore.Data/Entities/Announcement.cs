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
    [Table("Announcements")]//bang thong bao (thong bao cho ai? cho user nao, cho nguoi dung thong tin gi)
    public class Announcement : DomainEntity<string>, ISwitchable, IDateTracking
    {
        public Announcement()
        {
            AnnouncementUsers = new List<AnnouncementUser>();
        }
        [Required]
        [StringLength(250)]
        public string Title { get; set; }
        [StringLength(250)]
        public string Content { get; set; }
        [StringLength(450)]
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual AppUser AppUser { get; set; }

        public virtual ICollection<AnnouncementUser> AnnouncementUsers { get; set; }

        public Status Status { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

    }
}
