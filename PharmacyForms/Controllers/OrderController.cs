﻿using PharmacyForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyForms.Controllers
{
    public class OrderController
    {
        public bool Post(Order order)
        {
            var user = ContextStatic.PharmacyContext.Users.FirstOrDefault(i => i.Id == CurrentUserStatic.Id);
            var sale = SaleStatic.Sales.Select(l=>l);
            if (user != null) 
            {
                Order or = new Order();
                or.Sales = SaleStatic.Sales;
                or.User = user;
                or.DateSale = order.DateSale;
                ContextStatic.PharmacyContext.Orders.Add(or);
                ContextStatic.PharmacyContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
