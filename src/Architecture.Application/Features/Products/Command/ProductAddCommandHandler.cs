using Architecture.Application.Contracts;
using Architecture.Domain.Entities;
using Cortex.Mediator.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Architecture.Application.Features.Products.Command
{
    public class ProductAddCommandHandler : ICommandHandler<ProductAddCommand, Product>
    {
        private readonly IApplicationUnitOfWork _unitOfWork;

        public ProductAddCommandHandler(IApplicationUnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Product> Handle(ProductAddCommand command, CancellationToken cancellationToken)
        {
            var entity = new Product
            {
                Id = command.Id,
                Name = command.Name,
                Price = command.Price
            };

            await _unitOfWork.ProductRepository.AddAsync(entity);
            await _unitOfWork.SaveAsync();

            return entity;
        }
    }
}
