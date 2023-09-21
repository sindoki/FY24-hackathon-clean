namespace MSBingMapsGraphQL.DataModel
{
    public class MenuItem
    {
        public string ItemType { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public decimal PriceUSD { get; set; }

        public MenuItem()
        {
            ItemType = "";
            Title = "";
            Description = "";
        }

    }
}
