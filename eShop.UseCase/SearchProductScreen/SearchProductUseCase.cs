using KhanhLinh_Store.CoreBusiness.Model;
using KhanhLinh_Store.UseCase.PluginInterface.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanhLinh_Store.UseCase.SearchProductScreen
{
    //Trả về danh sách sản phẩm
    public class SearchProductUseCase : ISearchProductUseCase
    {
        //Khởi tạo biến nội bộ
        private readonly IProductRepository _productRepository;
        //Contructor
        public SearchProductUseCase(IProductRepository productRepository) { 
            this._productRepository = productRepository;
        }
        //Trả về danh sách sản phẩm
        public IEnumerable<Product> Execute(string filter)
        {
            return _productRepository.GetProduct(filter);

        }
    }
}
