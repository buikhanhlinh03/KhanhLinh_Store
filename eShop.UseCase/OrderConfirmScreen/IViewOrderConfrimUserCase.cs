using KhanhLinh_Store.CoreBusiness.Model;

namespace KhanhLinh_Store.UseCase.OrderConfirmScreen
{
    public interface IViewOrderConfrimUserCase
    {
        Order Execute(string uniqueId);
    }
}