using Architecture.Application.Contracts;
using Architecture.Application.Features.Products.Command;
using Architecture.Domain.Entities;
using Cortex.Mediator;
using Microsoft.AspNetCore.Mvc;

namespace Architecture.Web.Controllers
{
    public class TeamController : Controller
    {
        private readonly IMediator _mediator;

        public TeamController(IMediator mediator)
        {
            _mediator = mediator;
        }
        public IActionResult Index()
        {
            var command = new ProductAddCommand
            {
                Id = Guid.NewGuid(),
                Name = "Sample Product",
                Price = 999
            };

            var result = _mediator.SendCommandAsync(command).Result;

            return View();
        }
    }
}
