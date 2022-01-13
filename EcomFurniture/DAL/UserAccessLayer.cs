﻿using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcomFurniture.Models
{
    public class UserAccessLayer
    {
        FurEcomContext db = new FurEcomContext();
        // To get List of all Product
        public IEnumerable<Product> GetAllProduct()
        {
            try
            {
                var product=  db.Products.ToList();
                return product;
            }
            catch
            {
                throw;
            }
        }
        //To place new order.
        public int AddOrder(Custorder order)
        {
            try
            {
                db.Custorders.Add(order);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }
        //To get all order of customer
        public IEnumerable<Custorder> GetAllOrders( int id )
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
        //To update user details.
        public int UpdateUser(User user)
        {
            try
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }
        //To register New User
        public int AddUser(User user)
        {
            try
            {
                db.Users.Add(user);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }
        //To sort the product by category
        public IEnumerable<Product> SortbyCategory(int id)
        {
            try
            {
                 return db.Products.Where(o => o.PCategory == id).ToList();
            }
             catch
            {
                throw;
            }
        }
        //To sort product by price in Descending
        public IEnumerable<Product> PriceDescending()
        {
            try
            {
                return db.Products.OrderByDescending(p=>p.PPrice).ToList();
            }
            catch
            {
                throw;
            }
        }
        //To sort product by price Ascending
        public IEnumerable<Product> PriceAscending()
        {
            try
            {
                return db.Products.OrderBy(p => p.PPrice).ToList();
            }
            catch
            {
                throw;
            }
        }
    }
}
