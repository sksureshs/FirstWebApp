using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FirstWebApp.Models.Search
{
    public class SearchViewModel
    {
        public List<SearchPickupLocationViewModel> PickUpLocations { get; set; }

        public int SelectedLocationId { get; set; }

        //[DataType(DataType.DateTime)]
        //[DisplayFormat(DataFormatString = "yyyy-MM-dd HH:mm" , ApplyFormatInEditMode = true)]
        public DateTime FromTime { get; set; }

        //[DataType(DataType.DateTime)]
        //[DisplayFormat(DataFormatString = "yyyy-MM-dd HH:mm", ApplyFormatInEditMode = true)]
        public DateTime ToTime { get; set; }
    }
}
