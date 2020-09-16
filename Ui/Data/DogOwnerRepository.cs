using System.Collections.Generic;
using Ui.Entities;

namespace Ui.Data
{
    public class DogOwnerRepository
    {
        public List<DogOwner> GetAllDogOwners()
        {

            List<DogOwner> dogOwnerList = new List<DogOwner>();

            // orginal record, Id amended in.
            dogOwnerList.Add(
                new DogOwner
                {
                    Id = 1,
                    OwnerName = "Rob",
                    DogName = "Willow"
                });

            // new record 1, interview test requirement
            dogOwnerList.Add(
                new DogOwner
                {
                    Id = 2,
                    OwnerName = "Rob",
                    DogName = "Nook"
                });

            // new record 2, interview test requirement
            dogOwnerList.Add(
                 new DogOwner
                 {
                     Id = 3,
                     OwnerName = "Rob",
                     DogName = "Sok"
                 });


            return dogOwnerList;
        }
    }
}