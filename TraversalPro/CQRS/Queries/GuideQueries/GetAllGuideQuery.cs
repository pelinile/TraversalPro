using MediatR;
using TraversalPro.CQRS.Results.GuideResults;

namespace TraversalPro.CQRS.Queries.GuideQueries
{
    public class GetAllGuideQuery :IRequest<List<GetAllGuideQueryResult>>
    {

    }
}
