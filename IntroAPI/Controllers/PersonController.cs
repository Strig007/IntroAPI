using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IntroAPI.Controllers
{
    public class PersonController : ApiController
    {
        public List<string> GetNames()
        {
            List<string> names = new List<string>();
            names.Add("Strig");
            names.Add("Akash");
            names.Add("Hans");

            return names;
        }

        public string GetId(int id)
        {
            return "ID " + id;
        }
    }
}
