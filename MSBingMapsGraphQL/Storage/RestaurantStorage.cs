using MSBingMapsGraphQL.DataModel;

namespace MSBingMapsGraphQL.Storage
{
    public class RestaurantStorage
    {
        private static Restaurant[] AllRestaurants = {
            new Restaurant
            {
                Name = "Luke's Lobster Pike Street",
                Address = "110 Pike St, Seattle, WA 98101",
                RatingAvg = 4.5f,
                ReviewCount = 6,
                OpenHours = new List<DaySchedule>
                {
                    new DaySchedule { DayOfWeek = DayOfWeek.Monday, StartTime = new TimeOnly(11, 0), EndTime = new TimeOnly(20, 0) },
                    new DaySchedule { DayOfWeek = DayOfWeek.Tuesday, StartTime = new TimeOnly(11, 0), EndTime = new TimeOnly(20, 0) },
                    new DaySchedule { DayOfWeek = DayOfWeek.Wednesday, StartTime = new TimeOnly(11, 0), EndTime = new TimeOnly(20, 0) },
                    new DaySchedule { DayOfWeek = DayOfWeek.Thursday, StartTime = new TimeOnly(11, 0), EndTime = new TimeOnly(21, 0) },
                    new DaySchedule { DayOfWeek = DayOfWeek.Friday, StartTime = new TimeOnly(11, 0), EndTime = new TimeOnly(21, 0) },
                    new DaySchedule { DayOfWeek = DayOfWeek.Saturday, StartTime = new TimeOnly(11, 0), EndTime = new TimeOnly(21, 0) },
                    new DaySchedule { DayOfWeek = DayOfWeek.Sunday, StartTime = new TimeOnly(11, 0), EndTime = new TimeOnly(21, 0) }
                },
                Amenities = new List<string>
                {
                    "Delivery",
                    "Good for kids"
                },
                Reviews = new List<Review>
                {
                    // Only English language reviews included
                    new Review { PostedAt = new DateTime(2023, 8, 23), Rating = 5, Content = "Fast, friendly service. Visited with friends, stumbled upon this little gem as w e were wandering around Pike Market. Fast friendly service, and the Lobster Mac and Cheese was yummie." },
                    new Review { PostedAt = new DateTime(2023, 8, 13), Rating = 5, Content = "After flying over 5 hours from the east coast, we dropped off our bags at our hotel and headed out in search of a quick lunch. We stopped at Luke's lobster shack. Boy are we glad we did. We got a 6 inch lobster roll, dungeness crab roll, and a Jonah crab roll. All three were amazingly delicious. Lobster was sweet and tender. Crab was yummy and rolls were fresh. Perfect first meal in Seattle." },
                    new Review { PostedAt = new DateTime(2023, 7, 12), Rating = 5, Content = "So good! We got the lobster roll and the crab roll. Both were good but we preferred the crab roll more. Would definitely get both again!" },
                    new Review { PostedAt = new DateTime(2023, 2, 23), Rating = 5, Content = "Stopped in for a quick lunch and ordered the trio. Each one was delicious. The poppy coleslaw was nice as well. Great staff and atmosphere. Will definitely go back." }
                },
                Menu = new List<MenuItem>()
            },
            new Restaurant
            {
                Name = "Taylor Shellfish Oyster Bar",
                Address = "1521 Melrose Ave, Seattle, WA 98122",
                RatingAvg = 4.5f,
                ReviewCount = 185,
                OpenHours = new List<DaySchedule>
                {
                    new DaySchedule { DayOfWeek = DayOfWeek.Monday, StartTime = new TimeOnly(12, 0), EndTime = new TimeOnly(20, 0) },
                    new DaySchedule { DayOfWeek = DayOfWeek.Tuesday, StartTime = new TimeOnly(12, 0), EndTime = new TimeOnly(20, 0) },
                    new DaySchedule { DayOfWeek = DayOfWeek.Wednesday, StartTime = new TimeOnly(12, 0), EndTime = new TimeOnly(20, 0) },
                    new DaySchedule { DayOfWeek = DayOfWeek.Thursday, StartTime = new TimeOnly(12, 0), EndTime = new TimeOnly(20, 0) },
                    new DaySchedule { DayOfWeek = DayOfWeek.Friday, StartTime = new TimeOnly(12, 0), EndTime = new TimeOnly(22, 0) },
                    new DaySchedule { DayOfWeek = DayOfWeek.Saturday, StartTime = new TimeOnly(12, 0), EndTime = new TimeOnly(22, 0) },
                    new DaySchedule { DayOfWeek = DayOfWeek.Sunday, StartTime = new TimeOnly(12, 0), EndTime = new TimeOnly(20, 0) }
                },
                Amenities = new List<string>
                {
                    "Outdoor seating",
                    "Live music",
                    "Happy hour",
                    "Table service",
                    "Accepts reservations",
                    "Accessible"
                },
                Reviews = new List<Review>
                {
                    new Review { PostedAt = new DateTime(2023, 6, 28), Rating = 5, Content = "This small, casual place has the freshest oysters and delicious side dishes. The service was friendly and we only waited a few minutes for a table on a Tuesday night. Nice wines from Europe that pair well with the food. There is no dessert so we had more of our favorite oysters instead of dessert! Would definitely come here again for the home made Caesar salad, marinated olives, asparagus, and the shining stars of the meal -- oysters!\r\n\r\nhttps://www.tripadvisor.com/ShowUserReviews-g60878-d3297255-r898711699-Taylor_Shellfish_Oyster_Bar-Seattle_Washington.html#" },
                    new Review { PostedAt = new DateTime(2023, 5, 31), Rating = 2, Content = "They need all new staff.. If youre going to spend 100-150 a person go somewhere else. I sat for 30+ minutes begging a waiter for a water and then the horrible service continued. I was from out of town and was so committed to oysters and clams that i took their crap.\r\n\r\nI got some clams in white wine sauce and clearly in a small room with a few staff again coulnt get a moment or glance from one of them. I wanted bread the whole time and raised my hand 10 times and eventually at the end of the entire meal he said, hey you want some bread with that.. NO SH..\r\n\r\nhttps://www.tripadvisor.com/ShowUserReviews-g60878-d3297255-r892898862-Taylor_Shellfish_Oyster_Bar-Seattle_Washington.html#" },
                    new Review { PostedAt = new DateTime(2023, 4, 25), Rating = 5, Content = "We ordered a lot of delicious oysters in this restaurant in Seattle. Food is really good and the staff is very friendly (thanks, Mary and Luis). We had a great time." }
                },
                Menu = new List<MenuItem>
                {
                    new MenuItem { ItemType = "Oysters", Title = "Salish Sampler", PriceUSD = 130, Description = "A Shucker's Dozen, 1/2 Dungeness Crab, Geoduck Sashimi, Can of Smoked Oysters, Rockfish Ceviche, Cocktail Prawns" },
                    new MenuItem { ItemType = "Oysters", Title = "Shucker's Dozen", PriceUSD = 42, Description = "A Dozen Curated Oysters Direct From Taylor's Own Farms" },
                    new MenuItem { ItemType = "Oysters", Title = "Lummi Island Ikura", PriceUSD = 4, Description = "A Teaspoon of Local Salmon Roe" },
                    new MenuItem { ItemType = "Kitchen", Title = "Bay Shrimp Roll", PriceUSD = 19, Description = "Fresh NW Bay Shrimp Salad, Green Goddess Dressing, Green Onion, Picked Fresno Chili, Toasted Brioche Roll, Kettle Chips" },
                    new MenuItem { ItemType = "Still Wine", Title = "2012 By. Ott Rose", PriceUSD = 14, Description = "Cotes de Provence, FR" },
                    new MenuItem { ItemType = "Still Wine", Title = "2021 Walter Scott \"Cuvee Anne\" Chardonnay", PriceUSD = 18, Description = "Willamette Valley, OR" }
                }
            },
            new Restaurant
            {
                Name = "RockCreek Seafood & Spirits",
                Address = "4300 Fremont Ave N, Seattle, WA 98103",
                RatingAvg = 4.5f,
                ReviewCount = 447,
                OpenHours = new List<DaySchedule>
                {
                    new DaySchedule { DayOfWeek = DayOfWeek.Monday, StartTime = new TimeOnly(16, 0), EndTime = new TimeOnly(22, 0) },
                    new DaySchedule { DayOfWeek = DayOfWeek.Tuesday, StartTime = new TimeOnly(16, 0), EndTime = new TimeOnly(22, 0) },
                    new DaySchedule { DayOfWeek = DayOfWeek.Wednesday, StartTime = new TimeOnly(16, 0), EndTime = new TimeOnly(22, 0) },
                    new DaySchedule { DayOfWeek = DayOfWeek.Thursday, StartTime = new TimeOnly(16, 0), EndTime = new TimeOnly(22, 0) },
                    new DaySchedule { DayOfWeek = DayOfWeek.Friday, StartTime = new TimeOnly(16, 0), EndTime = new TimeOnly(23, 0) },
                    new DaySchedule { DayOfWeek = DayOfWeek.Saturday, StartTime = new TimeOnly(16, 0), EndTime = new TimeOnly(23, 0) },
                    new DaySchedule { DayOfWeek = DayOfWeek.Monday, StartTime = new TimeOnly(16, 0), EndTime = new TimeOnly(22, 0) }
                },
                Amenities = new List<string>
                {
                    "Outdoor seating",
                    "Cocktails",
                    "Happy hour",
                    "Brunch"
                },
                Reviews = new List<Review>
                {
                    new Review { PostedAt = new DateTime(2023, 7, 16), Rating = 5, Title = "Worth the trip", Content = "We had an extraordinary late lunch on Saturday. We tried the selection of oysters, really good. We also had the Chilean Seabass. It’s a must while in Seattle. Service very amicable and they have a nice variety of wines." },
                    new Review { PostedAt = new DateTime(2023, 7, 16), Rating = 5, Title = "The best!!", Content = "Excellent food. Oysters and fish are delightful, accompanied by very good wines. The restaurant is 10 minutes away from central Seattle, but via Uber it’s easy to get there. Highly recommended." },
                    new Review { PostedAt = new DateTime(2023, 7, 11), Rating = 5, Title = "Get the tuna!", Content = "We were here for dinner after a college graduation. It was a more casual venue than I expected, but nice, and easy noise levels for conversation.\r\n\r\nThe wine list was not extensive, but had some very nice choices, at reasonable prices. We were surprised and happy to see a GSM!\r\n\r\nThe food was outstanding. It is the primary reason for my rating. I had the yellowfin tuna, which is probably the best tuna meal I have had ever. Maybe top 2. The graduate had the short rib, and was very happy, my wife had a cod dish, which was also outstanding. Whoever the chef was working on June 9, total victory!\r\n\r\nAs an aside, we had to ask them for a special dispensation to go from 4 to 5 at our table, which they were able to do very short notice on a crowded Friday night. Very appreciated.\r\n\r\nI am in a mobility scooter, the manager personally came out to help with the exterior ADA lift.\r\n\r\nLooking forward to eating here again!" }
                },
                Menu = new List<MenuItem>
                {
                    new MenuItem { ItemType = "Startes (Dinner)", Title = "Black Garlic Caesar", Description = "Gem lettuce, anchovies, rustic croutons, lemon, sea…" },
                    new MenuItem { ItemType = "Startes (Dinner)", Title = "Seared Norwegian Mackerel Salad", Description = "Roasted eggplant, mint, basil, tomatoes,…" },
                    new MenuItem { ItemType = "Startes (Dinner)", Title = "Heirloom Cauliflower", Description = "Farro, pine nuts, celery, calabrian chili, white…" }
                }
            },
            new Restaurant
            {
                Name = "Shuckers",
                Address = "411 University Street, Seattle, WA 98101",
                ReviewCount = 1000,
                RatingAvg = 4.5f,
                OpenHours = new List<DaySchedule>
                {
                    new DaySchedule { DayOfWeek = DayOfWeek.Monday, AllDayClosed = true },
                    new DaySchedule { DayOfWeek = DayOfWeek.Tuesday, StartTime = new TimeOnly(17, 0), EndTime = new TimeOnly(21, 0) },
                    new DaySchedule { DayOfWeek = DayOfWeek.Wednesday, StartTime = new TimeOnly(17, 0), EndTime = new TimeOnly(21, 0) },
                    new DaySchedule { DayOfWeek = DayOfWeek.Thursday, StartTime = new TimeOnly(17, 0), EndTime = new TimeOnly(21, 0) },
                    new DaySchedule { DayOfWeek = DayOfWeek.Friday, StartTime = new TimeOnly(17, 0), EndTime = new TimeOnly(21, 0) },
                    new DaySchedule { DayOfWeek = DayOfWeek.Saturday, StartTime = new TimeOnly(17, 0), EndTime = new TimeOnly(21, 0) },
                    new DaySchedule { DayOfWeek = DayOfWeek.Sunday, AllDayClosed = true }
                },
                Amenities = new List<string>
                {
                    "Serves alcohol",
                    "Happy hour",
                    "Accepts reservations",
                    "Accessible"
                },
                Reviews = new List<Review>
                {
                    new Review { PostedAt = new DateTime(2023, 8, 15), Rating = 5, Title = "Great place !", Content = "Sat at the bar - Brent is a terrific bartender! Tried 2 different types of oysters - delicious! Calamari was yummy too - served in a broth ! Finished off sharing fish and chips . Wonderful night, great staff and atmosphere!\r\n\r\nhttps://www.tripadvisor.com/ShowUserReviews-g60878-d432669-r911280315-Shuckers_Oyster_Bar-Seattle_Washington.html#" },
                    new Review { PostedAt = new DateTime(2023, 5, 11), Rating = 5, Title = "Great dinner out", Content = "Terrific dinner out with friends. The food was amazing. Had the king salmon and steak and some crème brûlée to top to off. Really good and service was top notch." },
                    new Review { PostedAt = new DateTime(2023, 4, 12), Rating = 5, Title = "Great", Content = "Amazing food and amazing service. The restaurant wasn’t the most well kept nor smelt particularly nice but the team and the food more than made up for this." },
                    new Review { PostedAt = new DateTime(2022, 10, 17), Rating = 4, Title = "Great Seafood, Hotel Pricing", Content = "Had dinner here our first night at the Fairmont Olympic. We found the service friendly and efficient. Food was delicious and portions were generous (so much crab!). Just found the pricing was at a premium, which is likely due to the hotel it's attached to. Really appreciated the comp'ed dessert -- it was an anniversary stay, and this was actually the only gesture we had at the hotel or its restaurants over four nights, so that made it more special even! Good wine list, and our server was super knowledgeable about the wines. Be sure to the local bourbon flight to wrap up the meal!" }
                },
                Menu = new List<MenuItem>
                {
                    new MenuItem { ItemType = "Appetizers", Title = "Half Dozen", PriceUSD = 24, Description = "Traditional Mignonette, Horseradish, Cocktail Sauce" },
                    new MenuItem { ItemType = "Appetizers", Title = "Little Gem Lettuce", PriceUSD = 16, Description = "Grapes, Walnuts, Red Onion, Tarragon Dressing" },
                    new MenuItem { ItemType = "Main Course", Title = "Grilled Halibut", PriceUSD = 35, Description = "Piperade, Chorizo, Potatoes, Herbs" },
                    new MenuItem { ItemType = "Main Course", Title = "Dungeness Crab Baked Pasta", PriceUSD = 29, Description = "Garlic Herb Bread Crumb" },
                    new MenuItem { ItemType = "Main Course", Title = "Fish & Chips", PriceUSD = 25, Description = "Mushy Peas, Pickles, Coleslaw" }
                }
            },
            new Restaurant
            {
                Name = "Elliott's Oyster House",
                Address = "1201 Alaskan Way Ste 100, Seattle, WA 98101",
                ReviewCount = 3180,
                RatingAvg = 4.5f,
                OpenHours = new List<DaySchedule>
                {
                    new DaySchedule { DayOfWeek = DayOfWeek.Monday, StartTime = new TimeOnly(11, 0), EndTime = new TimeOnly(21, 0) },
                    new DaySchedule { DayOfWeek = DayOfWeek.Tuesday, StartTime = new TimeOnly(11, 0), EndTime = new TimeOnly(21, 0) },
                    new DaySchedule { DayOfWeek = DayOfWeek.Wednesday, StartTime = new TimeOnly(11, 0), EndTime = new TimeOnly(21, 0) },
                    new DaySchedule { DayOfWeek = DayOfWeek.Thursday, StartTime = new TimeOnly(11, 0), EndTime = new TimeOnly(21, 0) },
                    new DaySchedule { DayOfWeek = DayOfWeek.Friday, StartTime = new TimeOnly(11, 0), EndTime = new TimeOnly(22, 0) },
                    new DaySchedule { DayOfWeek = DayOfWeek.Saturday, StartTime = new TimeOnly(11, 0), EndTime = new TimeOnly(22, 0) },
                    new DaySchedule { DayOfWeek = DayOfWeek.Sunday, StartTime = new TimeOnly(11, 0), EndTime = new TimeOnly(21, 0) }
                },
                Amenities = new List<string>
                {
                    "Outdoor seating",
                    "Table service",
                    "Cocktails"
                },
                Reviews = new List<Review>
                {
                    new Review { PostedAt = new DateTime(2023, 9, 10), Rating = 4, Title = "Waterfront Classic - Still Great after many years", Content = "Elliott's Oyster House has been on the Seattle waterfront for many years. The great news is the quality of food and service has stayed at a high level for all these years. Offering a wide variety of oysters (of course) provides the opportunity to mix and match different tastes. Check with your waiter for suggestions and enjoy! Lots of great menu selections and for those who do not enjoy seafood, Elliott's offers plenty of options including for those who are gluten-free and vegan.\r\n\r\nSignature cocktails are available and kind be kind of pricey! Bread for the table is recommended as are reservations (expect to wait quite awhile for a table of a weekend if you do not reserve in advance). We went there on a Friday night during the busy summer hours with a party of 6 and were seated within 5 minutes of our reservation time.\r\n\r\nElliott's is not inexpensive, with drinks and appetizers you can expect to pay ~$50-$60/person. One thing to note, Elliott's adds a 20% \"service fee\" to your bill whether you like it or not. You can ask to have it taken off (we did not) and be aware of this charge in case you do not want to \"double tip\"." },
                    new Review { PostedAt = new DateTime(2023, 9, 3), Rating = 5, Title = "Fabulous oysters and seafood", Content = "A favorite for fresh oysters and seafood on the water. It's expensive, but worthy of a special trip when in Seattle. Definitely leave time to park a little farther to avoid the tourist trap parking across the street." },
                    new Review { PostedAt = new DateTime(2023, 8, 27), Rating = 5, Title = "Great seafood and atmosphere on the Pier!", Content = "We were in Seattle for a week,and actually had dinner at Elliott's three of those nights. We had been on previous trips and always enjoyed it.The weather was beautiful all week,so we were able to be seated outside ,which was very pleasant,\r\nThe fried oyster appetizers' were so good,and the house salad with strawberries and goat cheese is a keeper! I had the rockfish all 3 nights,and I usually don't repeat entrees,but the fish was exceptional.\r\nGreat service each night. This doesn't feel as touristy as so many other places in the area, which was nice, too." }
                },
                Menu = new List<MenuItem>
                {
                    new MenuItem { ItemType = "Seafood", Title = "Grilled Salmon", PriceUSD = 49, Description = "Citrus-sesame butter, glazed yams, shiitake mushroom,…" },
                    new MenuItem { ItemType = "Seafood", Title = "Grilled Chili Lime Prawns", PriceUSD = 41, Description = "Pepper and andouille sausage relish, guajillo…" },
                    new MenuItem { ItemType = "Seafood", Title = "Pan Fried Pacific Oysters", PriceUSD = 32, Description = "Tartar sauce, bourbon sauce, roasted potatoes,…" },
                    new MenuItem { ItemType = "For the Table", Title = "Celebration", PriceUSD = 115, Description = "(10) oysters, prawns, snow crab cocktail claws, half–shell scallops, frozen champagne mignonette, cilantro–lime mignonette, cocktail sauce." },
                    new MenuItem { ItemType = "For the Table", Title = "Jubilee", PriceUSD = 135, Description = "King crab claws, bairdi crab, prawns, sea scallops and mussels. Cocktail and remoulade sauce." }
                }
            },
            new Restaurant
            {
                Name = "Pike Place Chowder",
                Address = "1530 Post Aly, Seattle, WA 98101",
                ReviewCount = 4330,
                RatingAvg = 4.5f,
                OpenHours = new List<DaySchedule>
                {
                    new DaySchedule { DayOfWeek = DayOfWeek.Monday, StartTime = new TimeOnly(11, 0), EndTime = new TimeOnly(20, 0) },
                    new DaySchedule { DayOfWeek = DayOfWeek.Tuesday, StartTime = new TimeOnly(11, 0), EndTime = new TimeOnly(20, 0) },
                    new DaySchedule { DayOfWeek = DayOfWeek.Wednesday, StartTime = new TimeOnly(11, 0), EndTime = new TimeOnly(20, 0) },
                    new DaySchedule { DayOfWeek = DayOfWeek.Thursday, StartTime = new TimeOnly(11, 0), EndTime = new TimeOnly(20, 0) },
                    new DaySchedule { DayOfWeek = DayOfWeek.Friday, StartTime = new TimeOnly(11, 0), EndTime = new TimeOnly(21, 0) },
                    new DaySchedule { DayOfWeek = DayOfWeek.Saturday, StartTime = new TimeOnly(11, 0), EndTime = new TimeOnly(21, 0) },
                    new DaySchedule { DayOfWeek = DayOfWeek.Sunday, StartTime = new TimeOnly(11, 0), EndTime = new TimeOnly(19, 0) }
                },
                Amenities = new List<string>
                {
                    "Outdoor seating",
                    "Wi-Fi",
                    "Good for kids",
                    "Accessible"
                },
                Reviews = new List<Review>
                {
                    new Review { PostedAt = new DateTime(2023, 9, 3), Rating = 5, Title = "Get it to go!", Content = "So the line was LONG! Beyond the pasta and pizza place you can order your chowder to go! Use the online QR code order and in 5 minutes you are walking around the fish market with fresh chowder. We had the smoked salmon. It was good!" },
                    new Review { PostedAt = new DateTime(2023, 8, 27), Rating = 5, Title = "Best Clam Chowder Ever.", Content = "The best chowder I have ever had. The sourdough bread bowl puts it over the top. Amazing. I would definitely eat here again." },
                    new Review { PostedAt = new DateTime(2023, 8, 20), Rating = 4, Title = "Good chowder", Content = "Their 4-cup sampler was good; it came in multiple flavors with plenty of bread accompanying it. There was a long queue at lunch time, so we ordered online and got fast pickup in a few minutes. Then we went out on the terrace of the Public Market for an unhurried meal with a fine view of the water." }
                },
                Menu = new List<MenuItem>
                {
                    new MenuItem { ItemType = "Award-Winning Chowder", Title = "New England Clam Chowder", PriceUSD = 9.45m },
                    new MenuItem { ItemType = "Award-Winning Chowder", Title = "Smoked Salmon Chowder", PriceUSD = 9.45m },
                    new MenuItem { ItemType = "Award-Winning Chowder", Title = "Manhattan Chowder", PriceUSD = 9.45m },
                    new MenuItem { ItemType = "Award-Winning Chowder", Title = "Crab & Oyster Chowder", PriceUSD = 9.45m }
                }
            }
        };

        public static Restaurant GetSampleRestaurant()
        {
            return AllRestaurants[0];
        }

        public static IEnumerable<Restaurant> GetRestaurants(string? name = null)
        {
            if (name == null)
                return AllRestaurants;
            else
                return AllRestaurants.Where(r => r.Name == name);
        }

    }
}
