using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitventure.Models
{
    public class Response
    {
        public string element { get; set; }
        public string regex { get; set; }
        public string identifier { get; set; }
    }

    public class Endpoint
    {
        public bool enabled { get; set; }
        public string resource { get; set; }
        public List<Response> response { get; set; }
    }

    public class Service
    {
        public string baseURL { get; set; }
        public bool enabled { get; set; }
        public List<Endpoint> endpoints { get; set; }
    }

    public class Root
    {
        public List<Service> services { get; set; }
    }
}
