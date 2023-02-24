using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using BakeryWholesale.Models;

namespace BakeryWholesale.Controllers

{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);

    }
  }
}