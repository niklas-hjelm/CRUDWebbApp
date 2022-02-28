namespace CRUDWebbApp.DAL.Models
{
    public class Dealer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Car> Stock { get; set; }
    }
}
