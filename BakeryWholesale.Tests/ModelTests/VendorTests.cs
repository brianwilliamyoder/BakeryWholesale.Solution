using BakeryWholesale.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting; 
using System;
using System.Collections.Generic;


namespace BakeryWholesale.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }
    
    [TestMethod]
    public void VendorConstructor_CreateInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test Vendor", "new client");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription()
    {
      string description = "coffee shop";
      Vendor newVendor = new Vendor("Ronnie's", description);
      string result = newVendor.Description;
      Assert.AreEqual(result, description);
    }
    
    [TestMethod]
    public void GetId_ReturnId_Id()
    {
      Vendor newVendor = new Vendor("test Vendor", "new client");
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }
  }

}