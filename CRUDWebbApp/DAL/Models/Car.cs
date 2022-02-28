namespace CRUDWebbApp.DAL.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string ModelName { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public int MakeId { get; set; }
        public Make Make { get; set; }

        public ICollection<Dealer> Dealers { get; set; }
    }
}
