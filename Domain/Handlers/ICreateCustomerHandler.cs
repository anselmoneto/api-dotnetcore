using System;
using Shop.Domain.Commands.Reponses;
using Shop.Domain.Commands.Requests;

namespace Shop.Domain.Handlers {
    public interface ICreateCustomerHandler
    {
        CreateCustomerResponse Handle(CreateCustomerRequest request);
    }
}