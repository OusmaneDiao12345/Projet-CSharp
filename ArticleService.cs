using ProjetFilRouge.Entities;
using ProjetFilRouge.Repositories; // Ensure the correct namespace for repository

namespace ProjetFilRouge.Services
{
    public class ArticleService
    {
        private readonly ArticleRepository articleRepo;

        public ArticleService(ArticleRepository repo) => articleRepo = repo;

        public void AddArticle(string name, int stockQuantity, decimal price)
        {
            var article = new Article(name, stockQuantity, price);
            articleRepo.AddArticle(article); // Match the method name in the repository
        }

        public List<Article> ListArticles() => articleRepo.GetAllArticles();

        public Article SearchByName(string name) => articleRepo.FindByName(name);
    }
}
