using MSBingMapsGraphQL.DataModel;
using MSBingMapsGraphQL.Storage;

namespace MSBingMapsGraphQL.Queries
{
    public class RestaurantQuery
    {
        public IEnumerable<Restaurant> GetRestaurants() =>
            RestaurantStorage.GetRestaurants();

        public Restaurant GetRestaurant(string name = null) =>
            RestaurantStorage.GetRestaurants(name).FirstOrDefault() ?? new Restaurant();
    }
}
