using Azure.AI.OpenAI;

namespace MSBingMapsExtended.Services
{
    public class QueryCreator
    {
        private GraphQLService GraphQLService;

        private GPTService GPTService;

        public QueryCreator(GraphQLService graphQLService, GPTService gptService)
        {
            GraphQLService = graphQLService;
            GPTService = gptService;
        }

        public string CreateGQLQuery(string prompt)
        {
            string gqlSchema = GraphQLService.GetGraphQLSchema();

            string[] gqlQueryLines = GPTService.AskGPT(
                    $"Please, provide a proper GraphQL query for the following request: \"{prompt}\". The response should be given as clean GraphQL query with no additional comments. Do not include types that don't exist in the schema.",
                    new Tuple<ChatRole, string>[] { 
                        new Tuple<ChatRole, string>(ChatRole.User, $"Here is the schema for GraphQL API: {gqlSchema}") 
                    }
                );

            string resQuery = string.Join("", gqlQueryLines);

            resQuery = PostProcessQuery(resQuery);

            if (resQuery.StartsWith("query"))
                resQuery = resQuery.Remove(0, 5);

            return resQuery;
        }

        private string PostProcessQuery(string query)
        {
            // Remove all filters in brackets

            string result = "";
            bool bracketsOpen = false;

            for (int i = 0; i < query.Length; i++)
            {
                if (bracketsOpen)
                {
                    if (query[i] == ')')
                        bracketsOpen = false;
                }
                else if (query[i] == '(')
                    bracketsOpen = true;
                else
                    result += query[i];
            }

            return result;

        }

    }
}
