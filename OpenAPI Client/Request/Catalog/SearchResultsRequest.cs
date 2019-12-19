using Bol.OpenAPI.Request.Common;
using Newtonsoft.Json;
using System;

namespace Bol.OpenAPI.Request.Catalog
{
    public class SearchResultsRequest
    {
        public SearchResultsRequest() { }

        [JsonProperty("q")]
        public string Query { get; set; }

        [JsonProperty("pids")]
        public string ProductIds { get; set; }

        [JsonProperty("ids")]
        public string CategoryId { get; set; }

        [JsonProperty("ids")]
        public string[] RefinementIds { get; set; }

        public string ListId { get; set; }

        [JsonProperty("searchfield")]
        public EnumTypes.FieldType? Field { get; set; }

        public Boolean? IncludeAttributes { get; set; }
        public EnumTypes.DataOutputType[] DataOutputs { get; set; }
        public EnumTypes.OfferType[] Offers { get; set; }
        public EnumTypes.SortingMethod? Sort { get; set; }
        public Int64? Offset { get; set; }        
        public Int32? Limit { get; set; }       
    }
}
