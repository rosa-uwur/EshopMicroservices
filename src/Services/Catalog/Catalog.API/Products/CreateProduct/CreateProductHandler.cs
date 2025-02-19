using BuildingBlocks.CQRS;
using MediatR;
using System.Windows.Input;

namespace Catalog.API.Products.CreateProduct
{

    public record CreateProductCommand(string Name, string Description, List<string> Category, string ImageFile, decimal Price)
        : ICommand<CreateProductResult>;
    
    public record CreateProductResult(Guid Id);

    internal class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, CreateProductResult>
    {
        public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {

            //Create product entity from command
            var product = new Product
            {
                Name = command.Name,
                Category = command.Category,
                Description = command.Description,
                ImageFile = command.ImageFile,
                Price = command.Price,
            };
            //TODO
            //save to database

            //return CreateProductResult result
            return new CreateProductResult(Guid.NewGuid());

        }
    }
}
