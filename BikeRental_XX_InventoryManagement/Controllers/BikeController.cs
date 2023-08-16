using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;
using BikeRental_XX_InventoryManagement.Models;

namespace BikeRental_XX_InventoryManagement.Controllers
{
    public class BikeController : Controller
    {
        private static readonly HttpClient client;

    static BikeController()
    {
        client = new HttpClient() { };
        client.BaseAddress = new Uri("https://localhost:44354/api/bikedata/");
    }
    // GET: Bike/List
    public ActionResult List()
    {
        //objective
        //curl https://localhost:44354/api/bikedata/listbikes


        string url = "listbikes";

        HttpResponseMessage response = client.GetAsync(url).Result;

        Debug.WriteLine(response.StatusCode);

        IEnumerable<BikeDto> Bikes = response.Content.ReadAsAsync<IEnumerable<BikeDto>>().Result;

        return View(Bikes);
    }

    // GET: Bike/Details/5
    public ActionResult Details(int id)
    {
        //objective
        // curl https://localhost:44354/api/bikedata/findbike/{id}


        string url = "findbike/" + id;

        HttpResponseMessage response = client.GetAsync(url).Result;

        Debug.WriteLine(response.StatusCode);

        BikeDto SelectedBike = response.Content.ReadAsAsync<BikeDto>().Result;

        return View(SelectedBike);
    }

    // GET: Bike/New
    public ActionResult New()
    {
        return View();
    }

    // POST: Bike/Create
    [HttpPost]
    public ActionResult Create(Bikes bike)
    {
        string url = "AddBike";
        return RedirectToAction("List");
    }

    // GET: Bike/Edit/5
    public ActionResult Edit(int id)
    {
        return View();
    }

    // POST: Bike/Edit/5
    [HttpPost]
    public ActionResult Edit(int id, FormCollection collection)
    {
        try
        {
            // TODO: Add update logic here

            return RedirectToAction("Index");
        }
        catch
        {
            return View();
        }
    }

    // GET: Bike/Delete/5
    public ActionResult Delete(int id)
    {
        return View();
    }

    // POST: Bike/Delete/5
    [HttpPost]
    public ActionResult Delete(int id, FormCollection collection)
    {
        try
        {
            // TODO: Add delete logic here

            return RedirectToAction("Index");
        }
        catch
        {
            return View();
        }
    }
}
}