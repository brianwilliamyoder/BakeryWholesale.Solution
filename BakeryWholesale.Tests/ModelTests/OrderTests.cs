using BakeryWholesale.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting; 
using System;
using System.Collections.Generic;


namespace BakeryWholesale.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreateInstanceOfOrder_Order()
    {
      Order newOrder = new Order("May order", "5 loaves", 15, "5/1/22");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void OrderConstructor_ReturnsTitle_String()
    {
      string title = "May Order";
      Order newOrder = new Order (title, "Bread, 5 loaves", 15, "5/1/22" );
      Assert.AreEqual(title, newOrder.Title);
      

    }
  }
}