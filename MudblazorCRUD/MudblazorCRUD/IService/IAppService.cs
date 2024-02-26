using MudblazorCRUD.Data;

namespace MudblazorCRUD.IService
{
    public interface IAppService
    {
        HashSet<Article> GetArticles();
        HashSet<Document> GetDocuments();
        Article GetArticleByID(int articleID);
        Document GetDocumentByID(int documentID);

        void Save(Article article);
        void Save(Document document);
        string Delete(Article article);
        string Delete(Document document);
    }
}
