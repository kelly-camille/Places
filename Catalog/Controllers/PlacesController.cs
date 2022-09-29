using Microsoft.AspNetCore.Mvc;
using Catalog.Models;
using System.Collections.Generic;

namespace Catalog.Controllers
{

  public class PlacesController : Controller
  {

    [HttpGet("/places")]
    public ActionResult Index()
    {
      List<Place> allPlaces = Place.GetAll();
      return View(allPlaces);
    }

    [HttpGet("/places/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/places")]
    public ActionResult Create(string destination)
    {
      Place myPlace = new Place(destination);
      return RedirectToAction("Index");
    }

    [HttpPost("/places/delete")]
    public ActionResult Delete()
    {
      Place.ClearAll();
      return View();
    }

    [HttpGet("/places/{id}")]
    public ActionResult Show(int id)
    {
      Place foundPlace = Place.Find(id);
      return View(foundPlace);
    }

  }
}