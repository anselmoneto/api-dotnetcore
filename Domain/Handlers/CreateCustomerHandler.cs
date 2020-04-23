using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Shop.Domain.Commands.Reponses;
using Shop.Domain.Commands.Requests;

namespace Shop.Domain.Handlers {
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        // public CreateCustomerResponse Handle(CreateCustomerRequest request)
        // {
        //     // // Verifica se o lciente já está cadastrado.
        //     // // Valida os dados
        //     // // Insere o cliente
        //     // // Envia email de boas vindas
        //     // // ...
        //     // return new CreateCustomerResponse(){
        //     //     Id = Guid.NewGuid(),
        //     //     Name = "Anselmo Neto",
        //     //     Email = "anselmo@test.com",
        //     //     Date = DateTime.Now
        //     // };
        // }

        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            // Verifica se o lciente já está cadastrado.
            // Valida os dados
            // Insere o cliente
            // Envia email de boas vindas
            // ...
            var result = new CreateCustomerResponse(){
                Id = Guid.NewGuid(),
                Name = "Anselmo Neto",
                Email = "anselmo@test.com",
                Date = DateTime.Now
            };

            return Task.FromResult(result);
        }
    }
}