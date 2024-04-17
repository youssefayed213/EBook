using System.ComponentModel.DataAnnotations;

namespace Ebook.Models.Entity.Author
{
    public class Author
    {


        public Author()
        {
            
        }
        public Author(int id, int idEditor,string name, string photo, string biography)
        {
            Id = id;
            IdEditor = idEditor;
            Name = name;
            Photo = photo;
            Biography = biography;
        }
        #region Author Fields

        public int Id { get; set; }
        [Required] public int IdEditor { get; set; }
        [Required] public string Name { get; set; }
        public string Biography { get; set; }
        public string Photo { get; set; }


        #endregion
    }
}