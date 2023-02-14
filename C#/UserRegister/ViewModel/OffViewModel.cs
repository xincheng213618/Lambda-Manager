using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace UserRegister.ViewModel
{

    public class Feature
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("code")]
        public string Code { get; set; }
        [JsonPropertyName("renewal_type")]
        public string RenewalType { get; set; }
    }






    public class OffLineViewModel
    {
        [JsonPropertyName("state")]
        public string State { get; set; }
        [JsonPropertyName("message")]
        public string Message { get; set; }
        [JsonPropertyName("user-class")]
        public string UserClass { get; set; }
        [JsonPropertyName("feature-list")]
        public List<Feature> FeatureList { get; set; }


    }
}
