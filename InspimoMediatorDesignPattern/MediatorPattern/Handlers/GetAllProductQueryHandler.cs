using InspimoMediatorDesignPattern.DAL;
using InspimoMediatorDesignPattern.MediatorPattern.Queries;
using InspimoMediatorDesignPattern.MediatorPattern.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace InspimoMediatorDesignPattern.MediatorPattern.Handlers
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, List<GetAllProductQueryResult>>
    {
        private readonly Context _context;

        public GetAllProductQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<List<GetAllProductQueryResult>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            return await _context.Products.Select(x => new GetAllProductQueryResult
            {
                ProductID = x.ProductID,
                ProductCategory = x.ProductCategory,
                ProductName = x.ProductName,
                ProductPrice = x.ProductPrice,
                ProductStock = x.ProductStock
            }).ToListAsync();
        }
    }
}
