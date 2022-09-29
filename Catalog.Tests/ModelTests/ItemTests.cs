using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Catalog.Models;

namespace Catalog.Tests
{

  [TestClass]
  public class PlaceTests : IDisposable
  {

    public void Dispose()
    {
      Place.ClearAll();
    }

    [TestMethod]
    public void PlaceCunstructor_CreatseInstanceOfPlace_Place()
    {
      Place newPlace = new Place("test");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }

    [TestMethod]
    public void AssignName_ReturnsName_String()
    {
      string destination = "Cancun";
      Place newPlace = new Place(destination);
      string result = newPlace.Destination;

      Assert.AreEqual(destination, result);
    }

    [TestMethod]
    public void GetAll_ReturnEmptyList_PlaceList()
    {
      List<Place> newList = new List<Place> {};
      List<Place> result = Place.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_AssignId_Int()
    {
      string destination = "Puerto Rico";
      Place newPlace = new Place(destination);

      int result = newPlace.Id;
      Assert.AreEqual(1, result);
    }    

    [TestMethod]
    public void Find_ReturnsCorrectPlace_Place()
    {
      string destination01 = "Puerto Rico";
      string destination02 = "Cancun";
      Place newPlace1 = new Place(destination01);
      Place newPlace2 = new Place(destination02);
      Place result = Place.Find(2);
      Assert.AreEqual(newPlace2, result); 
    }

  }
}