using System;
using System.Collections.Generic;
using System.Text;

namespace API.DDD.Application.Dtos
{
    public class ClientDto
    {
        public Guid Id { get; set; }
        public DateTime InclusionDate { get; set; }
        public DateTime ChangeDate { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
