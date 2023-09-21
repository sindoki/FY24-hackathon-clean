namespace MSBingMapsGraphQL.DataModel
{
    public class Location
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public float RatingAvg { get; set; }

        public List<DaySchedule> OpenHours { get; set; }

        public int ReviewCount { get; set; }

        public List<Review> Reviews { get; set; }

        public List<string> Amenities { get; set; }

        public Location()
        {
            Name = "";
            Address = "";
            OpenHours = new List<DaySchedule>();
            Reviews = new List<Review>();
            Amenities = new List<string>();
        }

    }
}
