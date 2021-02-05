using AutoMapper;
using Dotz.Domain.Entities;
using Dotz.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotz.WebApi.Configuration
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<Cliente, ClienteViewModel>().ReverseMap();
            CreateMap<ClienteEndereco, ClienteEnderecoViewModel>().ReverseMap();
            CreateMap<Produto, ProdutoViewModel>().ReverseMap();

            CreateMap<ClienteMovimentacao, ClienteMovimentacaoViewModel>().ReverseMap();
            CreateMap<ClienteResgate, ClienteResgateViewModel>().ReverseMap();
            CreateMap<Parceiro, ParceiroViewModel>().ReverseMap();
            CreateMap<ProdutoParceiro, ProdutoParceiroViewModel>().ReverseMap();
            CreateMap<ClientePedido, ClientePedidoViewModel>().ReverseMap();

        }
    }
}
