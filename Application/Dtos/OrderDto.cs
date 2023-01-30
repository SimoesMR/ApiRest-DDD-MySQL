using System;
using System.Collections.Generic;
using System.Text;

namespace API.DDD.Application.Dtos
{
    public class OrderDto
    {
        public Guid Id { get; set; }
        public DateTime InclusionDate { get; set; }
        public DateTime ChangeDate { get; set; }
        public bool Excluded { get; set; }
        public int Code { get; set; }
        public Guid ClientId { get; set; }
    }
}
