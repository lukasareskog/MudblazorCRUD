using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MudblazorCRUD.Data
{
    public class Article
    {
        [Key] // Databasgenererat Autoincrement
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; } = "";

        [ForeignKey(nameof(Document.Id))]
        public int DocumentID { get; set; }
    }

}
