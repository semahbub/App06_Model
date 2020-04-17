using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App06_Model.Models;
using Microsoft.AspNetCore.Mvc;

namespace App06_Model.Controllers
{
    public class DataController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult show([FromQuery] string mytext, int num)
        {
            if(!string.IsNullOrEmpty(mytext) && num > 0)
            {
                ViewBag.text = mytext;
                ViewBag.num = num;
                return View();
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        public IActionResult Student(int roll, string stdname, string univ, string dept,  string academicyear)
        {
            if (!string.IsNullOrEmpty(stdname) && roll > 1900)
            {
                ViewBag.text = stdname; 
                ViewBag.num = roll;
                return View();
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        public IActionResult ShowProduct()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult ShowProduct(int Id, string Name, string MUnit, double UnitPrice, double Quantity)
        //{
        //    string msg = "";
        //    if (Id <= 0)
        //    {
        //        msg = "Product Id could not be Zero or Negative";
        //    }

        //    if (string.IsNullOrEmpty(Name))
        //    {
        //        msg += "Product Name must be provided";
        //    }

        //    if (string.IsNullOrEmpty(MUnit))
        //    {
        //        msg += "Product Name must be provided";
        //    }
        //    if (UnitPrice <= 0)
        //    {
        //        msg += "Product UnitPrice could not be Zero or Negative";
        //    }
        //    if (Quantity <= 0)
        //    {
        //        msg += "Product Quantity could not be Zero or Negative";
        //    }

        //    if (msg.Trim().Length > 0)
        //    {
        //        ViewBag.Err = msg;
        //        return View("ShowProduct");
        //    }
        //    else
        //    {
        //        Product p = new Product();
        //        p.Id = Id;
        //        p.Name = Name;
        //        p.MUnit = MUnit;
        //        p.UnitPrice = UnitPrice;
        //        p.Quantity = Quantity;

        //        return View("Product", p);
        //    }
        //}

        [HttpPost]
        public IActionResult ShowProduct(Product prod)
        {
            if (ModelState.IsValid)
            {
                return View("Product", prod);
            }
            else
            {
                ViewBag.Err = "Product Information is not valid.";
                return View("ShowProduct");
            }
        }

        public IActionResult Product()
        {
            return View();
        }
    }
}