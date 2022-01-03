using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flat.Models
{
    public class Flat
    {
        public int Number { get; set; }

        public int RoomCount { get; set; }

        public string Street { get; set; }

        public int Floor { get; set; }

        public int HouseNumber { get; set; }
    }
}