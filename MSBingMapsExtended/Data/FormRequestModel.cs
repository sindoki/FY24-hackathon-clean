namespace MSBingMapsExtended.Data
{
    /// <summary>
    /// Data model submitted by the search form
    /// </summary>
    public class FormRequestModel
    {
        public string SearchRequest { get; set; }

        public bool UseGraphQL { get; set; }

        public FormRequestModel()
        {
            UseGraphQL = true;
        }

    }
}
