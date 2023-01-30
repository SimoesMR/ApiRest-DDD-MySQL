using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace API.DDD.Domain.Entitys
{
    public class Order : Base
    {
        public int Code { get; set; }
        [ForeignKey("Client")]
        public Guid ClientId { get; set; }
        public Client Cliente { get; set; }
    }
}
