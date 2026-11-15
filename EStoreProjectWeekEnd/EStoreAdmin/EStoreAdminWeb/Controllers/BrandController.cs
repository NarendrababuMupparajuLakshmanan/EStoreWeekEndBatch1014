using EStoreAdminModel.Brands;
using Microsoft.AspNetCore.Mvc;

namespace EStoreAdminWeb.Controllers
{
    public class BrandController : Controller
    {
        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {

            List<BrandModel> brandModels = new List<BrandModel>();

            brandModels.Add(new BrandModel()
            {
                Id = Guid.NewGuid(),
                Name = "Samsung"
            });

            brandModels.Add(new BrandModel()
            {
                Id = Guid.NewGuid(),
                Name = "Vivo"
            });

            brandModels.Add(new BrandModel()
            {
                Id = Guid.NewGuid(),
                Name = "Airtel"
            });

            //ViewModel 
            return View(brandModels);
        }
    }
}
