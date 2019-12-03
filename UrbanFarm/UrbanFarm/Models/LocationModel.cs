using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UrbanFarm.Models
{
    public class LocationModel
    {
        public string StreetAddress { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string State { get; set;}
    }
}