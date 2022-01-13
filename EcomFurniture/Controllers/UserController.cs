using EcomFurniture.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcomFurniture.Controllers
{
    [ApiController]
    [Route("[Controller]")]
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
        [HttpGet]
        [Route("Product/SearchByCategory")]
        public IEnumerable<Product> SortbyCategory(int id)
        {
            return obj.SortbyCategory(id);
        }
        [HttpGet]
        [Route("Product/SortByPriceDecending")]
        public IEnumerable<Product> PriceDecending()
        {
            return obj.PriceDescending();
        }
        [HttpGet]
        [Route("Product/SortByPriceAscending")]
        public IEnumerable<Product> PriceAscending()
        {
            return obj.PriceAscending();
        }
    }
}
