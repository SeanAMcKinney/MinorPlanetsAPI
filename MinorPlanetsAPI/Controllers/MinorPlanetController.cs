using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using MinorPlanetsAPI.Models;

namespace MinorPlanetsAPI.Controllers
{
    public class MinorPlanetController : Controller
    {
        // GET: MinorPlanet
        public async Task<ActionResult> Index()
        {
            List<AstroidEsentialInfo> astroidInfo = new List<AstroidEsentialInfo>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(@"http://www.asterank.com/api/");
                client.DefaultRequestHeaders.Clear();
                HttpResponseMessage response = await client.GetAsync("mpc");

                if (response.IsSuccessStatusCode)
                {
                    var astroidInfoResponse = response.Content.ReadAsStringAsync().Result;

                    astroidInfo = JsonConvert.DeserializeObject<List<AstroidEsentialInfo>>(astroidInfoResponse);
                }
            }
            return View(astroidInfo);
        }
    }
}