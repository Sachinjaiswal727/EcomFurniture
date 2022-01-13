using EcomFurniture.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcomFurniture.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class HomeController : Controller
    {
        HomeBLL obj = new HomeBLL();
        [HttpGet]
        [Route("Home/CheckUser/login")]
        public JsonResult CheckUser(string email,string password)
        {
            bool userType = obj.Checkusertype(email, password);

            return Json(userType);
        }
    }
}
