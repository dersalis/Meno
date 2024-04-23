using MediatR;
using Meno.Application.DTO;

namespace Meno.Application.Queries.Places.GetAllCategories
{
    public class GetAllCategoriesQuery : IRequest<IEnumerable<CategoryDto>>
    {
        public Guid PlaceId { get; set; }
    }
}