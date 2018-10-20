using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using TheRichLifeTestProject.Models;
using TheRichLifeTestProject.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace TheRichLifeTestProject.Classes
{
    public class ShoppingCart
    {
        public static readonly ShoppingCart InstanceCart;
        static ShoppingCart()
        {
           
        }
    }
}
