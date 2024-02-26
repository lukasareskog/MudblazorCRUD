using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MudblazorCRUD.Data
{
    public class Article
    {
        [Key] // Databasgenererat Autoincrement
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ArticleID { get; set; }
        public string Title { get; set; } 
        public int DocumentID { get; set; }
        public Document Document { get; set; }
    }

}
