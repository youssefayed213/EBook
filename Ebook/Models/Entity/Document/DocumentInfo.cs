namespace Ebook.Models.Entity.Document
{
    public class DocumentInfo
    {
        public Document DocumentGroup { get; set; }
        public Ebook EbookGroup { get; set; }
        public Ejournal EjournalGroup { get; set; }
        
    }
}