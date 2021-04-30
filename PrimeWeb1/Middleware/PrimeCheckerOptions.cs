using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeWeb1.Middleware
{
    public class PrimeCheckerOptions
    {
        public PathString Path { get; set; }
    }
}
