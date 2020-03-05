using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebServices.Models;

namespace WebServices.Services
{
    public class ApiBeers : IApiBeers
    {
        public async Task<DataBeer> GetBeerInfo(string id)
        {
            const string url = "https://sandbox-api.brewerydb.com/v2/beer/";
            const string key = "/yeasts?key=0eca4558813950961ce12aec376f2517";
            HttpClient beer = new HttpClient();
            var result = await beer.GetStringAsync(url + id + key);
            return JsonConvert.DeserializeObject<DataBeer>(result);
        }
    }
}
