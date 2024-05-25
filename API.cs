using FoodStore.Models;
using Newtonsoft.Json;
using RestSharp;

namespace FoodStore
{
    public class API
    {
        RestClient client;
        public API()
        {
            var options = new RestClientOptions("https://api.spoonacular.com");
            client = new RestClient(options);
        }
        public async Task<GroceryProduct> GetGroceryProduct(string id)
        {
            var request = new RestRequest($"/food/products/{id}");
            request.AddParameter("apiKey", "2a263ac8f97243448ca4a2a7539effc9");
            var requestDeserialized = await client.GetAsync<GroceryProduct>(request);
            return requestDeserialized;
        }
        public async Task<SearchGroceryProductsModel> GetSearchGroceryProducts(string search)
        {
            var request = new RestRequest($"/food/products/search?query={search}");
            request.AddParameter("apiKey", "2a263ac8f97243448ca4a2a7539effc9");
            var requestDeserialized = await client.GetAsync<SearchGroceryProductsModel>(request);
            return requestDeserialized;
        }
    }
}
