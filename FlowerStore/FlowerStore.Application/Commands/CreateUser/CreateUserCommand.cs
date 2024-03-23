﻿using MediatR;
namespace FlowerStore.Application.Commands
{
    public class CreateUserCommand : IRequest<int>
    {
        //public int Id { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
    }
}

