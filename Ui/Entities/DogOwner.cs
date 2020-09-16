namespace Ui.Entities
{
    public class DogOwner
    {
        // added to provide an id for the records.
        public int Id { get; set; }

        public string OwnerName { get; set; }
        public string DogName { get; set; }
    }
}