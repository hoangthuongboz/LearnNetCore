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
    [Table("Bills")]
    public class Bill : DomainEntity<int>, ISwitchable, IDateTracking
    {
        public Bill()
        {

        }
        public Bill(int id, string customerName, string custonmerAddress, string customerMobile, string customerMessage, BillStatus billStatus, PaymentMethod paymentMethod, Status status, string customerId)
        {
            Id = id;
            CustomerName = customerName;
            CustomerAddress = custonmerAddress;
            CustomerMessage = customerMessage;
            BillStatus = billStatus;
            PaymentMethod = paymentMethod;
            Status = status;
            CustomerId = customerId;
        }
        public Bill(string customerName, string custonmerAddress, string customerMobile, string customerMessage, BillStatus billStatus, PaymentMethod paymentMethod, Status status, string customerId)
        {
            CustomerName = customerName;
            CustomerAddress = custonmerAddress;
            CustomerMessage = customerMessage;
            BillStatus = billStatus;
            PaymentMethod = paymentMethod;
            Status = status;
            CustomerId = customerId;
        }
        [Required]
        [StringLength(256)]
        public string CustomerName { get; set; }
        [Required]
        [StringLength(256)]
        public string CustomerAddress { get; set; }
        [Required]
        [StringLength(256)]
        public string CustomerMobile { get; set; }
        [Required]
        [StringLength(256)]
        public string CustomerMessage { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public BillStatus BillStatus { get; set; }
        
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        [DefaultValue(Status.Active)]
        public Status Status { get; set; } = Status.Active;
        
        [StringLength(450)]
        public string CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public virtual AppUser AppUser { get; set; }
        public virtual ICollection<BillDetail> BillDetails { get; set; }
    }
}
