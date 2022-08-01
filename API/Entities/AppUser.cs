using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Extensions;

namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string KnownAs { get; set; }

        public DateTime Created { get; set; } = DateTime.Now;

        public DateTime LastActive { get; set; } = DateTime.Now;

        public string Gender { get; set; } // TO-DO: Refactor to use enum

        public string Introduction { get; set; }

        public string LookingFor { get; set; }// TO-DO: Refactor to use enum

        public string Interests { get; set; }

        public string City { get; set; } // TO-DO: Use an Address object (will implement later)

        public ICollection<Photo> Photos { get; set; }

        public int GetAge() 
        {
            return DateOfBirth.CalculateAge();
        }
    }
}