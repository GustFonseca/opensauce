using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? PasswordHash { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public List<Email>? Email { get; set; }
        public List<Phone>? Phone { get; set; }
        public List<Address>? Address { get; set; }
    }
}