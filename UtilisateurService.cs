using ProjetFilRouge.Entities;
using ProjetFilRouge.Repositories; // Ensure the correct namespace for repository

namespace ProjetFilRouge.Services
{
    public class UtilisateurService
    {
        private readonly UtilisateurRepository utilisateurRepo;

        public UtilisateurService(UtilisateurRepository repo) => utilisateurRepo = repo;

        public void CreateUtilisateur(string email, string login, string password, string role)
        {
            var utilisateur = new Utilisateur(email, login, password, role);
            utilisateurRepo.AddUtilisateur(utilisateur);
        }

        public List<Utilisateur> ListUtilisateurs() => utilisateurRepo.GetAllUtilisateurs();

        public Utilisateur SearchByLogin(string login) => utilisateurRepo.FindByLogin(login);
    }
}
