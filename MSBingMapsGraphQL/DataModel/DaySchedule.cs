namespace MSBingMapsGraphQL.DataModel
{
    public class DaySchedule
    {
        public DayOfWeek DayOfWeek { get; set; }

        public TimeOnly StartTime { get; set; }

        public TimeOnly EndTime { get; set; }

        public bool AllDayClosed { get; set; }

        public bool Open24H { get; set; }

    }
}
