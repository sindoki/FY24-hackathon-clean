namespace MSBingMapsGraphQL.DataModel
{
    public class Restaurant : Location
    {
        public List<MenuItem> Menu { get; set; }

        public Restaurant() : base()
        {
            Menu = new List<MenuItem>();
        }
    }
}
