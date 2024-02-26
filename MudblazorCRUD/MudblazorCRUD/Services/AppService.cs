using MudblazorCRUD.Context;
using MudblazorCRUD.Data;
using MudblazorCRUD.IService;

namespace MudblazorCRUD.Services
{
    public class AppService : IAppService
    {
        private readonly DatabaseContext _context;

        public AppService(DatabaseContext context)
        {
            _context = context;

        }

        public HashSet<Article> GetArticles()
        {
            return _context.Articles.ToHashSet();
        }

        public HashSet<Document> GetDocuments()
        {
            return _context.Documents.ToHashSet();
        }


        public Article GetArticleByID(int articleID)
        {
            return _context.Articles.SingleOrDefault(x => x.Id == articleID);
            
        }

        public Document GetDocumentByID(int documentID)
        {
            return _context.Documents.SingleOrDefault(x => x.Id == documentID);
        }


        // Save article
        public void Save(Article article)
        {
            if (article.Id == 0)
            {
                _context.Articles.Add(article);
            }
            else
            {
                _context.Articles.Update(article);
            }
            _context.SaveChanges();
        }

        // Save document
        public void Save(Document document)
        {
            if(document.Id == 0)
            {
                _context.Documents.Add(document);
            }
            else
            {
                _context.Documents.Update(document);
            }
            _context.SaveChanges();
        }

        // Delete article (kanske ändra till int articleID som parameter?)
        // Kanske ändra till Task?
        public string Delete(Article article)
        {
            var articleID = article.Id;
            var _article = _context.Articles.FirstOrDefault(x => x.Id == articleID);

            if(_article != null)
            {
                _context.Articles.Remove(_article);
                _context.SaveChanges();
            }
            return "Deleted";
        }

        // Delete document
        public string Delete(Document document)
        {
            var documentID = document.Id;
            var _document = _context.Documents.FirstOrDefault(x => x.Id == documentID);

            if (_document != null)
            {
                _context.Documents.Remove(_document);
                _context.SaveChanges();
            }
            return "Deleted";
        }
    }
}
