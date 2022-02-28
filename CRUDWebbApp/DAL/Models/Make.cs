namespace CRUDWebbApp.DAL.Models
{
    public class Make
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CountryOfOrigin { get; set; }
        public ICollection<Car> CarModels { get; set; }
    }
}
