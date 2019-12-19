using Bol.OpenAPI.Client;
using Bol.OpenAPI.Request.Catalog;
using Bol.OpenAPI.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenAPI_Client_Standard.Extensions
{
    public static class OpenApiClientExtensions
    {
        public static Task<SearchResults> Search(this IOpenApiClient client, SearchResultsRequest request, string apikey) =>
            client.Search(apikey,
                       query: request.Query,
                       productIds: request.ProductIds?.Split(','),
                       refinementIds: request.RefinementIds,
                       listId: request.ListId,
                       searchField: request.Field == null ? null : EnumUtils.StringValueOf(request.Field),
                       includeAttributes: request.IncludeAttributes,
                       dataOutput: request.DataOutputs?.Select(x => EnumUtils.StringValueOf(x)).ToArray(),
                       offers: request.Offers?.Select(x => EnumUtils.StringValueOf(x)).ToArray(),
                       sort: request.Sort == null ? null : EnumUtils.StringValueOf(request.Sort),
                       offset: request.Offset,
                       limit: request.Limit
                       );

        public static Task<ProductList> GetProducts(this IOpenApiClient client, ProductsRequest request, string apikey)
            => client.GetProducts(request, string.Join(",", request.Ids), apikey);
    }
}
