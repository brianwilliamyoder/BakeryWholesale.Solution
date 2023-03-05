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

    [TestMethod]
    public void GetAll_ReturnsVendorList_VendorList()
    {
      Vendor newVendor1 = new Vendor("test Vendor", "new client");
      Vendor newVendor2 = new Vendor("test Vendor", "new client");
      List<Vendor> vendorList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(vendorList, result);
    }

    [TestMethod]
    public void Find_ReturnsVendorInstance_Vendor()
    {
      Vendor newVendor1 = new Vendor("test Vendor", "new client");
      Vendor newVendor2 = new Vendor("test Vendor", "new client");
      Vendor result = Vendor.Find(1);
      Assert.AreEqual(result, newVendor1);
    }

    [TestMethod]
    public void AddOrder_AddOrderToInstances_List()
    {
      DateTime date = new DateTime(2011, 1, 1);
      Order newOrder = new Order("may order", "pastries", 110, date);
      Vendor newVendor = new Vendor("Roy's", "Diner");
      List<Order> newList = new List<Order> { };
      newVendor.AddOrder(newOrder);
      CollectionAssert.AreEqual(newList, newVendor.Orders);
    }

  }

}