using KhanhLinh_Store.CoreBusiness.Model;

namespace KhanhLinh_Store.UseCase.AdminPortal.OutStandingOrderScreen
{
    public interface IViewOutStandingOrderUserCase
    {
        IEnumerable<Order> Execute();
    }
}