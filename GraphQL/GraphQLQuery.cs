using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Facebook.GraphQL
{
    public class GraphQLQuery
    {
        public string OperatioName { get; set; }
        public string NamedQquery { get; set; }
        public string Query { get; set; }
        public JObject Variables { get; set; }
    }
}
