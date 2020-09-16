using System.Collections.Generic;
using System.Linq;
using Ui.Models;
using Ui.Services;

namespace Ui.ViewModelMappers
{
    public class DogOwnerViewModelMapper
    {
        public DogOwnerListViewModel GetAllDogOwners()
        {
            DogOwnerService dogOwnerService = new DogOwnerService();
            List<Entities.DogOwner> dogOwners = dogOwnerService.GetAllDogOwners();
            DogOwnerListViewModel dogOwnerListViewModel = new DogOwnerListViewModel
            {
                DogOwnerViewModels = dogOwners.Select(e => new DogOwnerViewModel
                {
                    Id = e.Id,
                    OwnerName = e.OwnerName,
                    DogNames = new List<string>
                    {
                        e.DogName
                    }
                }).ToList()
            };

            return dogOwnerListViewModel;
        }
    }
}