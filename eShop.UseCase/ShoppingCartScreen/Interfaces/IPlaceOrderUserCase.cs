using KhanhLinh_Store.CoreBusiness.Model;

namespace KhanhLinh_Store.UseCase.ShoppingCartScreen.Interfaces
{
    public interface IPlaceOrderUserCase
    {
        Task<string> Execute(Order order);
    }
}