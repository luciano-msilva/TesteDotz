using Dotz.Application.AppServices;
using Dotz.Application.Interfaces;
using Dotz.Domain.Entities.Extensions;
using Dotz.Domain.Interface.Extensions;
using Dotz.Domain.Interface.Repositories;
using Dotz.Domain.Interface.Services;
using Dotz.Domain.Services;
using Dotz.Infra.Data.Context;
using Dotz.Infra.Data.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotz.WebApi.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<Contexto>();            
            
            //AppService
            services.AddScoped<INotificador, Notificador>();
            services.AddScoped<IClienteAppService, ClienteAppService>();
            services.AddScoped<IClienteEnderecoAppService, ClienteEnderecoAppService>();
            services.AddScoped<IClienteMovimentacaoAppService, ClienteMovimentacaoAppService>();
            services.AddScoped<IClienteResgateAppService, ClienteResgateAppService>();
            services.AddScoped<IParceiroAppService, ParceiroAppService>();
            services.AddScoped<IProdutoAppService, ProdutoAppService>();
            services.AddScoped<IClientePedidoAppService, ClientePedidoAppService>();

            //Service
            services.AddScoped<IClienteService, ClienteService>();            
            services.AddScoped<IClienteEnderecoService, ClienteEnderecoService>();
            services.AddScoped<IClienteMovimentacaoService, ClienteMovimentacaoService>();
            services.AddScoped<IClienteResgateService, ClienteResgateService>();
            services.AddScoped<IParceiroService, ParceiroService>();
            services.AddScoped<IProdutoService, ProdutoService>();
            services.AddScoped<IClientePedidoService, ClientePedidoService>();

            //Repository
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IClienteEnderecoRepository, ClienteEnderecoRepository>();
            services.AddScoped<IClienteMovimentacaoRepository, ClienteMovimentacaoRepository>();
            services.AddScoped<IClienteResgateRepository, ClienteResgateRepository>();
            services.AddScoped<IParceiroRepository, ParceiroRepository>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IClientePedidoRepository, ClientePedidoRepository>();

            //Extension
            services.AddScoped<IUser, AspNetUser>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            //services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();

            return services;
        }
    }
}
