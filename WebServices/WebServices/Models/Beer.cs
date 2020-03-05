using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WebServices.Models
{
    public class Beer
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("categoryDisplay")]
        public string CategoryDisplay { get; set; }

        [JsonProperty("createDate")]
        public string CreateDate { get; set; }


    }
}
