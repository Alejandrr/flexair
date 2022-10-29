using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerShop.Data
{
   
    [Serializable]
    public class Address
    {

        public string Street { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public Address()
        {
            Country = City = Street = string.Empty;
        }
        public Address(string Street, string Country, string City)
        {
            this.Street = Street;
            this.Country = Country;
            this.City = City;
        }
        public string GetFullAddress()
        {
            return  Country +" М."+ City + " Вул."+ Street;
        }
        public void SetFullAddress(string full) {
            var a= full.Split('|');
            Country = a[0];City = a[1];Street = a[2];
        }
    }
}
