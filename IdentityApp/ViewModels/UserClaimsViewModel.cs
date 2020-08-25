﻿using IdentityApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityApp.ViewModels
{
    public class UserClaimsViewModel
    {
        public string UserId { get; set; }
        public List<UserClaim> Claims { get; set; } = new List<UserClaim>();
    }
}
