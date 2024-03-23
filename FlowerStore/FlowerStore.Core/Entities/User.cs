using System;
namespace FlowerStore.Core.Entities
{
    public class User : BaseEntity
    {
        public string FullName { get; private set; }
        public string UserName { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string PhoneNumber { get; private set; }
        public List<Address> Addresses { get; private set; }

        public User(string fullName, string userName, string email, string password, string phoneNumber)
        {
            FullName = fullName;
            UserName = userName;
            Email = email;
            Password = password;
            PhoneNumber = phoneNumber;
            Addresses = new List<Address>();
        }
    }
}

