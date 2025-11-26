using StoreApp.Data.Concrete;

namespace StoreApp.Data.Abstract;

public interface IStoreRepository
{
    IQueryable<Product> Products { get; } //Flitreleme yapacağımız için IQueryable döndürüyoruz.
    void CreateProduct(Product entity);
}