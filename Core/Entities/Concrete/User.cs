﻿using Core.Entities;

namespace Core.Entities.Concrete
{
    public class User:IEntity
    {
        public long Id { get; set; }
        public short RoleId { get; set; }
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }
        public string? UserName { get; set; }
        public string? Mobile { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public bool Status { get; set; }
        public string? Intro { get; set; }
        public string? Profile { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}