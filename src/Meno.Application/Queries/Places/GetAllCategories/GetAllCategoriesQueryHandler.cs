using MediatR;
using Meno.Application.DTO;
using Meno.Core.Entities;
using Meno.Infrastructure.Abstractions;

namespace Meno.Application.Queries.Places.GetAllCategories
{
    

    internal sealed class GetAllCategoriesQueryHandler : IRequestHandler<GetAllCategoriesQuery, IEnumerable<CategoryDto>>
    {
        private readonly IRepository<Category> _categoryRepository;
        private readonly IRepository<Place> _placeRepository;

        public GetAllCategoriesQueryHandler(IRepository<Category> categoryRepository, IRepository<Place> placeRepository)
        {
            _categoryRepository = categoryRepository;
            _placeRepository = placeRepository;
        }

        public async Task<IEnumerable<CategoryDto>> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
        {
            var place = await _placeRepository.GetAsync(request.PlaceId);
            var categories = place.Categories;

            return categories.Select(c => new CategoryDto
            {
                Id = c.Id,
                Name = c.Name
            });
        }
    }

}