using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcomFurniture.Models
{
    public class AdminDataAccessLayer
    {
        FurEcomContext db = new FurEcomContext();
        // To get all Product 
        public IEnumerable<Product> GetAllProduct()
        {
            try
            {
                return db.Products.ToList();
            }
            catch
            {
                throw;
            }
        }
        // To add product in product table 
        public int AddProduct(Product product)
        {
            try
            {
                db.Products.Add(product);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }
        // To get a product by product Id
        public Product GetProductByID(int id)
        {
            try
            {
                Product product = db.Products.Find(id);
                return product;
            }
            catch
            {
                throw;
            }
        }
        // To delete a particular product
        public int Deleteproduct(int id)
        { 
            try
            {
                Product product = db.Products.Find(id);
                db.Products.Remove(product);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }
        //To Update particular product 
        public int UpdateProduct(Product product)
        {
            try
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }
        //To get all users
        public IEnumerable<User> GetAllUser()
        {
            try
            {
                return db.Users.ToList();
            }
            catch
            {
                throw;
            }
        }
        //To get all Orders
        public IEnumerable<Custorder> GetAllOrders()
        {
            try
            {
                return db.Custorders.ToList();
            }
            catch
            {
                throw;
            }
        }
        // To update Orders
        public int UpdateOrder(Custorder order)
        {
            try
            {
                db.Entry(order).State = EntityState.Modified;
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }
        //To delete particular user 
        public int DeleteUser(int id)
        {
            try
            {
                User user = db.Users.Find(id);
                db.Users.Remove(user);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }
        //To delete particular order 
        public int DeleteOrder(int id)
        {
            try
            {
                Custorder order = db.Custorders.Find(id);
                db.Custorders.Remove(order);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }
        //Toget the user details by Id
        public User GetUserByID(int id)
        {
            try
            {
                User user = db.Users.Find(id);
                return user;
            }
            catch
            {
                throw;
            }
        }
        //To get The orderlist of particular user.
        public IEnumerable<Custorder> GetOrderbyUserId(int id)
        {
            try
            {
                return db.Custorders.Where(o => o.UId == id).ToList();
            }
            catch
            {
                throw;
            }
        }
    }
}
