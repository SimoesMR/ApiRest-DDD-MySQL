using System;
using System.Collections.Generic;
using System.Text;

namespace API.DDD.Application.Dtos
{
    public class OrderProductDto
    {
        public Guid Id { get; set; }
        public DateTime InclusionDate { get; set; }
        public DateTime ChangeDate { get; set; }
        public int Code { get; set; }
        public int Amount { get; set; }
        public Guid OrderID { get; set; }
        public Guid ProductId { get; set; }
    }
}
