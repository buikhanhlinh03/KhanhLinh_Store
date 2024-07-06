using KhanhLinh_Store.CoreBusiness.Model;

namespace KhanhLinh_Store.UseCase.AdminPortal.OrderDetailsScreen.interfaces
{
    public interface IViewOrderDetailUserCase
    {
        Order Execute(int orderId);
    }
}