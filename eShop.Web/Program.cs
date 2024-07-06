using KhanhLinh_Store.CoreBusiness.Service;
using KhanhLinh_Store.CoreBusiness.Service.Interfaces;
using KhanhLinh_Store.DataStore.HardCodes.Helper;

//using eShop.DataStore.HardCode;
using KhanhLinh_Store.DataStore.SQL.Dapper;
using KhanhLinh_Store.ShopingCart.LocalStorage;
using KhanhLinh_Store.StateStore.DI;
using KhanhLinh_Store.UseCase.AdminPortal.OrderDetailsScreen;
using KhanhLinh_Store.UseCase.AdminPortal.OrderDetailsScreen.interfaces;
using KhanhLinh_Store.UseCase.AdminPortal.OutStandingOrderScreen;
using KhanhLinh_Store.UseCase.AdminPortal.ProcessedOrderScreen;
using KhanhLinh_Store.UseCase.OrderConfirmScreen;
using KhanhLinh_Store.UseCase.PluginInterface.DataStore;
using KhanhLinh_Store.UseCase.PluginInterface.StateStore;
using KhanhLinh_Store.UseCase.PluginInterface.UI;
using KhanhLinh_Store.UseCase.SearchProductScreen;
using KhanhLinh_Store.UseCase.ShoppingCartScreen;
using KhanhLinh_Store.UseCase.ShoppingCartScreen.Interfaces;
using KhanhLinh_Store.UseCase.ViewProductScreen;
using KhanhLinh_Store.UseCase.ViewProductScreen.Interfaces;
using KhanhLinh_Store.Web.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

//Add services for auth
builder.Services.AddControllers();
builder.Services.AddAuthentication("eShop.CookieAuth").AddCookie("eShop.CookieAuth", config =>
{
    config.Cookie.Name = "eShop.CookieAuth";
    config.LoginPath = "/authenticate";
});

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
//tồn tại trong dự án chuyển sang AddTransient từ AddSingleton
builder.Services.AddTransient<IProductRepository,ProductRepository>();
builder.Services.AddTransient<IOrderRespository, OrderRepository>();
builder.Services.AddTransient<IDataAccess>(sp=>new DataAccess(builder.Configuration.GetConnectionString("Default")));
//chỉ 1 user view cart
builder.Services.AddScoped<IShopingCart, ShopingCart>();
builder.Services.AddScoped<IShoppingCartStateStore, ShoppingCartStateStore>();

//gọi 1 lần
builder.Services.AddTransient<IOrderService, OrderService>();
builder.Services.AddTransient<IViewProductUseCase, ViewProductUseCase>();
builder.Services.AddTransient<ISearchProductUseCase, SearchProductUseCase>();
builder.Services.AddTransient<IAddProductToCartUserCase, AddProductToCartUserCase>();
builder.Services.AddTransient<IViewShoppingCartUserCase,ViewShoppingCartUserCase>();
builder.Services.AddTransient<IDeleteProductUserCase, DeleteProductUserCase>();
builder.Services.AddTransient<IUpdateQuantityUserCase, UpdateQuantityUserCase>();
builder.Services.AddTransient<IPlaceOrderUserCase, PlaceOrderUserCase>();
builder.Services.AddTransient<IViewOrderConfrimUserCase, ViewOrderConfrimUserCase>();

builder.Services.AddTransient<IViewOutStandingOrderUserCase,ViewOutStandingOrderUserCase>();
builder.Services.AddTransient<IViewOrderDetailUserCase, ViewOrderDetailUserCase>();
builder.Services.AddTransient<IProcessOrderUseCase, ProcessOrderUseCase>();
builder.Services.AddTransient<IViewPrcessedOrderUserCase, ViewPrcessedOrderUserCase>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

// xác thực & phân quyền
app.UseAuthorization();
app.UseAuthentication();
app.MapControllers();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
