using Api.Facebook.Ultils;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Facebook.GraphQL.Types.FilterType
{
    public class PaginationSettingsType : InputObjectGraphType<PaginationSettings>
    {
        public PaginationSettingsType()
        {
            Field(x => x.PageIndex);
            Field(x => x.PageSize);
            Field<SortSettingsType>(typeof(SortSettings).Name);
        }
    }
}
