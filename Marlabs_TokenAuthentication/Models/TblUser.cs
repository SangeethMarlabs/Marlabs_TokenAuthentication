﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Marlabs_TokenAuthentication.Models
{
    public partial class TblUser
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
