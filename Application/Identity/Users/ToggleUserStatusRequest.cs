﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Identity.Users
{
    public class ToggleUserStatusRequest
    {
        public bool ActivateUser { get; set; }
        public string? UserId { get; set; }
    }
}