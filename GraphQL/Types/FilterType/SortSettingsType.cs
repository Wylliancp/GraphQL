using Api.Facebook.Ultils;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Facebook.GraphQL.Types.FilterType
{
    public class SortSettingsType : InputObjectGraphType<SortSettings>
    {
        public SortSettingsType()
        {
            Field(x => x.OrderBy);
            Field<SortedDictionaryEnumType>("direction");
        }

    public class SortedDictionaryEnumType : EnumerationGraphType<SortDirection>
        {

        }
    }
}
