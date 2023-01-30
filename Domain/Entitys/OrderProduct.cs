using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace API.DDD.Domain.Entitys
{
    public class OrderProduct : Base
    {
        public int Code { get; set; }
        public int Amount { get; set; }
        [ForeignKey("Product")]
        public Guid ProductId { get; set; }
        [ForeignKey("Order")]
        public Guid OrderId { get; set; }
        public Product Product { get; set; }
        public Order Order { get; set; }


    }
}
