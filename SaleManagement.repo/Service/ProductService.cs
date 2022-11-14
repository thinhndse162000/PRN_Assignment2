using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SaleManagement.repo.Models;
using SaleManagement.repo.Repository;

namespace SaleManagement.repo.Service
{
    public class ProductService
    {
        private IProductRepository _productRepository;

        private static ProductService instance = null;
        private static readonly object instanceLock = new object();
        public static ProductService Instance {
            get {
                lock(instanceLock) {
                    if (instance == null) {
                        instance = new ProductService();
                    }
                    return instance;
                }
            }
        }
        public ProductService() {
            _productRepository = new ProductRepository();
        }

        public IEnumerable<Product> Filter(int id, string name, decimal price, int unitsInStock) {
            IEnumerable<Product> products = _productRepository.GetAllProduct();
            if (id != 0) products = products.Where(p => p.ProductId == id);
            if (name != "") products = products.Where(p => p.ProductName.ToLower().Contains(name.ToLower()));
            if (price!= 0) products = products.Where(p => Decimal.Ceiling(p.UnitPrice) == Decimal.Ceiling(price));
            if (unitsInStock!= 0) products = products.Where(p => p.UnitsInStock == unitsInStock);
            return products;
        }
    }
}