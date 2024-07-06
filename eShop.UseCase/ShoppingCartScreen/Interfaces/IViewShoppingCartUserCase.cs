using KhanhLinh_Store.CoreBusiness.Model;

namespace KhanhLinh_Store.UseCase.ShoppingCartScreen.Interfaces
{
    public interface IViewShoppingCartUserCase
    {
        Task<Order> Execute();
    }
}