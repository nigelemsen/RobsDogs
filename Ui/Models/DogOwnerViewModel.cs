using System.Collections.Generic;

namespace Ui.Models
{
    public class DogOwnerViewModel
    {
        public int Id { get; set; }
        public string OwnerName { get; set; }
        public List<string> DogNames { get; set; }
    }
}