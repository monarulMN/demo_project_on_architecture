using Architecture.Domain.Entities;
using Cortex.Mediator.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Architecture.Application.Features.Products.Command
{
    public class ProductAddCommand : ICommand<Product>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
