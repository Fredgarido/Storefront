using ProductCatalog.Server.Dtos;

namespace ProductCatalog.Server.Services;

public interface IProductService
{
    Task<IReadOnlyList<ProductDto>> GetAllAsync(CancellationToken cancellationToken);

    Task<ProductDto?> GetByIdAsync(int id, CancellationToken cancellationToken);

    Task<ProductDto> CreateAsync(CreateProductRequest request, CancellationToken cancellationToken);

    Task<ProductDto?> UpdateAsync(int id, UpdateProductRequest request, CancellationToken cancellationToken);

    Task<bool> DeleteAsync(int id, CancellationToken cancellationToken);
}