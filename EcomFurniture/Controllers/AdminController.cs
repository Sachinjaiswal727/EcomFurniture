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
    public class AdminController : Controller
    {
        AdminDataAccessLayer obj = new AdminDataAccessLayer();
        [HttpGet]
        [Route("Product/GetAllProduct")]
        public IEnumerable<Product> GetAllProduct()
        {
            return obj.GetAllProduct();
        }
        [HttpPost]
        [Route("Product/AddProduct")]
        public int Create([FromBody] Product product)
        {
            return obj.AddProduct(product);
        }
        [HttpGet]
        [Route("product/ProductById/{id}")]
        public Product ProductById(int id)
        {
            return obj.GetProductByID(id);
        }
        [HttpPut]
        [Route("Product/update")]
        public int Edit([FromBody] Product product)
        {
            return obj.UpdateProduct(product);
        }
        [HttpDelete]
        [Route("Product/DeleteProduct/{id}")]
        public int Delete(int id)
        {
            return obj.Deleteproduct(id);
        }
        [HttpGet]
        [Route("User/GetAllUsers")]
        public IEnumerable<User> GetAllUser()
        {
            return obj.GetAllUser();
        }
        [HttpGet]
        [Route("Orders/GetAllorders")]
        public IEnumerable<Custorder> GetAllOrders()
        {
            return obj.GetAllOrders();
        }
        [HttpPut]
        [Route("Orders/update")]
        public int Edit([FromBody] Custorder order)
        {
            return obj.UpdateOrder(order);
        }
        [HttpDelete]
        [Route("user/Deleteuser/{id}")]
        public int DeleteUser(int id)
        {
            return obj.DeleteUser(id);
        }
        [HttpDelete]
        [Route("user/DeleteOrder/{id}")]
        public int DeleteOrder(int id)
        {
            return obj.DeleteUser(id);
        }
        [HttpGet]
        [Route("User/UserById/{id}")]
        public User GetUserByID(int id)
        {
            return obj.GetUserByID(id);
        }
        [HttpGet]
        [Route("Order/GetAllOrderofUserById/{id}")]
        public IEnumerable<Custorder> GetAllOrders(int id)
        {
            return obj.GetOrderbyUserId(id);
        }
    }
}

