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
        public async Task<ActionResult> IndexAsync(string search)
        {
            ApiResponse model = new ApiResponse();
            var uri = new Uri("https://db.ygoprodeck.com/api/v7/cardinfo.php");
            using (var client = new HttpClient())
            {
                try
                {
                    if (!String.IsNullOrEmpty(search))
                    {
                        var builder = new UriBuilder(uri);
                        var query = HttpUtility.ParseQueryString(builder.Query);
                        query["fname"] = search;
                        builder.Query = query.ToString();
                        string url = builder.ToString();
                        uri = new Uri(url);
                    }
                    HttpResponseMessage result = await client.GetAsync(uri);
                    var response = await result.Content.ReadAsStringAsync();
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
            return View(model);
        }
    }
}
