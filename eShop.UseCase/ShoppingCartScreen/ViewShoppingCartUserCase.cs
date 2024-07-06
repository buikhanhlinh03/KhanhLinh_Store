using KhanhLinh_Store.CoreBusiness.Model;
using KhanhLinh_Store.UseCase.PluginInterface.UI;
using KhanhLinh_Store.UseCase.ShoppingCartScreen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanhLinh_Store.UseCase.ShoppingCartScreen
{
    public class ViewShoppingCartUserCase : IViewShoppingCartUserCase
    {
        //khai báo
        private readonly IShopingCart _shoppingCart;

        //khởi tạo
        public ViewShoppingCartUserCase(IShopingCart shopingCart)
        {
            this._shoppingCart = shopingCart;
        }
        public Task<Order> Execute()
        {
            return _shoppingCart.GetOrderAsync();
        }
    }
}
