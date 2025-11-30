using StoreApp.Data.Concrete;

namespace StoreApp.Data.Abstract;

public interface IStoreRepository
{
    IQueryable<Product> Products { get; } //Filitreleme yapacağımız için IQueryable döndürüyoruz.
    IQueryable<Category> Categories { get; }
    void CreateProduct(Product entity);
    int GetProductCount(string category); //Belirli bir kategorideki ürün sayısını döndüren metot
    IEnumerable<Product> GetProductsByCategory(string category, int page, int pageSize); //Sayfalama için gerekli metots
}