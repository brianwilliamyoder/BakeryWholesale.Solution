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

  private DateTime _firstTestDate;
  private DateTime _secondTestDate;
  private Order _firstOrder;
  private Order _secondOrder;
  
  
    [TestInitialize]
    public void Initialize()
    {
      _firstTestDate = new DateTime(2023, 4, 5);
      _secondTestDate = new DateTime(2023, 5, 13);
      _firstOrder = new Order ("May order", "5 loaves", 15, _firstTestDate);
      _secondOrder = new Order("April Order", "Pastries", 300, _secondTestDate);
    }


    [TestMethod]
    public void OrderConstructor_CreateInstanceOfOrder_Order()
    {
      Assert.AreEqual(typeof(Order), _firstOrder.GetType());
    }

    [TestMethod]
    public void OrderConstructor_ReturnsTitle_String()
    {
      String title = new String("May order");
      Assert.AreEqual(title, _firstOrder.Title);
      
    }

    [TestMethod]
    public void GetAll_ReturnsList_OrderList()
    {
      List<Order> newList = new List<Order> {_firstOrder, _secondOrder};
      List<Order> result = Order.GetAll();
      Console.WriteLine(newList);
      CollectionAssert.AreEqual(newList, result);
    }


    [TestMethod]
    public void GetId_ItemAssignedId_Int()
    {
      int comparison = 1;
      Assert.AreEqual(comparison, _firstOrder.Id);
    }

    [TestMethod]
    public void Find_ReturnsOrder_Order()
    {
      Order result = Order.Find(2);
      Assert.AreEqual(result, _secondOrder);
    } 
  }
}