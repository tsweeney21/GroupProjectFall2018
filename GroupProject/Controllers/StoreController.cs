using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GroupProject.Controllers
{
    public class StoreController : Controller
    {
        // GET: /Store/
        public string Index()
        {
            return "Hello from the Store.Index()";
        }

        // GET: /Store/Browse
        public string Browse()
        {
            return "Hello from the Store.Browse()";
        }

        // GET: /Store/Details
        public string Details()
        {
            return "Hello from the Store.Details()";
        }
    }
}