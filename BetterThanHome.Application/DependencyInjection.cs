using BetterThanHome.Application.Services.Deliveries;
using BetterThanHome.Application.Services.Dishes;
using BetterThanHome.Application.Services.Guests;
using BetterThanHome.Application.Services.Menus;
using BetterThanHome.Application.Services.Orders;
using BetterThanHome.Application.Services.StaffMembers;
using BetterThanHome.Application.Services.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace BetterThanHome.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IMenuService, MenuServices>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IStaffService, StaffService>();
            services.AddScoped<IDishService, DishService>();
            services.AddScoped<IDeliveryService, DeliveryService>();
            services.AddScoped<IGuestService, GuestService>();
            services.AddScoped<IAuthenticationService, AuthenticationService>();

            return services;
        }
    }
}
