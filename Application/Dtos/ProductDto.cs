using System;
using System.Collections.Generic;
using System.Text;

namespace API.DDD.Application.Dtos
{
    public class ProductDto
    {
        public Guid Id { get; set; }
        public DateTime InclusionDate { get; set; }
        public DateTime ChangeDate { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
    }
}
