using KhanhLinh_Store.CoreBusiness.Model;

namespace KhanhLinh_Store.UseCase.ShoppingCartScreen.Interfaces
{
    public interface IUpdateQuantityUserCase
    {
        Task<Order> Execute(int productId, int quatity);
    }
}