using System;
using System.Collections.Generic;
using System.Linq;
using ProjetFilRouge.Entities;

namespace ProjetFilRouge.repository
{
    public class ArticleRepository
    {
        private List<Article> articles = new List<Article>();

        // Ajouter un article
        public void AjouterArticle(Article article)
        {
            articles.Add(article);
        }

        // Récupérer tous les articles
        public List<Article> GetAllArticles()
        {
            return articles;
        }

        // Récupérer un article par son ID
        public Article GetArticleById(int articleId)
        {
            return articles.FirstOrDefault(a => a.Id == articleId);
        }

        // Mettre à jour la quantité en stock d'un article
        public void UpdateQuantiteStock(int articleId, int nouvelleQuantite)
        {
            var article = articles.FirstOrDefault(a => a.Id == articleId);
            if (article != null)
            {
                article.QuantiteStock = nouvelleQuantite;
            }
        }

        // Lister les articles avec stock disponible
        public List<Article> GetArticlesDisponibles()
        {
            return articles.Where(a => a.QuantiteStock > 0).ToList();
        }

        // Optionnel: Trouver un article par son nom
        public Article FindByName(string name)
        {
            return articles.FirstOrDefault(a => a.Nom.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        internal void AddArticle(Article article)
        {
            throw new NotImplementedException();
        }

        public static implicit operator ArticleRepository(Repositories.ArticleRepository v)
        {
            throw new NotImplementedException();
        }
    }
}
