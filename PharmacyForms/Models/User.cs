﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PhamacyLibrary.Models
{
    public class User
    {
        [Key] public int Id { get; set; }
        [MaxLength(25)] [MinLength(8)] public string Login { get; set; }
        [MaxLength(20)] [MinLength(8)] public string Password { get; set; }
        [Required] public Roles Role { get; set; } = Roles.Guest;
        public List<Order> Orders { get; set; }
    }
    public enum Roles
    {
        Guest,
        Client,
        Stuff,
        Director,
        Admin
    }
}