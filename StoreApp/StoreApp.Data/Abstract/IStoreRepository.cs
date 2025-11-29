using StoreApp.Data.Concrete;

namespace StoreApp.Data.Abstract;

public interface IStoreRepository
{
    IQueryable<Product> Products { get; } //Flitreleme yapacağımız için IQueryable döndürüyoruz.
    IQueryable<Category> Categories { get; }
    void CreateProduct(Product entity);
}