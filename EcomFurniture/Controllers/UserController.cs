using EcomFurniture.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcomFurniture.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        UserAccessLayer obj = new UserAccessLayer();
        [HttpGet]
        [Route("Product/GetAllProduct")]
        public IEnumerable<Product> Get()
        {
            return obj.GetAllProduct();
        }
        [HttpGet]
        [Route("api/GetAllOrders")]
        public IEnumerable<Custorder> GetAllOrders(int id)
        {
            return obj.GetAllOrders(id);
        }
        [HttpPut]
        [Route("update/customerdetails")]
        public int Edit([FromBody] User user)
        {
            return obj.UpdateUser(user);
        }
        [HttpPost]
        [Route("Order/PlaceOrder")]
        public int Create([FromBody] Custorder order)
        {
            return obj.AddOrder(order);
        }
        [HttpPost]
        [Route("User/RegisterUser")]
        public int Create([FromBody] User user)
        {
            return obj.AddUser(user);
        }
       
    }
}
