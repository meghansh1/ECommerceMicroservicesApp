using ProductService.Domain.Entities;
using ProductService.Models;
using ProductService.Repositories;

namespace ProductService.Services;

public class ProductServiceManager : IProductService
{
    private readonly IProductRepository _repository;

    public ProductServiceManager(IProductRepository repository)
    {
        _repository = repository;
    }

    public IEnumerable<Product> GetAll()
    {
        return _repository.GetAll();
    }

    public Product? GetById(Guid id)
    {
        return _repository.GetById(id);
    }

    public Product Create(CreateProductRequest request)
    {
        var product = new Product
        {
            Id = Guid.NewGuid(),
            Name = request.Name,
            Description = request.Description,
            Price = request.Price,
            StockQuantity = request.StockQuantity
        };

        return _repository.Add(product);
    }
}