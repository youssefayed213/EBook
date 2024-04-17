using Ebook.Models.Entity.Document;

namespace Ebook.Models.Entity.Product
{
    public class Item
    {
        public DocumentInfo Product { get; set; }

        public int Quantity { get; set; }
    }
}