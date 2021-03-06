﻿using Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Models
{
    public class Sale : CommonProperties<Guid>
    {

        public string CuponCode { get; set; }
        [Required]
        public double Total { get; set; }
        [Required]
        public string Description { get; set; }
        [ForeignKey(nameof(ApplicationUserId))]
        [Required]
        public string ApplicationUserId { get; set; }
        public string Code { get; set; } = Guid.NewGuid().ToString().Substring(0, 6); 
        public virtual ApplicationUser User { get; set; }
        public virtual List<DetailSale> DetailSales { get; set; }
        public Guid OrderId { get; set; }
        [ForeignKey(nameof(OrderId))]
        public virtual Order Order { get; set; }
        [Required]
        public PaymentType PaymentType { get; set; } = PaymentType.Cash;
        
    }

    public class DetailSale : CommonProperties<Guid>
    {
        [Required]
        public int Quantity { get; set; }
        public Guid SaleId { get; set; }
        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
