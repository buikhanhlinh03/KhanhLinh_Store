﻿namespace KhanhLinh_Store.UseCase.AdminPortal.OrderDetailsScreen.interfaces
{
    public interface IProcessOrderUseCase
    {
        bool Execute(int orderId, string adminUserName);
    }
}