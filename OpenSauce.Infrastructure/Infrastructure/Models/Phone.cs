using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Models
{
    public class Phone
    {
        public int Id { get; set; }
        public string? Number { get; set; }
        public string? Type { get; set; }
    }
}