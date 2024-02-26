using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MudblazorCRUD.Data
{
    public class Document
    {

        [Key] // Databasgenererat Autoincrement
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; } = "";
    }
}
