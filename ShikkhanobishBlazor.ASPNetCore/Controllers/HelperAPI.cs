﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ShikkhanobishBlazor.ASPNetCore.Controllers
{
    public class HelperAPI
    {
        public HttpClient Initial()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44350/");
            return client;
        }

    }
}
