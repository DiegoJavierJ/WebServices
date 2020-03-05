using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebServices.Models;

namespace WebServices.Services
{
    public interface IApiBeers
    {
        Task<DataBeer> GetBeerInfo(string id);
    }
}
