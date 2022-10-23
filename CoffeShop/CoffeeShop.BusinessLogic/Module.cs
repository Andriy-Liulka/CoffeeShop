﻿using CoffeeShop.BusinessLogic.Common.CommonChecker;
using CoffeeShop.BusinessLogic.MainBusinessLogic.ServiceInterfaces;
using CoffeeShop.BusinessLogic.MainBusinessLogic.Services;
using CoffeeShop.BusinessLogic.MainBusinessLogic.Services.IdentityServices;
using CoffeeShop.BusinessLogic.MainBusinessLogic.Services.IdentityServices.Security;
using CoffeeShop.BusinessLogic.MainBusinessLogic.Services.MtM_Services;
using CoffeeShop.BusinessLogic.Validation;
using FluentValidation.Validators;
using Microsoft.Extensions.DependencyInjection;

namespace CoffeeShop.BusinessLogic;

public static class Module
{
    public static IServiceCollection AddBusinessLogicServices(this IServiceCollection services)
    {
        services.AddScoped<HashGenerator>();
        services.AddScoped<TokenGenerator>();
        services.AddScoped<ICommonChecker, CommonChecker>();
        services.AddScoped<IAuthenticateService, AuthenticateService>();
        services.AddScoped<IBonusCoffeeService, BonusCoffeeService>();
        services.AddScoped<ICoffeeService, CoffeeService>();
        services.AddScoped<IDiscountCoffeeService, DiscountCoffeeService>();
        services.AddScoped<IDiscountService, DiscountService>();
        services.AddScoped<IOrderService, OrderService>();
        services.AddScoped<IOrderVolumeCoffeeService, OrderVolumeCoffeeService>();
        services.AddScoped<IRoleService, RoleService>();
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IVolumeService, VolumeService>();

        services.AddSingleton<IValidatorsFactory, ValidatorsFactory>();
        services.AddScoped<IMainValidator,MainValidator>();
        return services;
    }
}