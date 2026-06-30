using Architecture.Application.Contracts;
using Architecture.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Architecture.Web.Controllers
{
    public class TeamController : Controller
    {
        private readonly IApplicationUnitOfWork _unitOfWork;

        public TeamController(IApplicationUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }
        public IActionResult Index()
        {
            _unitOfWork.ProductRepository.Add(new Product { Id = Guid.NewGuid(), Name = "Sample Product", Price = 99});
            _unitOfWork.Save();

            return View();
        }
    }
}
