﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkWithModel.ViewModels
{
    public class UserViewModel
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}