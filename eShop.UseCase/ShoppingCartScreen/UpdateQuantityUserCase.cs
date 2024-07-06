﻿using KhanhLinh_Store.CoreBusiness.Model;
using KhanhLinh_Store.UseCase.PluginInterface.StateStore;
using KhanhLinh_Store.UseCase.PluginInterface.UI;
using KhanhLinh_Store.UseCase.ShoppingCartScreen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanhLinh_Store.UseCase.ShoppingCartScreen
{
    public class UpdateQuantityUserCase : IUpdateQuantityUserCase
    {
        private readonly IShopingCart _shoppingCart;
        private readonly IShoppingCartStateStore _shoppingstateStore;
        public UpdateQuantityUserCase(IShopingCart shoppingCart, IShoppingCartStateStore shoppingCartStateStore)
        {
            this._shoppingCart = shoppingCart;
            this._shoppingstateStore = shoppingCartStateStore;
        }

        public async Task<Order> Execute(int productId, int quatity)
        {
            var order = await _shoppingCart.UpdateQuantityAsync(productId, quatity);
            _shoppingstateStore.UpdateProductQuatity();
            return order;
        }
    }
}
