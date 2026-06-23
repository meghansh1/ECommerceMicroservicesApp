using ProductService.Domain.Entities;

namespace ProductService.Repositories;

public class ProductRepository : IProductRepository
{
    private static readonly List<Product> Products = new();

    public List<Product> GetAll()
    {
        return Products;
    }

    public Product? GetById(Guid id)
    {
        return Products.FirstOrDefault(x => x.Id == id);
    }

    public Product Add(Product product)
    {
        Products.Add(product);

        return product;
    }
}