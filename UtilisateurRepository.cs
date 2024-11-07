using ProjetFilRouge.Entities;

namespace ProjetFilRouge.Repositories
{
    public class UtilisateurRepository
    {
        private List<Utilisateur> utilisateurs = new List<Utilisateur>();

        public void AddUtilisateur(Utilisateur utilisateur) => utilisateurs.Add(utilisateur);

        public Utilisateur FindByLogin(string login) => utilisateurs.FirstOrDefault(u => u.Login == login);

        public List<Utilisateur> GetAllUtilisateurs() => utilisateurs;
    }

    public class ArticleRepository
    {
        private List<Article> articles = new List<Article>();

        public void AddArticle(Article article) => articles.Add(article);

        public List<Article> GetAllArticles() => articles;

        public Article FindByName(string name) => articles.FirstOrDefault(a => a.Nom == name);

        internal void AjouterArticle(Article article)
        {
            throw new NotImplementedException();
        }
    }
}
