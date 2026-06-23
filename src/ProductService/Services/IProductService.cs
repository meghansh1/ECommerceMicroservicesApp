using ProductService.Domain.Entities;
using ProductService.Models;

namespace ProductService.Services;

public interface IProductService
{
    IEnumerable<Product> GetAll();

    Product? GetById(Guid id);

    Product Create(CreateProductRequest request);
}