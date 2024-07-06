using KhanhLinh_Store.CoreBusiness.Model;
using KhanhLinh_Store.UseCase.PluginInterface.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanhLinh_Store.UseCase.OrderConfirmScreen
{
    public class ViewOrderConfrimUserCase : IViewOrderConfrimUserCase
    {
        private readonly IOrderRespository _oderRepository;
        public ViewOrderConfrimUserCase(IOrderRespository orderRespository)
        {
            this._oderRepository = orderRespository;
        }
        public Order Execute(string uniqueId)
        {
            return _oderRepository.GetOrderByUniqueId(uniqueId);
        }
    }
}
