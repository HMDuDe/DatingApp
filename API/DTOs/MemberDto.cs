using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.DTOs
{
    public class MemberDto
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string PhotoUrl { get; set; }

        public DateTime Age { get; set; }

        public string KnownAs { get; set; }

        public DateTime Created { get; set; }

        public DateTime LastActive { get; set; }

        public string Gender { get; set; } // TO-DO: Refactor to use enum

        public string Introduction { get; set; }

        public string LookingFor { get; set; }// TO-DO: Refactor to use enum

        public string Interests { get; set; }

        public string City { get; set; } // TO-DO: Use an Address object (will implement later)

        public ICollection<PhotoDto> Photos { get; set; }
    }
}