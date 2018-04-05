using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApp.Models
{
    public class SearchResultViewModel
    {
        public int CarId { get; set; }

        public string Name { get; set; }

        public DateTime FromTime { get; set; }

        public DateTime ToTime { get; set; }

        public List<string> AvailableLocations { get; set; }

        public decimal Rate { get; set; }

        public int VendorId { get; set; }

        public string ImgUrl { get; set; }
    }
}
