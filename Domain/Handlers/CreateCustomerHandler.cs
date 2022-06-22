using System;
using Shop.Domain.Commands.Requests;
using Shop.Domain.Commands.Responses;

namespace Shop.Domain.Commands.Handlers
{
    public class CreateCustomerHandle : ICreateCustomerHandler
    {
        public CreateCustomerResponse Handle(CreateCustomerRequest request)
        {
            //Verifica se o cliente já está cadastrado
            //Valida os dados
            //Insere o cliente
            //Envia E-mail de boas vindas
            return new CreateCustomerResponse
            {
                Id = Guid.NewGuid(),
                Name = "Hiago Grades Werneck",
                Email = "hiago@hiago.com",
                Date = DateTime.Now
            };
        }
    }
}