using BakeryWholesale.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting; 
using System;
using System.Collections.Generic;


namespace BakeryWholesale.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

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

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  
    [TestMethod]
    public void GetAll_ReturnsOrderList_OrderList()
    {
      Order newOrder1 = new Order("April Order", "Pastries", 300, "4/1/22");
      Order newOrder2 = new Order("March Order", "Bread", 5, "3/1/22");
      List<Order> newList = new List<Order> { newOrder1, newOrder2 }; 
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(result, newList);
    }

    [TestMethod]
    public void GetId_ItemAssignedId_Int()
    {
      Order newOrder1 = new Order("April Order", "Pastries", 300, "4/1/22");
      int result = newOrder1.Id;
      int comparison = 1;
      Assert.AreEqual(comparison, result);
    }

    [TestMethod]
    public void Find_ReturnsOrder_Order()
    {
      Order newOrder1 = new Order("April Order", "Pastries", 300, "4/1/22");
      Order newOrder2 = new Order("March Order", "Bread", 5, "3/1/22");
      Order result = newOrder1;
      Assert.AreEqual(newOrder1, newOrder2);
    }
  }
}