using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcomLaptopStore.Models
{
    public class Laptop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }     
        public string year{ get; set; }
        public double price{ get; set; }
        public string image { get; set; }
    }
}
