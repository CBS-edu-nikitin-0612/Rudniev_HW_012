using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace additionalTask
{
    internal class Address
    {
        private string index, country, city, street, house;
        private ushort apartment;

        public string Index { get => index; set => index = value; }
        public string Country { get => country; set => country = value; }
        public string City { get => city; set => city = value; }
        public string Street { get => street; set => street = value; }
        public string House { get => house; set => house = value; }
        public ushort Apartment
        {
            get
            {
                return apartment;
            }
            set 
            {
                apartment = (ushort)(value > 0 ? value : 1);
            }
        }
    }
}
