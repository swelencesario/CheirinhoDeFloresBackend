namespace FlowerStore.Application.ViewModel
{
    public class UserViewModel
    {
        public UserViewModel(string fullName, string username, string email, string phoneNumber)
        {
            FullName = fullName;
            Username = username;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public UserViewModel(int id, string fullName, string username, string email, string phoneNumber)
        {
            Id = id;
            FullName = fullName;
            Username = username;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}

