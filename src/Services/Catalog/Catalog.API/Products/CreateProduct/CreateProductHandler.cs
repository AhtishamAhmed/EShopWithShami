using Catalog.API.Models;
using MediatR;

namespace Catalog.API.Products.CreateProduct
{
    public record CreateProductCommand(string Name, List<string> Category,
      string Description, string Imagefile, decimal Price)
        :IRequest<CreateProductResult>;
    public record CreateProductResult(Guid Id);
    public class CreateProductHandler : IRequestHandler<CreateProductCommand, CreateProductResult>
    {
        public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            //create a product
            //save to database
            //return value
            var product = new Product{
                Name = command.Name,
                Category = command.Category,
                Description = command.Description,
                ImageFile = command.Imagefile,
                Price = command.Price,
            };
            return new CreateProductResult(Guid.NewGuid());
        }
    }
}
