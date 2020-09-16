using System.Web.Mvc;
using Ui.ViewModelMappers;

namespace Ui.Controllers
{
    public class RobsDogsController : Controller
    {
        // GET: RobsDogs
        public ActionResult Index()
        {
            DogOwnerViewModelMapper dogOwnerViewModelMapper = new DogOwnerViewModelMapper();
            Models.DogOwnerListViewModel dogOwnerListViewModel = dogOwnerViewModelMapper.GetAllDogOwners();

            return View(dogOwnerListViewModel);
        }
    }
}