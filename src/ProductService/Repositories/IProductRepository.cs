using ProductService.Domain.Entities;

namespace ProductService.Repositories;

public interface IProductRepository
{
    List<Product> GetAll();

    Product? GetById(Guid id);

    Product Add(Product product);
}