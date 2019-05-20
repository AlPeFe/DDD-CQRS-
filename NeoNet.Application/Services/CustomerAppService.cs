using System;
using AutoMapper;
using NeoNet.Application.Interfaces;
using NeoNet.Application.ViewModels;
using NeoNet.Domain.Interfaces;
using NeoNet.Infra.Data.Repository;

namespace NeoNet.Application.Services
{
    // esta clase contiene el servicio al cual nuestra api va a poder acceder y trabajar con los métodos, recivirá el viewModel ( dto) se usa automapper para convertir
    public class CustomerAppService : ICustomerAppService
    {
        private readonly IMapper _mapper;
        private readonly ICustomerRepository _customerRepository;

        public CustomerAppService(IMapper mapper,
                                   ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public CustomerViewModel GetById(Guid id)
        {
            return _mapper.Map<CustomerViewModel>(_customerRepository.GetById(id));
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(CustomerViewModel customerViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
