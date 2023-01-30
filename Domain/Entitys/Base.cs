using System;

namespace API.DDD.Domain.Entitys
{
    public class Base
    {
        public Guid Id { get; set; }
        public bool Excluded { get; set; }
        public DateTime InclusionDate { get; set; }
        public DateTime ChangeDate { get; set; }

    }
}
