using KhanhLinh_Store.CoreBusiness.Model;

namespace KhanhLinh_Store.UseCase.AdminPortal.ProcessedOrderScreen
{
    public interface IViewPrcessedOrderUserCase
    {
        IEnumerable<Order> Execute();
    }
}