﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetCore.Models
{
    [Table("AdminLogin")]
    public class Admin
    {
        public int Id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}