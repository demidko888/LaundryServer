using Loundry.Models;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Helpers;
using System.Web.Mvc;

namespace Loundry.Controllers
{
    class HomeController : Controller
    {
        [HttpPost]
        public string PostTable(ApplicationContext application)
        {
            return null;
        }
            

    }
}
