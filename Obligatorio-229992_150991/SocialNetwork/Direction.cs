using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    public class Direction
    {

        private string _street;
        private string _city;
        private string _country;

        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Counrty { get; set; }


        public Direction()
        {
        }
        public Direction (string Country, string City, string Sreet)
        {
            this.SetDirection(Country, City, Sreet);
        }

        public void SetDirection(string Country, string City, string Sreet)
        {
            ValidNullOrEmptyCounrty(Country);
            ValidNullOrEmptyStreet(Sreet);
            ValidNullOrEmptyCity(City);
       
            this._country = Country;
            this._city = City;
            this._street = Sreet;
        }

        private void ValidNullOrEmptyStreet(String Street)
        {
            if (string.IsNullOrEmpty(Street))
            {
                throw new InvalidOperationException("El campo Calle no puede ser vacio o nullo");
            }
        }

        private void ValidNullOrEmptyCity(String City)
        {
            if (string.IsNullOrEmpty(City))
            {
                throw new InvalidOperationException("El campo Ciudad no puede ser vacio o nullo");
            }
        }

        private void ValidNullOrEmptyCounrty(String Counrty)
        {
            if (string.IsNullOrEmpty(Counrty))
            {
                throw new InvalidOperationException("El campo País no puede ser vacio o nullo");
            }
        }

        public override bool Equals(object obj)
        {
            Direction dirObj = obj as Direction;

            if (dirObj == null || this.GetType() != dirObj.GetType())
            {
                return false;
            }

            return Id == dirObj.Id ? true : false;
        }

    }
}
