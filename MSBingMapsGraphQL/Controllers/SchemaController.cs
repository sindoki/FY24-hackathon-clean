using Microsoft.AspNetCore.Mvc;

namespace MSBingMapsGraphQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchemaController : Controller
    {
        [HttpGet]
        public string Get()
        {
            return @"schema {
  query: RestaurantQuery
}

type RestaurantQuery {
  restaurant(name: String): Restaurant!
}

type Restaurant {
  menu: [MenuItem!]!
  name: String!
  ratingAvg: Float!
  reviewCount: Int!
  amenities: [String!]!
}

type MenuItem {
  itemType: String!
  title: String!
  description: String!
  priceUSD: Decimal!
}
";
        }
    }
}
