using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging.Abstractions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using WebYugiohCardApplication.Models;

namespace WebYugiohCardApplication.Controllers
{
    public class CardController : Controller
    {
        // GET: Card
        public ActionResult Index(string search, string race, string type)
        {
            ApiResponse model = new ApiResponse();
            if (search == null && race == null && type == null)
            {
                return View(model);
            }
            var uri = new Uri("https://db.ygoprodeck.com/api/v7/cardinfo.php");
            using (var client = new HttpClient())
            {
                try
                {
                    var builder = new UriBuilder(uri);
                    var query = HttpUtility.ParseQueryString(builder.Query);
                    if (!(race == "All Races"))
                    {
                        query["race"] = race;
                    }
                    if (!(type == "All Types"))
                    {
                        query["type"] = type;
                    }
                    if (!String.IsNullOrEmpty(search))
                    {  
                        query["fname"] = search; 
                    }
                    builder.Query = query.ToString();
                    string url = builder.ToString();
                    uri = new Uri(url);

                    HttpResponseMessage result = client.GetAsync(uri).Result;
                    var response = result.Content.ReadAsStringAsync().Result;
                    if (result.IsSuccessStatusCode)
                    {
                        model = JsonConvert.DeserializeObject<ApiResponse>(response);
                    }

                }
                catch (Exception ex)
                {
                    return View(ex.Message);
                }
            }
            ViewData["race"] = race;
            ViewData["type"] = type;
            return View(model);
        }

        public ActionResult Detail()
        {
            int cardId = 46986414;
            ApiResponse model = new ApiResponse();
            var uri = new Uri("https://db.ygoprodeck.com/api/v7/cardinfo.php");
            using (var client = new HttpClient())
            {
                try
                {
                    var builder = new UriBuilder(uri);
                    var query = HttpUtility.ParseQueryString(builder.Query);
                    query["id"] = cardId.ToString();
                    builder.Query = query.ToString();
                    string url = builder.ToString();
                    uri = new Uri(url);

                    HttpResponseMessage result = client.GetAsync(uri).Result;
                    var response = result.Content.ReadAsStringAsync().Result;
                    if (result.IsSuccessStatusCode)
                    {
                        model = JsonConvert.DeserializeObject<ApiResponse>(response);
                    }

                }
                catch (Exception ex)
                {
                    return View(ex.Message);
                }
            }
            return View(model.data.FirstOrDefault());
        }
    }
}
