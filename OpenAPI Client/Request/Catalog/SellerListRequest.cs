using Bol.OpenAPI.Request.Common;
using System;

namespace Bol.OpenAPI.Request.Catalog
{
    public class SellerListRequest
    {
        public SellerListRequest() { }

        public string Id { get; set; }
        public Boolean? IncludeAttributes { get; set; }
        public EnumTypes.SortingMethod? Sort { get; set; }
        public Int64? Offset { get; set; }
        public Int32? Limit { get; set; }       
    }
}
