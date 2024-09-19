using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Model
{
    public class CommonApi
    {
        public HttpStatusCode StatusCode { get; set; }
        public dynamic? Data { get; set; }
        public string Message { get; set; }
    }
}
