using ProjetFilRouge.Entities;

namespace ProjetFilRouge.Views
{
    public class UtilisateurView
    {
        public void DisplayUtilisateurs(List<Utilisateur> utilisateurs)
        {
            foreach (var utilisateur in utilisateurs)
            {
                Console.WriteLine($"Email: {utilisateur.Email}, Login: {utilisateur.Login}, Role: {utilisateur.Role}, Active: {utilisateur.IsActive}");
            }
        }

        public void DisplayUtilisateur(Utilisateur utilisateur)
        {
            if (utilisateur != null)
                Console.WriteLine($"Email: {utilisateur.Email}, Login: {utilisateur.Login}, Role: {utilisateur.Role}");
            else
                Console.WriteLine("Utilisateur not found.");
        }
    }

    public class ArticleView
    {
        public void DisplayArticles(List<Article> articles)
        {
            foreach (var article in articles)
            {
                Console.WriteLine($"Name: {article.Nom}, Stock Quantity: {article.QuantiteStock}, Price: {article.Prix}");
            }
        }

        public void DisplayArticle(Article article)
        {
            if (article != null)
                Console.WriteLine($"Name: {article.Nom}, Stock Quantity: {article.QuantiteStock}, Price: {article.Prix}");
            else
                Console.WriteLine("Article not found.");
        }
    }
}
