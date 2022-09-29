using System.Collections.Generic;

namespace Catalog.Models
{
  public class Place
  {
    public string Destination { get; set; }
    public int Id { get; }
    private static List<Place> _instances = new List<Place> {};

    private static List<Food> _instancesFood = new List<Food> {};

    public Place(string destination)
    {
     Destination = destination;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Place> GetAll()
    {
      return _instances;
    }

    public static Place Find(int searchID)
    {
      return _instances[searchID-1];
    }

  }
}