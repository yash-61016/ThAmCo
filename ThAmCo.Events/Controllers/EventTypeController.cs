using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ThAmCo.Events.DTOs;

namespace ThAmCo.Events.Controllers
{
    public class EventTypeController : Controller
    {
        HttpClient client; 
        public EventTypeController()
        {
            client = new HttpClient();
            client.BaseAddress = new System.Uri("https://localhost:44352/");
            client.DefaultRequestHeaders.Accept.ParseAdd("application/json");
        }
        // GET: EventTypeDTOController
        public async Task<ActionResult> Index()
        {
            IEnumerable<EventTypeDTO> eventTypes = new List<EventTypeDTO>();

            HttpResponseMessage response = await client.GetAsync("api/eventtypes");
            if (response.IsSuccessStatusCode)
            {
                eventTypes = await response.Content.ReadAsAsync<IEnumerable<EventTypeDTO>>();
            }
            else
            {
                Debug.WriteLine("Index received a bad response from the web service.");
            }
            return View(eventTypes.ToList());
        }

        // GET: EventTypeDTOController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EventTypeDTOController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EventTypeDTOController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EventTypeDTOController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EventTypeDTOController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EventTypeDTOController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EventTypeDTOController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
