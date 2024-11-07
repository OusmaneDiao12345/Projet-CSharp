using System.Collections.Generic;
using ProjetFilRouge.Entities;

namespace ProjetFilRouge.repository
{
    public class PaiementRepository
    {
        private List<Paiement> paiements = new List<Paiement>();

        public void AjouterPaiement(Paiement paiement)
        {
            paiements.Add(paiement);
        }
    }
}
