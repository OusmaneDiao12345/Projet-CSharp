using System.Collections.Generic;
using System.Linq;
using ProjetFilRouge.Entities;

namespace ProjetFilRouge.repository
{
    public class DetteRepository
    {
        private List<Dette> dettes = new List<Dette>();

        public void AjouterDette(Dette dette)
        {
            dettes.Add(dette);
        }

        public List<Dette> GetDettesNonSoldees(Client client)
        {
            return dettes.Where(d => d.Client == client && d.MontantRestant > 0).ToList();
        }
    }
}
