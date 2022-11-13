using SaleManagement.repo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagement.repo.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProduct();
        List<Product> GetProducts();
        Product GetProductById(int productId);
        void CreateMember(Product product);
        void Update(Product c);
        bool Delete(int productId);
    }
}
