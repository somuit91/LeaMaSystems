﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LeamaSystems.Web.CustomModels
{
    public class LoginModel
    {
        [Required(ErrorMessage = "User Name is required")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}