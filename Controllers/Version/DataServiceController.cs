﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ServerAdmin.Controllers.Version
{
    public class DataServiceController : Controller
    {
        [HttpGet]
        public string Version()
        {
            return "0.0.0.0";
        }

        [HttpGet]
        public string BuildDate()
        {
            return DateTime.Now.ToString();
        }

        [HttpGet]
        public string HostIP()
        {
            return IPAddress.Loopback.ToString();
        }

        [HttpGet]
        public string DbVersion()
        {
            return "0.0.0.0";
        }

        [HttpGet]
        public string DbUpdateDate()
        {
            return DateTime.Now.ToString();
        }

        [HttpGet]
        public string DataLibBuildDate()
        {
            return DateTime.Now.ToString();
        }

        [HttpGet]
        public string DataLibVersion()
        {
            return "0.0.0.0";
        }
    }
}
