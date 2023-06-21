using InspimoMediatorDesignPattern.DAL;
using InspimoMediatorDesignPattern.MediatorPattern.Commands;
using MediatR;

namespace InspimoMediatorDesignPattern.MediatorPattern.Handlers
{
    public class GetCreateProductCommandHandler : IRequestHandler<CreateProductCommand>
    {
        private readonly Context _context;

        public GetCreateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            _context.Products.Add(new Product
            {
                ProductCategory = request.ProductCategory,
                ProductName = request.ProductName,
                ProductPrice = request.ProductPrice,
                ProductStock = request.ProductStock,
            });
            await _context.SaveChangesAsync();
        }
    }
}
