using MediatR;
using TraversalPro.CQRS.Results.GuideResults;

namespace TraversalPro.CQRS.Queries.GuideQueries
{
    public class GetGuideByIDQuery : IRequest<GetGuideByIDQueryResult>
    {
     
        public int Id { get; set; }

        public GetGuideByIDQuery(int ıd)
        {
            Id = ıd;
        }
    }
}
