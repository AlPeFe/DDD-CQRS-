using AutoMapper;
using NeoNet.Application.ViewModels;
using NeoNet.Domain.Models;

namespace NeoNet.Application.AutoMapper
{
    public class DomainToViewModelProfile : Profile
    {
        //perfil de mappers de dominio a viewmodel
        public DomainToViewModelProfile()
        {
            CreateMap<Customer, CustomerViewModel>();
        }

    }
}
