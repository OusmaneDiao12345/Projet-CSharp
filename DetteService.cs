using ProjetFilRouge.Entities;
using ProjetFilRouge.repository;

namespace ProjetFilRouge.service
{
    public class DetteService
{
    private List<Dette> dettes = new List<Dette>();

        public DetteService(DetteRepository detteRepo)
        {
            DetteRepo = detteRepo;
        }

        public DetteRepository DetteRepo { get; }

        public void CreerDette(Client client, DateTime date, decimal montant, List<Article> articles)
    {
        Dette dette = new Dette(client, date, montant, articles);
        dettes.Add(dette);
    }

    public List<Dette> ListerDettesNonSoldees(Client client)
    {
        return dettes.Where(d => d.Client == client && d.MontantRestant > 0).ToList();
    }

    public void EnregistrerPaiement(Dette dette, DateTime date, decimal montant)
    {
        if (dette.MontantRestant > 0)
        {
            dette.Paiements.Add(new Paiement(date, montant));
            dette.MontantRestant -= montant;
        }
    }

    public List<Dette> ListerDemandesDeDetteEnCours(List<Dette> dettes, string statut)
    {
        // Ici, vous pouvez filtrer par statut (En Cours, Annulé)
        // En Cours ou Annulé, ici on suppose que toutes les dettes sont en cours
        return dettes.Where(d => d.MontantRestant > 0).ToList();
    }
}


}