﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Extensions.Configuration;


namespace WebUI.Services
{
    public class AuthMessageSenderOptions
    { 
        public string SendGridUser { get; set; }
        public string SendGridKey { get; set; }
    }
}
