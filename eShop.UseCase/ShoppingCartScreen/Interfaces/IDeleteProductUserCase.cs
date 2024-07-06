using KhanhLinh_Store.CoreBusiness.Model;

namespace KhanhLinh_Store.UseCase.ShoppingCartScreen.Interfaces
{
    public interface IDeleteProductUserCase
    {
        Task<Order> Execute(int productId);
    }
}