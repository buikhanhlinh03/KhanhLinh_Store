using KhanhLinh_Store.CoreBusiness.Model;
using KhanhLinh_Store.UseCase.PluginInterface.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanhLinh_Store.UseCase.AdminPortal.OutStandingOrderScreen
{
    public class ViewOutStandingOrderUserCase : IViewOutStandingOrderUserCase
    {
        private readonly IOrderRespository _orderRespository;
        public ViewOutStandingOrderUserCase(IOrderRespository orderRespository)
        {
            this._orderRespository = orderRespository;
        }
        public IEnumerable<Order> Execute()
        {
            return _orderRespository.GetOutstandingOrders();
        }
    }
}
