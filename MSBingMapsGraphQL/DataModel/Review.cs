namespace MSBingMapsGraphQL.DataModel
{
    public class Review
    {
        public DateTime PostedAt { get; set; }

        /// <summary>
        /// Rating from 0 to 5
        /// </summary>
        public int Rating { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

    }
}
