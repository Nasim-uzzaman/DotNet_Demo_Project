namespace DataAccess.Data
{
    public class Product
    {
        public int Id { get; internal set; }
        public string Title { get; internal set; }
        public string Author { get; internal set; }
        public string Description { get; internal set; }
        public string ISBN { get; internal set; }
        public int ListPrice { get; internal set; }
        public int Price { get; internal set; }
        public int Price50 { get; internal set; }
        public int Price100 { get; internal set; }
    }
}