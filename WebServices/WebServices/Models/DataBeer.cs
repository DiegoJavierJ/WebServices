using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WebServices.Models
{
    public class DataBeer : INotifyPropertyChanged
    {
        [JsonProperty("data")]
        public IList<Beer> Data { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
