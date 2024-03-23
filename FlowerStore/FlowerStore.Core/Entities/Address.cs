using System;
namespace FlowerStore.Core.Entities
{
    public class Address : BaseEntity
    {
        public Address(int userId, string zipCode, string street, int number, string complement, string neighborhood, string city, string state)
        {
            UserId = userId;
            ZipCode = zipCode;
            Street = street;
            Number = number;
            Complement = complement;
            Neighborhood = neighborhood;
            City = city;
            State = state;
        }

        public int UserId { get; private set; }
        public string ZipCode { get; private set; }
        public string Street { get; private set; }
        public int Number { get; private set; }
        public string Complement { get; private set; }
        public string Neighborhood { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
    }
}

